//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using MonoTouch.CoreVideo;
using OpenTK;

namespace GoogleAdMobAds {
	[Protocol (Name = "GADBannerViewDelegate", WrapperType = typeof (GADBannerViewDelegateWrapper))]
	public interface IGADBannerViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADBannerViewDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveAd (this IGADBannerViewDelegate This, GADBannerView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewDidReceiveAd:"), view.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFailToReceiveAd (this IGADBannerViewDelegate This, GADBannerView view, GADRequestError error)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("adView:didFailToReceiveAdWithError:"), view.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void WillPresentScreen (this IGADBannerViewDelegate This, GADBannerView adView)
		{
			if (adView == null)
				throw new ArgumentNullException ("adView");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewWillPresentScreen:"), adView.Handle);
		}
		
		[CompilerGenerated]
		public static void WillDismissScreen (this IGADBannerViewDelegate This, GADBannerView adView)
		{
			if (adView == null)
				throw new ArgumentNullException ("adView");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewWillDismissScreen:"), adView.Handle);
		}
		
		[CompilerGenerated]
		public static void DidDismissScreen (this IGADBannerViewDelegate This, GADBannerView adView)
		{
			if (adView == null)
				throw new ArgumentNullException ("adView");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewDidDismissScreen:"), adView.Handle);
		}
		
		[CompilerGenerated]
		public static void WillLeaveApplication (this IGADBannerViewDelegate This, GADBannerView adView)
		{
			if (adView == null)
				throw new ArgumentNullException ("adView");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewWillLeaveApplication:"), adView.Handle);
		}
		
	}
	
	internal sealed class GADBannerViewDelegateWrapper : IGADBannerViewDelegate {
		public IntPtr Handle { get; set; }
		
		public GADBannerViewDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADBannerViewDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADBannerViewDelegateWrapper ()
		{
			Dispose ();
		}
		
		public void Dispose ()
		{
			if (Handle != IntPtr.Zero) {
				Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("release"));
				Handle = IntPtr.Zero;
			}
			GC.SuppressFinalize (this);
		}
		
	}
}
namespace GoogleAdMobAds {
	[Protocol]
	[Register("GADBannerViewDelegate", true)]
	[Model]
	public unsafe partial class GADBannerViewDelegate : NSObject, IGADBannerViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADBannerViewDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public GADBannerViewDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADBannerViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADBannerViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adViewDidReceiveAd:")]
		[CompilerGenerated]
		public virtual void DidReceiveAd (GADBannerView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adView:didFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public virtual void DidFailToReceiveAd (GADBannerView view, GADRequestError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewWillPresentScreen:")]
		[CompilerGenerated]
		public virtual void WillPresentScreen (GADBannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewWillDismissScreen:")]
		[CompilerGenerated]
		public virtual void WillDismissScreen (GADBannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewDidDismissScreen:")]
		[CompilerGenerated]
		public virtual void DidDismissScreen (GADBannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewWillLeaveApplication:")]
		[CompilerGenerated]
		public virtual void WillLeaveApplication (GADBannerView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GADBannerViewDelegate */
}
