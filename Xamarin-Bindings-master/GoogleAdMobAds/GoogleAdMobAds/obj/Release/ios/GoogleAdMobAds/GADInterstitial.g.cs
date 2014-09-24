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
	[Register("GADInterstitial", true)]
	public unsafe partial class GADInterstitial : NSObject {
		[CompilerGenerated]
		const string selAdUnitID = "adUnitID";
		static readonly IntPtr selAdUnitIDHandle = Selector.GetHandle ("adUnitID");
		[CompilerGenerated]
		const string selSetAdUnitID_ = "setAdUnitID:";
		static readonly IntPtr selSetAdUnitID_Handle = Selector.GetHandle ("setAdUnitID:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selIsReady = "isReady";
		static readonly IntPtr selIsReadyHandle = Selector.GetHandle ("isReady");
		[CompilerGenerated]
		const string selHasBeenUsed = "hasBeenUsed";
		static readonly IntPtr selHasBeenUsedHandle = Selector.GetHandle ("hasBeenUsed");
		[CompilerGenerated]
		const string selLoadRequest_ = "loadRequest:";
		static readonly IntPtr selLoadRequest_Handle = Selector.GetHandle ("loadRequest:");
		[CompilerGenerated]
		const string selLoadAndDisplayRequestUsingWindowInitialImage_ = "loadAndDisplayRequest:usingWindow:initialImage:";
		static readonly IntPtr selLoadAndDisplayRequestUsingWindowInitialImage_Handle = Selector.GetHandle ("loadAndDisplayRequest:usingWindow:initialImage:");
		[CompilerGenerated]
		const string selPresentFromRootViewController_ = "presentFromRootViewController:";
		static readonly IntPtr selPresentFromRootViewController_Handle = Selector.GetHandle ("presentFromRootViewController:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADInterstitial");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADInterstitial () : base (NSObjectFlag.Empty)
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
		public GADInterstitial (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADInterstitial (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADInterstitial (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("loadRequest:")]
		[CompilerGenerated]
		public virtual void LoadRequest (GADRequest request)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadRequest_Handle, request.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadRequest_Handle, request.Handle);
			}
		}
		
		[Export ("loadAndDisplayRequest:usingWindow:initialImage:")]
		[CompilerGenerated]
		public virtual void LoadAndDisplayRequest (GADRequest request, global::MonoTouch.UIKit.UIWindow window, global::MonoTouch.UIKit.UIImage image)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (window == null)
				throw new ArgumentNullException ("window");
			if (image == null)
				throw new ArgumentNullException ("image");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selLoadAndDisplayRequestUsingWindowInitialImage_Handle, request.Handle, window.Handle, image.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selLoadAndDisplayRequestUsingWindowInitialImage_Handle, request.Handle, window.Handle, image.Handle);
			}
		}
		
		[Export ("presentFromRootViewController:")]
		[CompilerGenerated]
		public virtual void PresentFromRootViewController (global::MonoTouch.UIKit.UIViewController rootViewController)
		{
			if (rootViewController == null)
				throw new ArgumentNullException ("rootViewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPresentFromRootViewController_Handle, rootViewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selPresentFromRootViewController_Handle, rootViewController.Handle);
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
		public GADInterstitialDelegate Delegate {
			get {
				return WeakDelegate as GADInterstitialDelegate;
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
		public virtual bool IsReady {
			[Export ("isReady")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsReadyHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsReadyHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasBeenUsed {
			[Export ("hasBeenUsed")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasBeenUsedHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasBeenUsedHandle);
				}
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_GADInterstitialDelegate EnsureGADInterstitialDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _GADInterstitialDelegate))){
				del = new _GADInterstitialDelegate ();
				WeakDelegate = del;
			}
			return (_GADInterstitialDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADInterstitialDelegate : GoogleAdMobAds.GADInterstitialDelegate { 
			public _GADInterstitialDelegate () { IsDirectBinding = false; }
			
			internal EventHandler didReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidReceiveAd (GoogleAdMobAds.GADInterstitial ad)
			{
				EventHandler handler = didReceiveAd;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			
			internal EventHandler<GADInterstitialDidFailToReceiveAdWithErrorEventArgs> didFailToReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidFailToReceiveAd (GoogleAdMobAds.GADInterstitial sender, GoogleAdMobAds.GADRequestError error)
			{
				EventHandler<GADInterstitialDidFailToReceiveAdWithErrorEventArgs> handler = didFailToReceiveAd;
				if (handler != null){
					var args = new GADInterstitialDidFailToReceiveAdWithErrorEventArgs (error);
					handler (sender, args);
				}
			}
			
			internal EventHandler willPresentScreen;
			[Preserve (Conditional = true)]
			public override void WillPresentScreen (GoogleAdMobAds.GADInterstitial ad)
			{
				EventHandler handler = willPresentScreen;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			
			internal EventHandler willDismissScreen;
			[Preserve (Conditional = true)]
			public override void WillDismissScreen (GoogleAdMobAds.GADInterstitial ad)
			{
				EventHandler handler = willDismissScreen;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDismissScreen;
			[Preserve (Conditional = true)]
			public override void DidDismissScreen (GoogleAdMobAds.GADInterstitial ad)
			{
				EventHandler handler = didDismissScreen;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			
			internal EventHandler willLeaveApplication;
			[Preserve (Conditional = true)]
			public override void WillLeaveApplication (GoogleAdMobAds.GADInterstitial ad)
			{
				EventHandler handler = willLeaveApplication;
				if (handler != null){
					handler (ad, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler DidReceiveAd {
			add { EnsureGADInterstitialDelegate ().didReceiveAd += value; }
			remove { EnsureGADInterstitialDelegate ().didReceiveAd -= value; }
		}
		
		public event EventHandler<GADInterstitialDidFailToReceiveAdWithErrorEventArgs> DidFailToReceiveAd {
			add { EnsureGADInterstitialDelegate ().didFailToReceiveAd += value; }
			remove { EnsureGADInterstitialDelegate ().didFailToReceiveAd -= value; }
		}
		
		public event EventHandler WillPresentScreen {
			add { EnsureGADInterstitialDelegate ().willPresentScreen += value; }
			remove { EnsureGADInterstitialDelegate ().willPresentScreen -= value; }
		}
		
		public event EventHandler WillDismissScreen {
			add { EnsureGADInterstitialDelegate ().willDismissScreen += value; }
			remove { EnsureGADInterstitialDelegate ().willDismissScreen -= value; }
		}
		
		public event EventHandler DidDismissScreen {
			add { EnsureGADInterstitialDelegate ().didDismissScreen += value; }
			remove { EnsureGADInterstitialDelegate ().didDismissScreen -= value; }
		}
		
		public event EventHandler WillLeaveApplication {
			add { EnsureGADInterstitialDelegate ().willLeaveApplication += value; }
			remove { EnsureGADInterstitialDelegate ().willLeaveApplication -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class GADInterstitial */
	
	
	//
	// EventArgs classes
	//
	public partial class GADInterstitialDidFailToReceiveAdWithErrorEventArgs : EventArgs {
		public GADInterstitialDidFailToReceiveAdWithErrorEventArgs (GoogleAdMobAds.GADRequestError error)
		{
			this.Error = error;
		}
		public GoogleAdMobAds.GADRequestError Error { get; set; }
	}
	
}
