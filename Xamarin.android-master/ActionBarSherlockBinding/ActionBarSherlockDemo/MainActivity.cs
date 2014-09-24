using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ActionBar_Sherlock.App;
using ActionBar_Sherlock.View;
using ActionBar_Sherlock.Widget;
using IMenu = ActionBar_Sherlock.View.IMenu;
using IMenuItem=ActionBar_Sherlock.View.IMenuItem;

namespace ActionBarSherlockDemo
{
	[Activity (Label = "ActionBarSherlockDemo", MainLauncher = true)]
	public class MainActivity : SherlockActivity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};
		}

		public override bool OnCreateOptionsMenu(IMenu menu) {

			menu.Add ("Guardar")
				.SetIcon (Resource.Drawable.compose)
					.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionWithText);

			menu.Add ("Buscar")
				.SetIcon (Resource.Drawable.search)
					.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionWithText);

			menu.Add ("Actualizar")
				.SetIcon (Resource.Drawable.refresh)
					.SetShowAsAction (MenuItem.ShowAsActionIfRoom | MenuItem.ShowAsActionWithText);

			return base.OnCreateOptionsMenu(menu);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			// If this callback does not handle the item click, onPerformDefaultAction
			// of the ActionProvider is invoked. Hence, the provider encapsulates the
			// complete functionality of the menu item.

			Toast.MakeText (this, "Presiono "+item.TitleFormatted,
			               ToastLength.Short).Show ();
			return false;
		}



	}
}


