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
	[Register("GADCustomEventBanner", true)]
	public unsafe partial class GADCustomEventBanner : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selRequestBannerAdParameterLabelRequest_ = "requestBannerAd:parameter:label:request:";
		static readonly IntPtr selRequestBannerAdParameterLabelRequest_Handle = Selector.GetHandle ("requestBannerAd:parameter:label:request:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADCustomEventBanner");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADCustomEventBanner () : base (NSObjectFlag.Empty)
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
		public GADCustomEventBanner (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADCustomEventBanner (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADCustomEventBanner (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("requestBannerAd:parameter:label:request:")]
		[CompilerGenerated]
		public virtual void RequestBannerAd (GADAdSize adSize, string serverParameter, string serverLabel, GADCustomEventRequest request)
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
				ApiDefinition.Messaging.void_objc_msgSend_GADAdSize_IntPtr_IntPtr_IntPtr (this.Handle, selRequestBannerAdParameterLabelRequest_Handle, adSize, nsserverParameter, nsserverLabel, request.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_GADAdSize_IntPtr_IntPtr_IntPtr (this.SuperHandle, selRequestBannerAdParameterLabelRequest_Handle, adSize, nsserverParameter, nsserverLabel, request.Handle);
			}
			NSString.ReleaseNative (nsserverParameter);
			NSString.ReleaseNative (nsserverLabel);
			
		}
		
		[CompilerGenerated]
		public GADCustomEventBannerDelegate Delegate {
			get {
				return WeakDelegate as GADCustomEventBannerDelegate;
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
		
		_GADCustomEventBannerDelegate EnsureGADCustomEventBannerDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _GADCustomEventBannerDelegate))){
				del = new _GADCustomEventBannerDelegate ();
				WeakDelegate = del;
			}
			return (_GADCustomEventBannerDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADCustomEventBannerDelegate : GoogleAdMobAds.GADCustomEventBannerDelegate { 
			public _GADCustomEventBannerDelegate () { IsDirectBinding = false; }
			
			internal EventHandler<GADCustomEventBannerViewEventArgs> didReceiveAd;
			[Preserve (Conditional = true)]
			public override void DidReceiveAd (GoogleAdMobAds.GADCustomEventBanner customEvent, UIView view)
			{
				EventHandler<GADCustomEventBannerViewEventArgs> handler = didReceiveAd;
				if (handler != null){
					var args = new GADCustomEventBannerViewEventArgs (view);
					handler (customEvent, args);
				}
			}
			
			internal EventHandler<GADCustomEventBannerDidReceiveAdEventArgs> didFailAd;
			[Preserve (Conditional = true)]
			public override void DidFailAd (GoogleAdMobAds.GADCustomEventBanner customEvent, NSError error)
			{
				EventHandler<GADCustomEventBannerDidReceiveAdEventArgs> handler = didFailAd;
				if (handler != null){
					var args = new GADCustomEventBannerDidReceiveAdEventArgs (error);
					handler (customEvent, args);
				}
			}
			
			internal EventHandler<GADCustomEventBannerViewEventArgs> didClickInAd;
			[Preserve (Conditional = true)]
			public override void DidClickInAd (GoogleAdMobAds.GADCustomEventBanner customEvent, UIView view)
			{
				EventHandler<GADCustomEventBannerViewEventArgs> handler = didClickInAd;
				if (handler != null){
					var args = new GADCustomEventBannerViewEventArgs (view);
					handler (customEvent, args);
				}
			}
			
			internal EventHandler willPresentModal;
			[Preserve (Conditional = true)]
			public override void WillPresentModal (GoogleAdMobAds.GADCustomEventBanner customEvent)
			{
				EventHandler handler = willPresentModal;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
			internal EventHandler willDismissModal;
			[Preserve (Conditional = true)]
			public override void WillDismissModal (GoogleAdMobAds.GADCustomEventBanner customEvent)
			{
				EventHandler handler = willDismissModal;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDismissModal;
			[Preserve (Conditional = true)]
			public override void DidDismissModal (GoogleAdMobAds.GADCustomEventBanner customEvent)
			{
				EventHandler handler = didDismissModal;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
			internal EventHandler willLeaveApplication;
			[Preserve (Conditional = true)]
			public override void WillLeaveApplication (GoogleAdMobAds.GADCustomEventBanner customEvent)
			{
				EventHandler handler = willLeaveApplication;
				if (handler != null){
					handler (customEvent, EventArgs.Empty);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<GADCustomEventBannerViewEventArgs> DidReceiveAd {
			add { EnsureGADCustomEventBannerDelegate ().didReceiveAd += value; }
			remove { EnsureGADCustomEventBannerDelegate ().didReceiveAd -= value; }
		}
		
		public event EventHandler<GADCustomEventBannerDidReceiveAdEventArgs> DidFailAd {
			add { EnsureGADCustomEventBannerDelegate ().didFailAd += value; }
			remove { EnsureGADCustomEventBannerDelegate ().didFailAd -= value; }
		}
		
		public event EventHandler<GADCustomEventBannerViewEventArgs> DidClickInAd {
			add { EnsureGADCustomEventBannerDelegate ().didClickInAd += value; }
			remove { EnsureGADCustomEventBannerDelegate ().didClickInAd -= value; }
		}
		
		public event EventHandler WillPresentModal {
			add { EnsureGADCustomEventBannerDelegate ().willPresentModal += value; }
			remove { EnsureGADCustomEventBannerDelegate ().willPresentModal -= value; }
		}
		
		public event EventHandler WillDismissModal {
			add { EnsureGADCustomEventBannerDelegate ().willDismissModal += value; }
			remove { EnsureGADCustomEventBannerDelegate ().willDismissModal -= value; }
		}
		
		public event EventHandler DidDismissModal {
			add { EnsureGADCustomEventBannerDelegate ().didDismissModal += value; }
			remove { EnsureGADCustomEventBannerDelegate ().didDismissModal -= value; }
		}
		
		public event EventHandler WillLeaveApplication {
			add { EnsureGADCustomEventBannerDelegate ().willLeaveApplication += value; }
			remove { EnsureGADCustomEventBannerDelegate ().willLeaveApplication -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class GADCustomEventBanner */
	
	
	//
	// EventArgs classes
	//
	public partial class GADCustomEventBannerViewEventArgs : EventArgs {
		public GADCustomEventBannerViewEventArgs (UIView view)
		{
			this.View = view;
		}
		public UIView View { get; set; }
	}
	
	public partial class GADCustomEventBannerDidReceiveAdEventArgs : EventArgs {
		public GADCustomEventBannerDidReceiveAdEventArgs (NSError error)
		{
			this.Error = error;
		}
		public NSError Error { get; set; }
	}
	
}
