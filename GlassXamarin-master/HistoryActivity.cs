using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Glass.App;
using Android.Glass.View;
using Android.Glass.Widget;

namespace HelloGlassWorld
{
    [Activity(Label = "HistoryActivity")]
    public class HistoryActivity : Activity
    {
        public static List<Card> cards;
        private TweetScrollAdapter adapter = new TweetScrollAdapter();
        private CardScrollView scroller;

        //Generic globals
        private ISharedPreferences prefs;
        private HashSet<String> hashtagPrefs = new HashSet<string>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            cards = new List<Card>();
            scroller = new CardScrollView(this);
            // Set our view from the GDK Card API
            prefs = GetSharedPreferences("tweets", 0);
            HashSet<String> defaultPrefs = new HashSet<String>();
            defaultPrefs.Add("YOlO");
            var tempHashtagPrefs = prefs.GetStringSet("hashtags", defaultPrefs);
            foreach (var hashtag in tempHashtagPrefs)
            {
                AddCard(hashtag, "");
            }
            scroller.Adapter = adapter;
            scroller.ItemClick += (system, e) => { Card cardz = (Card)adapter.GetItem(e.Position); string z = cardz.Text; MainActivity.SetHashtag(z); Finish(); };
            SetContentView(scroller);
            // Create your application here
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
                Card xx = (Card)p0;
                //.cardreturn cards.FindIndex(x => x.Text == xx.Text);
                return 0;
                throw new NotImplementedException();
            }

            public override int Count
            {
                get { return cards.Count; throw new NotImplementedException(); }
            }

            public override Java.Lang.Object GetItem(int position)
            {
                return cards[position];
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }
    }
}