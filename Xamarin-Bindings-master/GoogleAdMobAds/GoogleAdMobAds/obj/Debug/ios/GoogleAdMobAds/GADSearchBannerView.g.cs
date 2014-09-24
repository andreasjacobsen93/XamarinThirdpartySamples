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
	[Register("GADSearchBannerView", true)]
	public unsafe partial class GADSearchBannerView : GADBannerView {
		[CompilerGenerated]
		const string selInitWithAdSizeOrigin_ = "initWithAdSize:origin:";
		static readonly IntPtr selInitWithAdSizeOrigin_Handle = Selector.GetHandle ("initWithAdSize:origin:");
		[CompilerGenerated]
		const string selInitWithAdSize_ = "initWithAdSize:";
		static readonly IntPtr selInitWithAdSize_Handle = Selector.GetHandle ("initWithAdSize:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADSearchBannerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADSearchBannerView () : base (NSObjectFlag.Empty)
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
		public GADSearchBannerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADSearchBannerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADSearchBannerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAdSize:origin:")]
		[CompilerGenerated]
		public GADSearchBannerView (GADAdSize size, global::System.Drawing.PointF origin)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_GADAdSize_PointF (this.Handle, selInitWithAdSizeOrigin_Handle, size, origin);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_GADAdSize_PointF (this.SuperHandle, selInitWithAdSizeOrigin_Handle, size, origin);
			}
		}
		
		[Export ("initWithAdSize:")]
		[CompilerGenerated]
		public GADSearchBannerView (GADAdSize size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_GADAdSize (this.Handle, selInitWithAdSize_Handle, size);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_GADAdSize (this.SuperHandle, selInitWithAdSize_Handle, size);
			}
		}
		
	} /* class GADSearchBannerView */
}
