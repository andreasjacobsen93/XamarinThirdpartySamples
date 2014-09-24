// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace CustomUISwitch
{
	[Register ("CustomUISwitchViewController")]
	partial class CustomUISwitchViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch CustomSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel SwitchLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CustomSwitch != null) {
				CustomSwitch.Dispose ();
				CustomSwitch = null;
			}
			if (SwitchLabel != null) {
				SwitchLabel.Dispose ();
				SwitchLabel = null;
			}
		}
	}
}
