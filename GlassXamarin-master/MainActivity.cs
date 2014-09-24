using System;
using System.Collections;
using System.Collections.Generic;
using Android.App;
using Android.Media;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Speech;
using Android.Widget;
using Android.Util;
using Android.OS;
using Android.Glass.App;
using Android.Glass.View;
using Android.Glass.Widget;
using Android.Glass.Media;
using Android.Glass.Touchpad;
using System.Linq;
using LinqToTwitter;
using System.Net;
using System.Net.Http;
using System.Runtime;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using TwitterHashtags;


namespace HelloGlassWorld
{
	[Activity (Label = "YOLO (for Glass)", Icon = "@drawable/Icon", MainLauncher = true, Enabled = true)]
	[IntentFilter (new String[]{ "com.google.android.glass.action.VOICE_TRIGGER" })]
	[MetaData ("com.google.android.glass.VoiceTrigger", Resource = "@xml/voicetriggerstart")]
	public class MainActivity : Activity
	{

        //Glass globals
        public static List<Card> cards;
        private TweetScrollAdapter adapter = new TweetScrollAdapter();
        private CardScrollView scroller;
        private Android.Glass.Touchpad.GestureDetector gestureDetector;

        //Twitter globals
        public static string hashtag = "yolo";
        private ApplicationOnlyAuthorizer auth;
        private ulong sinceId = 490011539664293888;

        //Generic globals
        private ISharedPreferences prefs;
        private HashSet<String> hashtagPrefs = new HashSet<string>();
        private AudioManager audioManager;

		protected async override void OnCreate (Bundle bundle)
		{
            //Generic onCreate for the activity
			base.OnCreate (bundle);
            
            //Gesture management
            gestureDetector = createGestureDetector(this);

            //Stops Glass from turning the screen off
            Window.AddFlags(WindowManagerFlags.KeepScreenOn);

            //Creates the AudioManager for the tap responses
            audioManager = (AudioManager)GetSystemService(Context.AudioService);

            //Load hashtag history using preferences
            prefs = GetSharedPreferences("tweets", 0);
            HashSet<String> defaultPrefs = new HashSet<String>();
            defaultPrefs.Add("YOlO");
            var tempHashtagPrefs = prefs.GetStringSet("hashtags", defaultPrefs);
            foreach (var x in tempHashtagPrefs)
            {
                hashtagPrefs.Add(x);
            }

            //Create title card
            cards = new List<Card>();
            AddCard("YOLO (for Glass", "Tap to load cards");

            //Set up card scroller
            scroller = new CardScrollView(this);
            scroller.Adapter = adapter;

            //Handles touchpad tap
            scroller.ItemClick += (system, e) => 
                tweetRefresh();
            
            //Twitter auth and setup
            var tht = new TwitterHashtags.TwitterHashtags();
            auth = await tht.doAuth();

            //Activate the view
            SetContentView(scroller);
		}

        protected override void OnResume()
        {
            scroller.Activate();
            base.OnResume();
        }
        protected override void OnPause()
        {
            scroller.Deactivate();
            base.OnPause();
        }
        private void AddCard(string inText, string inFootnote)
        {
            Card card = new Card(this);
            card.SetText(inText);
            card.SetFootnote(inFootnote);
            cards.Add(card);
        }
        private class TweetScrollAdapter : CardScrollAdapter
        {
            public override int GetPosition(Java.Lang.Object p0)
            {
                var card = (Card)p0;
                return cards.FindIndex(x => x.Text == card.Text);
            }

            public override int Count
            {
                get { return cards.Count;}
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return cards[position];
            }

            public override int GetItemViewType(int position)
            {
                return base.GetItemViewType(position);
            }

            public override int ViewTypeCount
            {
                get
                {
                    return base.ViewTypeCount;
                }
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                return cards[position].GetView(convertView, parent);
            }
        }
        private void displaySpeechRecognizer()
        {
            //Starts the speech recognizer activity and waits for result
            Intent intent = new Intent(RecognizerIntent.ActionRecognizeSpeech);
            StartActivityForResult(intent, 0);
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            //If the result is from the speech recognizer
            if (requestCode == 0 && resultCode == Result.Ok)
            {
                //Retrieve the string from the results
                IList<String> results = data.GetStringArrayListExtra(RecognizerIntent.ExtraResults);
                String spokenText = results[0];
                
                //Add the string to the hashtag history
                hashtagPrefs.Add(spokenText);
                ISharedPreferencesEditor editor = prefs.Edit();
                editor.PutStringSet("hashtags", hashtagPrefs);
                editor.Commit();

                hashtag = spokenText;
            }
            base.OnActivityResult(requestCode, resultCode, data);
        } 
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            //Load the menu layout
            MenuInflater inflater = new MenuInflater(this);
            inflater.Inflate(Resource.Menu.hashtags, menu);
            return true;
        }
        public static void SetHashtag(string text)
        {
            hashtag = text;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.hashtag_menu_item:
                    //Start the hashtag history activity
                    StartActivity(new Intent(this, typeof(HistoryActivity)));
                    return true;
                case Resource.Id.listen_menu_item:
                    //Display the speech recognizer
                    displaySpeechRecognizer();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
        private Android.Glass.Touchpad.GestureDetector createGestureDetector(Context context)
        {
            //Set up and add a listener for the double-tap gesture
            GestureListener listener = new GestureListener();
            listener.OnUpdateStatus += listener_OnUpdateStatus;
            var gestureDetector = new Android.Glass.Touchpad.GestureDetector(context);
            gestureDetector.SetBaseListener(listener);
            return gestureDetector;
        }
        public override bool OnGenericMotionEvent(MotionEvent ev)
        {
            if (gestureDetector != null)
            {
                return gestureDetector.OnMotionEvent(ev);
            }
            return false;
        }
        void listener_OnUpdateStatus()
        {
            OpenOptionsMenu();
        }
        public class GestureListener : Java.Lang.Object, Android.Glass.Touchpad.GestureDetector.IBaseListener
        {

            public delegate void UpdateHandler();
            public event UpdateHandler OnUpdateStatus;

            public bool OnGesture(Gesture gesture)
            {
                if (gesture == Gesture.TwoTap)
                {
                    //Check if anything is actually subscribed to the handle
                    if (OnUpdateStatus != null)
                    {
                        OnUpdateStatus();
                    }
                    
                    return true;
                }

                return false;
            }
        }
        public async void tweetRefresh()
        {
            //If we're on the last card, get new tweets
            if (scroller.SelectedItemPosition == adapter.Count - 1)
            {
                //Play sound effect for feedback
                audioManager.PlaySoundEffect(SoundEffect.KeyClick);

                //Create twitter object and get search results
                var tht = new TwitterHashtags.TwitterHashtags();
                var searchResponse = await tht.getTweets(hashtag, sinceId, auth);

                //As long as there's something
                if (searchResponse != null && searchResponse.Statuses != null)
                {
                    //Add each tweet as a card
                    foreach (var tweet in searchResponse.Statuses)
                    {
                        if (tweet.StatusID > sinceId)
                        {
                            AddCard(tweet.Text, tweet.User.Name + " - " + tweet.CreatedAt);
                        }
                    }

                    //Update the sinceId counter
                    sinceId = searchResponse.Statuses[0].StatusID;
                   
                    //Play sound effect for notification
                    audioManager.PlaySoundEffect(SoundEffect.Invalid);
                     
                }
                  
            }
            //Otherwise, jump to the last card
            else
            {
                scroller.SetSelection(adapter.Count - 1);
            }
        }

	}

  
}


