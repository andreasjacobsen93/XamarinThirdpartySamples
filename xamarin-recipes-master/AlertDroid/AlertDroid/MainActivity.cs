//
// MainActivity.cs: Single screen that summons an alert dialog
//
// Author:
//   Nina Vyedin (nina.vyedin@xamarin.com)
//
// Copyright (C) 2013 Xamarin, Inc (http://www.xamarin.com)
// Distributed under MIT License (http://opensource.org/licenses/MIT)
//

using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace AlertDroid
{
	[Activity (Label = "AlertDroid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 0;
		Button button;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			button = FindViewById<Button> (Resource.Id.myButton);

			// Get our button from the layout resource,
			// and attach an event to it
			button.Click += ShowAlert;
		}

		void ShowAlert (object sender, EventArgs e)
		{
			// make a new alert dialog builder, passing in the current Context
			AlertDialog.Builder dialog = new AlertDialog.Builder (this);

			dialog.SetTitle ("My Alert Dialog");
			dialog.SetIcon (Resource.Drawable.Icon);
			dialog.SetMessage ("Add to click count?");
			dialog.SetNeutralButton ("OK", delegate {
				count++;
				button.Text = count + " clicks!";
			});
			dialog.SetNegativeButton ("Cancel", delegate {
				// add code to handle cancel button click, if necessary
			});

			dialog.Show ();
		}
	}
}


