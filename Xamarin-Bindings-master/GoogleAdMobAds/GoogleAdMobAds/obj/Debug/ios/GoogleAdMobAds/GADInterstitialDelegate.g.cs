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
	[Protocol (Name = "GADInterstitialDelegate", WrapperType = typeof (GADInterstitialDelegateWrapper))]
	public interface IGADInterstitialDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADInterstitialDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveAd (this IGADInterstitialDelegate This, GADInterstitial ad)
		{
			if (ad == null)
				throw new ArgumentNullException ("ad");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("interstitialDidReceiveAd:"), ad.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFailToReceiveAd (this IGADInterstitialDelegate This, GADInterstitial sender, GADRequestError error)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("interstitial:didFailToReceiveAdWithError:"), sender.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void WillPresentScreen (this IGADInterstitialDelegate This, GADInterstitial ad)
		{
			if (ad == null)
				throw new ArgumentNullException ("ad");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("interstitialWillPresentScreen:"), ad.Handle);
		}
		
		[CompilerGenerated]
		public static void WillDismissScreen (this IGADInterstitialDelegate This, GADInterstitial ad)
		{
			if (ad == null)
				throw new ArgumentNullException ("ad");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("interstitialWillDismissScreen:"), ad.Handle);
		}
		
		[CompilerGenerated]
		public static void DidDismissScreen (this IGADInterstitialDelegate This, GADInterstitial ad)
		{
			if (ad == null)
				throw new ArgumentNullException ("ad");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("interstitialDidDismissScreen:"), ad.Handle);
		}
		
		[CompilerGenerated]
		public static void WillLeaveApplication (this IGADInterstitialDelegate This, GADInterstitial ad)
		{
			if (ad == null)
				throw new ArgumentNullException ("ad");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("interstitialWillLeaveApplication:"), ad.Handle);
		}
		
	}
	
	internal sealed class GADInterstitialDelegateWrapper : IGADInterstitialDelegate {
		public IntPtr Handle { get; set; }
		
		public GADInterstitialDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADInterstitialDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADInterstitialDelegateWrapper ()
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
	[Register("GADInterstitialDelegate", true)]
	[Model]
	public unsafe partial class GADInterstitialDelegate : NSObject, IGADInterstitialDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADInterstitialDelegate () : base (NSObjectFlag.Empty)
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
		public GADInterstitialDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADInterstitialDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADInterstitialDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("interstitialDidReceiveAd:")]
		[CompilerGenerated]
		public virtual void DidReceiveAd (GADInterstitial ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("interstitial:didFailToReceiveAdWithError:")]
		[CompilerGenerated]
		public virtual void DidFailToReceiveAd (GADInterstitial sender, GADRequestError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("interstitialWillPresentScreen:")]
		[CompilerGenerated]
		public virtual void WillPresentScreen (GADInterstitial ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("interstitialWillDismissScreen:")]
		[CompilerGenerated]
		public virtual void WillDismissScreen (GADInterstitial ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("interstitialDidDismissScreen:")]
		[CompilerGenerated]
		public virtual void DidDismissScreen (GADInterstitial ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("interstitialWillLeaveApplication:")]
		[CompilerGenerated]
		public virtual void WillLeaveApplication (GADInterstitial ad)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GADInterstitialDelegate */
}
