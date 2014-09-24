using System;
using Xamarin.Forms;

namespace LoginRecipe
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
			var logoutButton = new Button { Text = "Logout" };
			logoutButton.Clicked += (sender, e) => {
				App.Logout();
			};

			Content = new StackLayout {
				Padding = new Thickness (10, 40, 10, 10),
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					new Label { Text = "Success", Font = Font.SystemFontOfSize (NamedSize.Large) }, 
					logoutButton
				}
			};

		}
	}
}

