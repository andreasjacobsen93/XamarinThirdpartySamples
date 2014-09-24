using MonoTouch.Foundation;
using System;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;


namespace FXBlurViewLib
{
	[Category, BaseType (typeof (UIImage))]
	public partial interface FXBlurView_UIImage {

		[Export ("blurredImageWithRadius:iterations:tintColor:")]
		UIImage BlurredImageWithRadius (float radius, uint iterations, UIColor tintColor);
	}

	[BaseType (typeof (UIView))]
	public partial interface FXBlurView {

		[Static, Export ("setUpdatesEnabled")]
		void SetUpdatesEnabled ();

		[Static, Export ("setUpdatesDisabled")]
		void SetUpdatesDisabled ();

		[Export ("blurEnabled")]
		bool BlurEnabled { [Bind ("isBlurEnabled")] get; set; }

		[Export ("dynamic")]
		bool Dynamic { [Bind ("isDynamic")] get; set; }

		[Export ("iterations")]
		uint Iterations { get; set; }

		[Export ("updateInterval")]
		double UpdateInterval { get; set; }

		[Export ("blurRadius")]
		float BlurRadius { get; set; }

		[Export ("tintColor", ArgumentSemantic.Retain)]
		UIColor TintColor { get; set; }

		[Export ("underlyingView", ArgumentSemantic.Assign)]
		UIView UnderlyingView { get; set; }

		[Export ("updateAsynchronously:completion:")]
		void UpdateAsynchronously (bool async, Action<bool> completion);
	}
}

