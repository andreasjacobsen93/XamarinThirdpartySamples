using Android.App;
using Android.Widget;
using Android.OS;
using MonoDroid.VerticalSeekbar;

namespace MonoDroid.VerticalSeekbarTest
{
    [Activity(Label = "VerticalSeekbar Test", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var seekbar1 = FindViewById<VerticalSeekBar>(Resource.Id.seekbar1);
            var progress1 = FindViewById<TextView>(Resource.Id.progress1);

            var seekbar2 = FindViewById<VerticalSeekBar>(Resource.Id.seekbar2);
            var progress2 = FindViewById<TextView>(Resource.Id.progress2);

            seekbar1.ProgressChanged +=
                (sender, args) => progress1.Text = string.Format("{0}%", args.Progress);

            seekbar2.ProgressChanged +=
                (sender, args) => progress2.Text = string.Format("{0}%", args.Progress);

            seekbar1.Min = 10;
            seekbar1.Progress = 10;
        }
    }
}

