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
	[Protocol (Name = "GADAppEventDelegate", WrapperType = typeof (GADAppEventDelegateWrapper))]
	public interface IGADAppEventDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADAppEventDelegate_Extensions {
		[CompilerGenerated]
		public static void AdViewDidReceiveAppEvent (this IGADAppEventDelegate This, GADBannerView banner, string name, string info)
		{
			if (banner == null)
				throw new ArgumentNullException ("banner");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (info == null)
				throw new ArgumentNullException ("info");
			var nsname = NSString.CreateNative (name);
			var nsinfo = NSString.CreateNative (info);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("adView:didReceiveAppEvent:withInfo:"), banner.Handle, nsname, nsinfo);
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsinfo);
			
		}
		
		[CompilerGenerated]
		public static void InterstitialDidReceiveAppEvent (this IGADAppEventDelegate This, GADInterstitial interstitial, string name, string info)
		{
			if (interstitial == null)
				throw new ArgumentNullException ("interstitial");
			if (name == null)
				throw new ArgumentNullException ("name");
			if (info == null)
				throw new ArgumentNullException ("info");
			var nsname = NSString.CreateNative (name);
			var nsinfo = NSString.CreateNative (info);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("interstitial:didReceiveAppEvent:withInfo:"), interstitial.Handle, nsname, nsinfo);
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsinfo);
			
		}
		
	}
	
	internal sealed class GADAppEventDelegateWrapper : IGADAppEventDelegate {
		public IntPtr Handle { get; set; }
		
		public GADAppEventDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADAppEventDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADAppEventDelegateWrapper ()
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
	[Register("GADAppEventDelegate", true)]
	[Model]
	public unsafe partial class GADAppEventDelegate : NSObject, IGADAppEventDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADAppEventDelegate () : base (NSObjectFlag.Empty)
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
		public GADAppEventDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADAppEventDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADAppEventDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adView:didReceiveAppEvent:withInfo:")]
		[CompilerGenerated]
		public virtual void AdViewDidReceiveAppEvent (GADBannerView banner, string name, string info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("interstitial:didReceiveAppEvent:withInfo:")]
		[CompilerGenerated]
		public virtual void InterstitialDidReceiveAppEvent (GADInterstitial interstitial, string name, string info)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GADAppEventDelegate */
}
