using System;
using Xamarin.Forms;

namespace LoginRecipe
{
	public class SplashPage : ContentPage
	{
		public SplashPage (ILoginManager ilm)
		{

			var button = new Button { Text = "Login" };
			button.Clicked += (sender, e) => {
					ilm.ShowLoginPage();
			};

				 Content = new StackLayout {
				Padding = new Thickness (10, 40, 10, 10),
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					new Label { Text = "Welcome", Font = Font.SystemFontOfSize (NamedSize.Large) }, 
					button
				}
			};


		}
	}
}

