using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomUISwitch
{
	public partial class CustomUISwitchViewController : UIViewController
	{
		public CustomUISwitchViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			CustomSwitch.On = false;

			//Initialize Text and Switch Settings 
			SwitchLabel.Text = "Switch is off";
			CustomSwitch.OnTintColor = UIColor.Purple;

			// Create custom UIColor 
			UIColor lightP = UIColor.FromRGB (184, 152, 205);
			// Set Tint and ThumbTintColors
			CustomSwitch.TintColor = lightP;
			CustomSwitch.ThumbTintColor = lightP;


			//Handle CustomSwitch Value Change 
			CustomSwitch.ValueChanged += delegate {
				//Check to see new value, change Switch Label Accordingly 
				if (CustomSwitch.On) {
					SwitchLabel.Text = "Switch is on";
				} else {
					SwitchLabel.Text = "Switch is off";
				}
			};

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

