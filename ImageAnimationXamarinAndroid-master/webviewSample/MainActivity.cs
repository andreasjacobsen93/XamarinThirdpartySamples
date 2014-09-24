using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace webviewSample
{

	[Activity (Label = "WebviewImgAnimationSample", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
		
			var wv = FindViewById<WebView>(Resource.Id.mywebview);

			wv.LoadUrl("file:///android_asset/monkeyHome.html");

			wv.SetWebViewClient(new MonkeyWebViewClient());

			wv.Settings.LoadWithOverviewMode = false;
			wv.Settings.UseWideViewPort = false;

			// scrollbar stuff
			wv.ScrollBarStyle = ScrollbarStyles.OutsideOverlay; // so there's no 'white line'
			wv.ScrollbarFadingEnabled = false;
		}

		class MonkeyWebViewClient : WebViewClient {
			public override bool ShouldOverrideUrlLoading(WebView view, string url)
			{
				view.LoadUrl(url);
				return true;
			}
		}
	}
}


