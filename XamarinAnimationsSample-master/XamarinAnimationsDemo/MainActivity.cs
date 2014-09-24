using System;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamarinAnimationsDemo
{
    [Activity(Label = "XamarinAnimationsDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        private static Sample[] _samples;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _samples = new []
            {
                new Sample
                {
                    Title = Resources.GetString(Resource.String.title_crossfade),
                    ActivityType = typeof(CrossfadeActivity)
                },
                new Sample
                {
                    Title = Resources.GetString(Resource.String.title_card_flip),
                    ActivityType = typeof(CardFlipActivity)
                },
                new Sample
                {
                    Title = Resources.GetString(Resource.String.title_screen_slide),
                    ActivityType = typeof(ScreenSlideActivity)
                },
                new Sample
                {
                    Title = Resources.GetString(Resource.String.title_zoom),
                    ActivityType = typeof(ZoomActivity)
                },
                new Sample
                {
                    Title = Resources.GetString(Resource.String.title_layout_changes),
                    ActivityType = typeof(LayoutChangeActivity)
                }
            };

            ListAdapter = new ArrayAdapter<Sample>(this, Android.Resource.Layout.SimpleListItem1, 
                Android.Resource.Id.Text1,
                _samples);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            StartActivity(new Intent(this, _samples[position].ActivityType));
        }

        private class Sample
        {
            public string Title { get; set; }
            public Type ActivityType { get; set; }

            public override string ToString()
            {
                return Title;
            }
        }
    }


}

