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
	[Protocol (Name = "GADSwipeableBannerViewDelegate", WrapperType = typeof (GADSwipeableBannerViewDelegateWrapper))]
	public interface IGADSwipeableBannerViewDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADSwipeableBannerViewDelegate_Extensions {
		[CompilerGenerated]
		public static void DidActivateAd (this IGADSwipeableBannerViewDelegate This, GADBannerView banner)
		{
			if (banner == null)
				throw new ArgumentNullException ("banner");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewDidActivateAd:"), banner.Handle);
		}
		
		[CompilerGenerated]
		public static void DidDeactivateAd (this IGADSwipeableBannerViewDelegate This, GADBannerView banner)
		{
			if (banner == null)
				throw new ArgumentNullException ("banner");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("adViewDidDeactivateAd:"), banner.Handle);
		}
		
	}
	
	internal sealed class GADSwipeableBannerViewDelegateWrapper : IGADSwipeableBannerViewDelegate {
		public IntPtr Handle { get; set; }
		
		public GADSwipeableBannerViewDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADSwipeableBannerViewDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADSwipeableBannerViewDelegateWrapper ()
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
	[Register("GADSwipeableBannerViewDelegate", true)]
	[Model]
	public unsafe partial class GADSwipeableBannerViewDelegate : NSObject, IGADSwipeableBannerViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADSwipeableBannerViewDelegate () : base (NSObjectFlag.Empty)
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
		public GADSwipeableBannerViewDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADSwipeableBannerViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADSwipeableBannerViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adViewDidActivateAd:")]
		[CompilerGenerated]
		public virtual void DidActivateAd (GADBannerView banner)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewDidDeactivateAd:")]
		[CompilerGenerated]
		public virtual void DidDeactivateAd (GADBannerView banner)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GADSwipeableBannerViewDelegate */
}
