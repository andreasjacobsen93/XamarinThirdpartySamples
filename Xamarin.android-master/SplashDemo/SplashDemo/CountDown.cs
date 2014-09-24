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

namespace SplashAndroide
{
	class CountDown : CountDownTimer
	{
		private Activity _act;
		private Activity _actLaunch;

		public CountDown( long millisInFuture, long countDown, Activity act, Activity actLaunch):
			base (millisInFuture,countDown)
		{
			_act = act;
			_actLaunch = actLaunch;
		}

		public override void OnFinish ()
		{
			_act.StartActivity (_actLaunch.GetType());
			_act.Finish ();
		}

		public override void OnTick (long millisUntilFinished)
		{

		}


	}
}

