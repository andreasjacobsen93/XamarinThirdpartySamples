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
using Android.Views.Animations ;


namespace SplashAndroide
{
	[Activity (Label = "SplashScreen1",MainLauncher = true,NoHistory = true)]			
	public class SplashScreen : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Splash);

			HomeScreen home = new HomeScreen ();
			CountDown countDown = new CountDown (5000, 5000, this, home);
			countDown.Start ();
			StartAnim ();
			// Create your application here
		}


		public void StartAnim()
		{
			Animation anim = AnimationUtils.LoadAnimation (this, Resource.Animation.alpha);
			anim.Reset ();

			var lnMain = FindViewById<LinearLayout> (Resource.Id.lnMain);
			lnMain.ClearAnimation ();
			lnMain.StartAnimation (anim);


			anim = AnimationUtils.LoadAnimation (this, Resource.Animation.translate);
			anim.Reset ();


			var imgMain = FindViewById<ImageView> (Resource.Id.imgMain);
			imgMain.ClearAnimation ();
			imgMain.StartAnimation (anim);



		}

	}
}

