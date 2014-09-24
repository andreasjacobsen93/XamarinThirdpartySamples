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
	[Register("GADBannerView", true)]
	public unsafe partial class GADBannerView : global::MonoTouch.UIKit.UIView {
		[CompilerGenerated]
		const string selAdUnitID = "adUnitID";
		static readonly IntPtr selAdUnitIDHandle = Selector.GetHandle ("adUnitID");
		[CompilerGenerated]
		const string selSetAdUnitID_ = "setAdUnitID:";
		static readonly IntPtr selSetAdUnitID_Handle = Selector.GetHandle ("setAdUnitID:");
		[CompilerGenerated]
		const string selRootViewController = "rootViewController";
		static readonly IntPtr selRootViewControllerHandle = Selector.GetHandle ("rootViewController");
		[CompilerGenerated]
		const string selSetRootViewController_ = "setRootViewController:";
		static readonly IntPtr selSetRootViewController_Handle = Selector.GetHandle ("setRootViewController:");
		[CompilerGenerated]
		const string selAdSize = "adSize";
		static readonly IntPtr selAdSizeHandle = Selector.GetHandle ("adSize");
		[CompilerGenerated]
		const string selSetAdSize_ = "setAdSize:";
		static readonly IntPtr selSetAdSize_Handle = Selector.GetHandle ("setAdSize:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selHasAutoRefreshed = "hasAutoRefreshed";
		static readonly IntPtr selHasAutoRefreshedHandle = Selector.GetHandle ("hasAutoRefreshed");
		[CompilerGenerated]
		const string selMediatedAdView = "mediatedAdView";
		static readonly IntPtr selMediatedAdViewHandle = Selector.GetHandle ("mediatedAdView");
		[CompilerGenerated]
		const string selInitWithAdSizeOrigin_ = "initWithAdSize:origin:";
		static readonly IntPtr selInitWithAdSizeOrigin_Handle = Selector.GetHandle ("initWithAdSize:origin:");
		[CompilerGenerated]
		const string selInitWithAdSize_ = "initWithAdSize:";
		static readonly IntPtr selInitWithAdSize_Handle = Selector.GetHandle ("initWithAdSize:");
		[CompilerGenerated]
		const string selLoadRequest_ = "loadRequest:";
		static readonly IntPtr selLoadRequest_Handle = Selector.GetHandle ("loadRequest:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADBannerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADBannerView () : base (NSObjectFlag.Empty)
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
		public GADBannerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADBannerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADBannerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAdSize:origin:")]
		[CompilerGenerated]
		public GADBannerView (GADAdSize size, global::System.Drawing.PointF origin)
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
		public GADBannerView (GADAdSize size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_GADAdSize (this.Handle, selInitWithAdSize_Handle, size);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_GADAdSize (this.SuperHandle, selInitWithAdSize_Handle, size);
			}
		}
		
		[Export ("loadRequest:")]
		[CompilerGenerated]
		public virtual void LoadRequest (GADRequest request)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadRequest_Handle, request == null ? IntPtr.Zero : request.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadRequest_Handle, request == null ? IntPtr.Zero : request.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string AdUnitID {
			[Export ("adUnitID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdUnitIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdUnitIDHandle));
				}
			}
			
			[Export ("setAdUnitID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdUnitID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAdUnitID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_RootViewController_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIViewController RootViewController {
			[Export ("rootViewController", ArgumentSemantic.Assign)]
			get {
				global::MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRootViewControllerHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIViewController> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRootViewControllerHandle));
				}
				MarkDirty ();
				__mt_RootViewController_var = ret;
				return ret;
			}
			
			[Export ("setRootViewController:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRootViewController_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRootViewController_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_RootViewController_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual GADAdSize AdSize {
			[Export ("adSize")]
			get {
				GADAdSize ret;
				if (IsDirectBinding) {
					ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, this.Handle, selAdSizeHandle);
				} else {
					ApiDefinition.Messaging.GADAdSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, selAdSizeHandle);
				}
				return ret;
			}
			
			[Export ("setAdSize:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_GADAdSize (this.Handle, selSetAdSize_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_GADAdSize (this.SuperHandle, selSetAdSize_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public GADBannerViewDelegate Delegate {
			get {
				return WeakDelegate as GADBannerViewDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasAutoRefreshed {
			[Export ("hasAutoRefreshed")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAutoRefreshedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasAutoRefreshedHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_MediatedAdView_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIView MediatedAdView {
			[Export ("mediatedAdView")]
			get {
				global::MonoTouch.UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMediatedAdViewHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIView> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMediatedAdViewHandle));
				}
				MarkDirty ();
				__mt_MediatedAdView_var = ret;
				return ret;
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_GADBannerViewDelegate EnsureGADBannerViewDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _GADBannerViewDelegate))){
				del = new _GADBannerViewDelegate ();
				WeakDelegate = del;
			}
			return (_GADBannerViewDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADBannerViewDelegate : GoogleAdMobAds.GADBannerViewDelegate { 
			public _GADBannerViewDelegate () { IsDirectBinding = false; }
			
			internal EventHandler didReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidReceiveAd (GoogleAdMobAds.GADBannerView view)
			{
				EventHandler handler = didReceiveAd;
				if (handler != null){
					handler (view, EventArgs.Empty);
				}
			}
			
			internal EventHandler<GADBannerViewErrorEventArgs> didFailToReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidFailToReceiveAd (GoogleAdMobAds.GADBannerView view, GoogleAdMobAds.GADRequestError error)
			{
				EventHandler<GADBannerViewErrorEventArgs> handler = didFailToReceiveAd;
				if (handler != null){
					var args = new GADBannerViewErrorEventArgs (error);
					handler (view, args);
				}
			}
			
			internal EventHandler willPresentScreen;
			[Preserve (Conditional = true)]
			public override void WillPresentScreen (GoogleAdMobAds.GADBannerView adView)
			{
				EventHandler handler = willPresentScreen;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
			
			internal EventHandler willDismissScreen;
			[Preserve (Conditional = true)]
			public override void WillDismissScreen (GoogleAdMobAds.GADBannerView adView)
			{
				EventHandler handler = willDismissScreen;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDismissScreen;
			[Preserve (Conditional = true)]
			public override void DidDismissScreen (GoogleAdMobAds.GADBannerView adView)
			{
				EventHandler handler = didDismissScreen;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
			
			internal EventHandler willLeaveApplication;
			[Preserve (Conditional = true)]
			public override void WillLeaveApplication (GoogleAdMobAds.GADBannerView adView)
			{
				EventHandler handler = willLeaveApplication;
				if (handler != null){
					handler (adView, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidReceiveAd {
			add { EnsureGADBannerViewDelegate ().didReceiveAd += value; }
			remove { EnsureGADBannerViewDelegate ().didReceiveAd -= value; }
		}
		
		public event EventHandler<GADBannerViewErrorEventArgs> DidFailToReceiveAd {
			add { EnsureGADBannerViewDelegate ().didFailToReceiveAd += value; }
			remove { EnsureGADBannerViewDelegate ().didFailToReceiveAd -= value; }
		}
		
		public event EventHandler WillPresentScreen {
			add { EnsureGADBannerViewDelegate ().willPresentScreen += value; }
			remove { EnsureGADBannerViewDelegate ().willPresentScreen -= value; }
		}
		
		public event EventHandler WillDismissScreen {
			add { EnsureGADBannerViewDelegate ().willDismissScreen += value; }
			remove { EnsureGADBannerViewDelegate ().willDismissScreen -= value; }
		}
		
		public event EventHandler DidDismissScreen {
			add { EnsureGADBannerViewDelegate ().didDismissScreen += value; }
			remove { EnsureGADBannerViewDelegate ().didDismissScreen -= value; }
		}
		
		public event EventHandler WillLeaveApplication {
			add { EnsureGADBannerViewDelegate ().willLeaveApplication += value; }
			remove { EnsureGADBannerViewDelegate ().willLeaveApplication -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RootViewController_var = null;
				__mt_WeakDelegate_var = null;
				__mt_MediatedAdView_var = null;
			}
		}
	} /* class GADBannerView */
	
	
	//
	// EventArgs classes
	//
	public partial class GADBannerViewErrorEventArgs : EventArgs {
		public GADBannerViewErrorEventArgs (GoogleAdMobAds.GADRequestError error)
		{
			this.Error = error;
		}
		public GoogleAdMobAds.GADRequestError Error { get; set; }
	}
	
}
