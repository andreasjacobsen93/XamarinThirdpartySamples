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

namespace OpenMapsURI
{
	[Register ("OpenMapsURIViewController")]
	partial class OpenMapsURIViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField cityText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton mapButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (cityText != null) {
				cityText.Dispose ();
				cityText = null;
			}
			if (mapButton != null) {
				mapButton.Dispose ();
				mapButton = null;
			}
		}
	}
}
