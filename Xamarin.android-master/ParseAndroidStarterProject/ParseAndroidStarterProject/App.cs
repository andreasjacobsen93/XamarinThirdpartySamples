using System;
using Android.App;
using Android.Runtime;
using Parse;

namespace ParseAndroidStarterProject
{
	[Application]
	public class App : Application
	{
		public App (IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		public override void OnCreate ()
		{
			base.OnCreate ();

			// Initialize the Parse client with your Application ID and .NET Key found on
			// your Parse dashboard
			ParseClient.Initialize("fRLApvlK2dPq7QtjZqs5zMGMNsqsWM7fRgV9EUc7","xEgWutKqR6nulmGeS1G1LmYdrMg1Qcdsq3plj6XA");
		}
	}
}
