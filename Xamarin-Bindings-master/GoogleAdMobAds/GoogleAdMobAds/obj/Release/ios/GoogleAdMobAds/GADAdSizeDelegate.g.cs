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
	[Protocol (Name = "GADAdSizeDelegate", WrapperType = typeof (GADAdSizeDelegateWrapper))]
	public interface IGADAdSizeDelegate : INativeObject, IDisposable
	{
	}
	
	public static class GADAdSizeDelegate_Extensions {
		[CompilerGenerated]
		public static void WillChangeAdSizeTo (this IGADAdSizeDelegate This, GADBannerView view, GADAdSize size)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_GADAdSize (This.Handle, Selector.GetHandle ("adView:willChangeAdSizeTo:"), view.Handle, size);
		}
		
	}
	
	internal sealed class GADAdSizeDelegateWrapper : IGADAdSizeDelegate {
		public IntPtr Handle { get; set; }
		
		public GADAdSizeDelegateWrapper (IntPtr handle)
			: this (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public GADAdSizeDelegateWrapper (IntPtr handle, bool owns)
		{
			Handle = handle;
			if (!owns)
			    Messaging.void_objc_msgSend (Handle, Selector.GetHandle ("retain"));
		}
		
		~GADAdSizeDelegateWrapper ()
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
	[Register("GADAdSizeDelegate", true)]
	[Model]
	public unsafe partial class GADAdSizeDelegate : NSObject, IGADAdSizeDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADAdSizeDelegate () : base (NSObjectFlag.Empty)
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
		public GADAdSizeDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADAdSizeDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADAdSizeDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adView:willChangeAdSizeTo:")]
		[CompilerGenerated]
		public virtual void WillChangeAdSizeTo (GADBannerView view, GADAdSize size)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GADAdSizeDelegate */
}
