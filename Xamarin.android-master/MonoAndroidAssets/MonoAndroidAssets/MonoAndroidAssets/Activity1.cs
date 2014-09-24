using System;
using System.IO;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MonoAndroidAssets
{
    [Activity(Label = "MonoAndroidAssets", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            string content;
            TextView textView = new TextView(this);
            base.OnCreate(bundle);
            using (StreamReader sr = 
                 new StreamReader (Assets.Open ("aboutInternet.txt")))
            content = sr.ReadToEnd ();

            textView.Text = content;
            SetContentView(textView);
        }
    }
}

