using System;
using Xamarin.Forms;

namespace LoginRecipe
{
	public static class App
	{
		static ILoginManager loginManager;

		public static Page GetSplashPage(ILoginManager ilm)
		{
			loginManager = ilm;
			return new SplashPage (ilm);
		}

		public static Page GetLoginPage (ILoginManager ilm)
		{	
			loginManager = ilm;
			//			return new LoginPage (ilm);
			return new LoginPage (ilm);
		}

		public static Page GetMainPage ()
		{	
			return new MainPage ();
		}

		public static void Logout ()
		{
			loginManager.Logout();
		}
	}
}

