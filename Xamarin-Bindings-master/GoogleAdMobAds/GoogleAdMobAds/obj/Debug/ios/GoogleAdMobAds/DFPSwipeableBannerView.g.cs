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
	[Register("DFPSwipeableBannerView", true)]
	public unsafe partial class DFPSwipeableBannerView : DFPBannerView {
		[CompilerGenerated]
		const string selSwipeDelegate = "swipeDelegate";
		static readonly IntPtr selSwipeDelegateHandle = Selector.GetHandle ("swipeDelegate");
		[CompilerGenerated]
		const string selSetSwipeDelegate_ = "setSwipeDelegate:";
		static readonly IntPtr selSetSwipeDelegate_Handle = Selector.GetHandle ("setSwipeDelegate:");
		[CompilerGenerated]
		const string selInitWithAdSizeOrigin_ = "initWithAdSize:origin:";
		static readonly IntPtr selInitWithAdSizeOrigin_Handle = Selector.GetHandle ("initWithAdSize:origin:");
		[CompilerGenerated]
		const string selInitWithAdSize_ = "initWithAdSize:";
		static readonly IntPtr selInitWithAdSize_Handle = Selector.GetHandle ("initWithAdSize:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("DFPSwipeableBannerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public DFPSwipeableBannerView () : base (NSObjectFlag.Empty)
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
		public DFPSwipeableBannerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public DFPSwipeableBannerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DFPSwipeableBannerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAdSize:origin:")]
		[CompilerGenerated]
		public DFPSwipeableBannerView (GADAdSize size, global::System.Drawing.PointF origin)
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
		public DFPSwipeableBannerView (GADAdSize size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_GADAdSize (this.Handle, selInitWithAdSize_Handle, size);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_GADAdSize (this.SuperHandle, selInitWithAdSize_Handle, size);
			}
		}
		
		[CompilerGenerated]
		public GADSwipeableBannerViewDelegate SwipeDelegate {
			get {
				return WeakSwipeDelegate as GADSwipeableBannerViewDelegate;
			}
			set {
				WeakSwipeDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakSwipeDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakSwipeDelegate {
			[Export ("swipeDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSwipeDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSwipeDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakSwipeDelegate_var = ret;
				return ret;
			}
			
			[Export ("setSwipeDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSwipeDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSwipeDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakSwipeDelegate_var = value;
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_GADSwipeableBannerViewDelegate EnsureGADSwipeableBannerViewDelegate ()
		{
			var del = WeakSwipeDelegate;
			if (del == null || (!(del is _GADSwipeableBannerViewDelegate))){
				del = new _GADSwipeableBannerViewDelegate ();
				WeakSwipeDelegate = del;
			}
			return (_GADSwipeableBannerViewDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADSwipeableBannerViewDelegate : GoogleAdMobAds.GADSwipeableBannerViewDelegate { 
			public _GADSwipeableBannerViewDelegate () { IsDirectBinding = false; }
			
			internal EventHandler didActivateAd;
			[Preserve (Conditional = true)]
			public override void DidActivateAd (GoogleAdMobAds.GADBannerView banner)
			{
				EventHandler handler = didActivateAd;
				if (handler != null){
					handler (banner, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDeactivateAd;
			[Preserve (Conditional = true)]
			public override void DidDeactivateAd (GoogleAdMobAds.GADBannerView banner)
			{
				EventHandler handler = didDeactivateAd;
				if (handler != null){
					handler (banner, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidActivateAd {
			add { EnsureGADSwipeableBannerViewDelegate ().didActivateAd += value; }
			remove { EnsureGADSwipeableBannerViewDelegate ().didActivateAd -= value; }
		}
		
		public event EventHandler DidDeactivateAd {
			add { EnsureGADSwipeableBannerViewDelegate ().didDeactivateAd += value; }
			remove { EnsureGADSwipeableBannerViewDelegate ().didDeactivateAd -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakSwipeDelegate_var = null;
			}
		}
	} /* class DFPSwipeableBannerView */
}
