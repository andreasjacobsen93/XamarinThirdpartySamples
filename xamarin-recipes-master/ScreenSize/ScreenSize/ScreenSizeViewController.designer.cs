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

namespace ScreenSize
{
	[Register ("ScreenSizeViewController")]
	partial class ScreenSizeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel sizeLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (sizeLabel != null) {
				sizeLabel.Dispose ();
				sizeLabel = null;
			}
		}
	}
}
