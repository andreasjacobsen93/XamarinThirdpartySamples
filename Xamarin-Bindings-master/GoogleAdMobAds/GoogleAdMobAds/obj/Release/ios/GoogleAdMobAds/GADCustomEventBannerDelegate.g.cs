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
	[Protocol (Name = "GADCustomEventBannerDelegate", WrapperType = typeof (GADCustomEventBannerDelegateWrapper))]
	public interface IGADCustomEventBannerDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADCustomEventBannerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveAd (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent, global::MonoTouch.UIKit.UIView view)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			if (view == null)
				throw new ArgumentNullException ("view");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("customEventBanner:didReceiveAd:"), customEvent.Handle, view.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFailAd (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent, NSError error)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("customEventBanner:didFailAd:"), customEvent.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidClickInAd (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent, global::MonoTouch.UIKit.UIView view)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			if (view == null)
				throw new ArgumentNullException ("view");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("customEventBanner:clickDidOccurInAd:"), customEvent.Handle, view.Handle);
		}
		
		[CompilerGenerated]
		public static void WillPresentModal (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventBannerWillPresentModal:"), customEvent.Handle);
		}
		
		[CompilerGenerated]
		public static void WillDismissModal (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventBannerWillDismissModal:"), customEvent.Handle);
		}
		
		[CompilerGenerated]
		public static void DidDismissModal (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventBannerDidDismissModal:"), customEvent.Handle);
		}
		
		[CompilerGenerated]
		public static void WillLeaveApplication (this IGADCustomEventBannerDelegate This, GADCustomEventBanner customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventBannerWillLeaveApplication:"), customEvent.Handle);
		}
		
	}
	
	internal sealed class GADCustomEventBannerDelegateWrapper : IGADCustomEventBannerDelegate {
		public IntPtr Handle { get; set; }
		
		public GADCustomEventBannerDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADCustomEventBannerDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADCustomEventBannerDelegateWrapper ()
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
	[Register("GADCustomEventBannerDelegate", true)]
	[Model]
	public unsafe partial class GADCustomEventBannerDelegate : NSObject, IGADCustomEventBannerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADCustomEventBannerDelegate () : base (NSObjectFlag.Empty)
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
		public GADCustomEventBannerDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADCustomEventBannerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADCustomEventBannerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("customEventBanner:didReceiveAd:")]
		[CompilerGenerated]
		public virtual void DidReceiveAd (GADCustomEventBanner customEvent, global::MonoTouch.UIKit.UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventBanner:didFailAd:")]
		[CompilerGenerated]
		public virtual void DidFailAd (GADCustomEventBanner customEvent, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventBanner:clickDidOccurInAd:")]
		[CompilerGenerated]
		public virtual void DidClickInAd (GADCustomEventBanner customEvent, global::MonoTouch.UIKit.UIView view)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventBannerWillPresentModal:")]
		[CompilerGenerated]
		public virtual void WillPresentModal (GADCustomEventBanner customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventBannerWillDismissModal:")]
		[CompilerGenerated]
		public virtual void WillDismissModal (GADCustomEventBanner customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventBannerDidDismissModal:")]
		[CompilerGenerated]
		public virtual void DidDismissModal (GADCustomEventBanner customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventBannerWillLeaveApplication:")]
		[CompilerGenerated]
		public virtual void WillLeaveApplication (GADCustomEventBanner customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController ViewControllerForPresentingModalView {
			[Export ("viewControllerForPresentingModalView")]
			get {
				throw new ModelNotImplementedException ();
			}
			
		}
		
	} /* class GADCustomEventBannerDelegate */
}
