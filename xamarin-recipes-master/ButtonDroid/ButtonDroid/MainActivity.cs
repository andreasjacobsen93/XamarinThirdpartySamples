//
// MainActivity.cs: Single screen demonstrating three ways to handle button clicks in code
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

namespace ButtonDroid
{
	[Activity (Label = "ButtonDroid", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button onclick = FindViewById<Button> (Resource.Id.button1);
			Button del = FindViewById<Button> (Resource.Id.button2);
			Button lambda = FindViewById<Button> (Resource.Id.button3);

			// handle button click with a separate method
			onclick.Click += OnClick;

			// handle button click with a delegate
			del.Click += delegate {
				del.Text = string.Format ("Click handled with delegate");
			};

			// handle button click with a lambda
			lambda.Click += (o, e) => {
				lambda.Text = string.Format ("Click handled with lambda");
			};
		}

		void OnClick (object sender, EventArgs e)
		{
			Button button = (Button)sender;
			button.Text = "Click handled by OnClick method";
		}
	}
}


