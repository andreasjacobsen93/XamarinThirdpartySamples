//
// MainActivity.cs: Single screen that brings up a spinner in an AlertDialog
//
// Author:
//   Nina Vyedin (nina.vyedin@xamarin.com)
//
// Copyright (C) 2013 Xamarin, Inc (http://www.xamarin.com)
// Distributed under MIT License (http://opensource.org/licenses/MIT)
//

using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AlertSpinner
{
	[Activity (Label = "AlertSpinner", MainLauncher = true)]
	public class MainActivity : Activity
	{
		// villain names from Sentinels of the Multiverse: http://sentinelsofthemultiverse.com/ :)
		string[] villains = { "Citizen Dawn", "Baron Blade", "Omnitron", "Plague Rat", "The Dreamer", "Gloom Weaver", "Kismet", "Iron Legacy" };
		Button button;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			button = FindViewById<Button> (Resource.Id.button);

			button.Click += (o, e) =>  {
				// use an array adapter to populate a spinner item from our string array
				ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
					Android.Resource.Layout.SimpleSpinnerItem, villains);

				// create the spinner and populate it with our items
				Spinner spinner = new Spinner(this);
				spinner.LayoutParameters = new LinearLayout.LayoutParams (ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
				spinner.Adapter = adapter;

				// handle item selection
				spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (ItemSelected);

				// build the alert dialog
				AlertDialog.Builder builder = new AlertDialog.Builder(this);
				builder.SetView(spinner);
				builder.SetNeutralButton("OK", delegate {});
				builder.Show();
			};
		}

		void ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
		{
			// get reference to spinner (sender)
			Spinner spinner = (Spinner)sender;

			// get value at selected
			button.Text = "Villain: " + spinner.GetItemAtPosition (e.Position);
		}


	}
}


