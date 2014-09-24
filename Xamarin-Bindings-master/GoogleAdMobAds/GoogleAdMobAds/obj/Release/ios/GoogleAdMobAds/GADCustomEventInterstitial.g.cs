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
	[Register("GADCustomEventInterstitial", true)]
	public unsafe partial class GADCustomEventInterstitial : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selRequestInterstitialAdWithParameterLabelRequest_ = "requestInterstitialAdWithParameter:label:request:";
		static readonly IntPtr selRequestInterstitialAdWithParameterLabelRequest_Handle = Selector.GetHandle ("requestInterstitialAdWithParameter:label:request:");
		[CompilerGenerated]
		const string selPresentFromRootViewController_ = "presentFromRootViewController:";
		static readonly IntPtr selPresentFromRootViewController_Handle = Selector.GetHandle ("presentFromRootViewController:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADCustomEventInterstitial");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADCustomEventInterstitial () : base (NSObjectFlag.Empty)
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
		public GADCustomEventInterstitial (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADCustomEventInterstitial (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADCustomEventInterstitial (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("requestInterstitialAdWithParameter:label:request:")]
		[CompilerGenerated]
		public virtual void RequestInterstitialAd (string serverParameter, string serverLabel, GADCustomEventRequest request)
		{
			if (serverParameter == null)
				throw new ArgumentNullException ("serverParameter");
			if (serverLabel == null)
				throw new ArgumentNullException ("serverLabel");
			if (request == null)
				throw new ArgumentNullException ("request");
			var nsserverParameter = NSString.CreateNative (serverParameter);
			var nsserverLabel = NSString.CreateNative (serverLabel);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selRequestInterstitialAdWithParameterLabelRequest_Handle, nsserverParameter, nsserverLabel, request.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selRequestInterstitialAdWithParameterLabelRequest_Handle, nsserverParameter, nsserverLabel, request.Handle);
			}
			NSString.ReleaseNative (nsserverParameter);
			NSString.ReleaseNative (nsserverLabel);
			
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
		public GADCustomEventInterstitialDelegate Delegate {
			get {
				return WeakDelegate as GADCustomEventInterstitialDelegate;
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
		
		//
		// Events and properties from the delegate
		//
		
		_GADCustomEventInterstitialDelegate EnsureGADCustomEventInterstitialDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _GADCustomEventInterstitialDelegate))){
				del = new _GADCustomEventInterstitialDelegate ();
				WeakDelegate = del;
			}
			return (_GADCustomEventInterstitialDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADCustomEventInterstitialDelegate : GoogleAdMobAds.GADCustomEventInterstitialDelegate { 
			public _GADCustomEventInterstitialDelegate () { IsDirectBinding = false; }
			
			internal EventHandler<GADCustomEventInterstitialAdEventArgs> didReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidReceiveAd (GoogleAdMobAds.GADCustomEventInterstitial customEvent, NSObject ad)
			{
				EventHandler<GADCustomEventInterstitialAdEventArgs> handler = didReceiveAd;
				if (handler != null){
					var args = new GADCustomEventInterstitialAdEventArgs (ad);
					handler (customEvent, args);
				}
			}
			
			internal EventHandler<GADCustomEventInterstitialErrorEventArgs> didFailAd;
			[Preserve (Conditional = true)]
			public override void DidFailAd (GoogleAdMobAds.GADCustomEventInterstitial customEvent, NSError error)
			{
				EventHandler<GADCustomEventInterstitialErrorEventArgs> handler = didFailAd;
				if (handler != null){
					var args = new GADCustomEventInterstitialErrorEventArgs (error);
					handler (customEvent, args);
				}
			}
			
			internal EventHandler willPresent;
			[Preserve (Conditional = true)]
			public override void WillPresent (GoogleAdMobAds.GADCustomEventInterstitial customEvent)
			{
				EventHandler handler = willPresent;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
			internal EventHandler willDismiss;
			[Preserve (Conditional = true)]
			public override void WillDismiss (GoogleAdMobAds.GADCustomEventInterstitial customEvent)
			{
				EventHandler handler = willDismiss;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDismiss;
			[Preserve (Conditional = true)]
			public override void DidDismiss (GoogleAdMobAds.GADCustomEventInterstitial customEvent)
			{
				EventHandler handler = didDismiss;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
			internal EventHandler willLeaveApplication;
			[Preserve (Conditional = true)]
			public override void WillLeaveApplication (GoogleAdMobAds.GADCustomEventInterstitial customEvent)
			{
				EventHandler handler = willLeaveApplication;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<GADCustomEventInterstitialAdEventArgs> DidReceiveAd {
			add { EnsureGADCustomEventInterstitialDelegate ().didReceiveAd += value; }
			remove { EnsureGADCustomEventInterstitialDelegate ().didReceiveAd -= value; }
		}
		
		public event EventHandler<GADCustomEventInterstitialErrorEventArgs> DidFailAd {
			add { EnsureGADCustomEventInterstitialDelegate ().didFailAd += value; }
			remove { EnsureGADCustomEventInterstitialDelegate ().didFailAd -= value; }
		}
		
		public event EventHandler WillPresent {
			add { EnsureGADCustomEventInterstitialDelegate ().willPresent += value; }
			remove { EnsureGADCustomEventInterstitialDelegate ().willPresent -= value; }
		}
		
		public event EventHandler WillDismiss {
			add { EnsureGADCustomEventInterstitialDelegate ().willDismiss += value; }
			remove { EnsureGADCustomEventInterstitialDelegate ().willDismiss -= value; }
		}
		
		public event EventHandler DidDismiss {
			add { EnsureGADCustomEventInterstitialDelegate ().didDismiss += value; }
			remove { EnsureGADCustomEventInterstitialDelegate ().didDismiss -= value; }
		}
		
		public event EventHandler WillLeaveApplication {
			add { EnsureGADCustomEventInterstitialDelegate ().willLeaveApplication += value; }
			remove { EnsureGADCustomEventInterstitialDelegate ().willLeaveApplication -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class GADCustomEventInterstitial */
	
	
	//
	// EventArgs classes
	//
	public partial class GADCustomEventInterstitialAdEventArgs : EventArgs {
		public GADCustomEventInterstitialAdEventArgs (NSObject ad)
		{
			this.Ad = ad;
		}
		public NSObject Ad { get; set; }
	}
	
	public partial class GADCustomEventInterstitialErrorEventArgs : EventArgs {
		public GADCustomEventInterstitialErrorEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}
	
}
