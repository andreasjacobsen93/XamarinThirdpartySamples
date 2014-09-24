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
	[Protocol (Name = "GADCustomEventInterstitialDelegate", WrapperType = typeof (GADCustomEventInterstitialDelegateWrapper))]
	public interface IGADCustomEventInterstitialDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADCustomEventInterstitialDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveAd (this IGADCustomEventInterstitialDelegate This, GADCustomEventInterstitial customEvent, NSObject ad)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			if (ad == null)
				throw new ArgumentNullException ("ad");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitial:didReceiveAd:"), customEvent.Handle, ad.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFailAd (this IGADCustomEventInterstitialDelegate This, GADCustomEventInterstitial customEvent, NSError error)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitial:didFailAd:"), customEvent.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void WillPresent (this IGADCustomEventInterstitialDelegate This, GADCustomEventInterstitial customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWillPresent:"), customEvent.Handle);
		}
		
		[CompilerGenerated]
		public static void WillDismiss (this IGADCustomEventInterstitialDelegate This, GADCustomEventInterstitial customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWillDismiss:"), customEvent.Handle);
		}
		
		[CompilerGenerated]
		public static void DidDismiss (this IGADCustomEventInterstitialDelegate This, GADCustomEventInterstitial customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialDidDismiss:"), customEvent.Handle);
		}
		
		[CompilerGenerated]
		public static void WillLeaveApplication (this IGADCustomEventInterstitialDelegate This, GADCustomEventInterstitial customEvent)
		{
			if (customEvent == null)
				throw new ArgumentNullException ("customEvent");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customEventInterstitialWillLeaveApplication:"), customEvent.Handle);
		}
		
	}
	
	internal sealed class GADCustomEventInterstitialDelegateWrapper : IGADCustomEventInterstitialDelegate {
		public IntPtr Handle { get; set; }
		
		public GADCustomEventInterstitialDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADCustomEventInterstitialDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADCustomEventInterstitialDelegateWrapper ()
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
	[Register("GADCustomEventInterstitialDelegate", true)]
	[Model]
	public unsafe partial class GADCustomEventInterstitialDelegate : NSObject, IGADCustomEventInterstitialDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADCustomEventInterstitialDelegate () : base (NSObjectFlag.Empty)
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
		public GADCustomEventInterstitialDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADCustomEventInterstitialDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADCustomEventInterstitialDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("customEventInterstitial:didReceiveAd:")]
		[CompilerGenerated]
		public virtual void DidReceiveAd (GADCustomEventInterstitial customEvent, NSObject ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventInterstitial:didFailAd:")]
		[CompilerGenerated]
		public virtual void DidFailAd (GADCustomEventInterstitial customEvent, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventInterstitialWillPresent:")]
		[CompilerGenerated]
		public virtual void WillPresent (GADCustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventInterstitialWillDismiss:")]
		[CompilerGenerated]
		public virtual void WillDismiss (GADCustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventInterstitialDidDismiss:")]
		[CompilerGenerated]
		public virtual void DidDismiss (GADCustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("customEventInterstitialWillLeaveApplication:")]
		[CompilerGenerated]
		public virtual void WillLeaveApplication (GADCustomEventInterstitial customEvent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GADCustomEventInterstitialDelegate */
}
