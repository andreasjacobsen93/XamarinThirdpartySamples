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
	[Register("DFPBannerView", true)]
	public unsafe partial class DFPBannerView : GADBannerView {
		[CompilerGenerated]
		const string selAppEventDelegate = "appEventDelegate";
		static readonly IntPtr selAppEventDelegateHandle = Selector.GetHandle ("appEventDelegate");
		[CompilerGenerated]
		const string selSetAppEventDelegate_ = "setAppEventDelegate:";
		static readonly IntPtr selSetAppEventDelegate_Handle = Selector.GetHandle ("setAppEventDelegate:");
		[CompilerGenerated]
		const string selAdSizeDelegate = "adSizeDelegate";
		static readonly IntPtr selAdSizeDelegateHandle = Selector.GetHandle ("adSizeDelegate");
		[CompilerGenerated]
		const string selSetAdSizeDelegate_ = "setAdSizeDelegate:";
		static readonly IntPtr selSetAdSizeDelegate_Handle = Selector.GetHandle ("setAdSizeDelegate:");
		[CompilerGenerated]
		const string selValidAdSizes = "validAdSizes";
		static readonly IntPtr selValidAdSizesHandle = Selector.GetHandle ("validAdSizes");
		[CompilerGenerated]
		const string selSetValidAdSizes_ = "setValidAdSizes:";
		static readonly IntPtr selSetValidAdSizes_Handle = Selector.GetHandle ("setValidAdSizes:");
		[CompilerGenerated]
		const string selEnableManualImpressions = "enableManualImpressions";
		static readonly IntPtr selEnableManualImpressionsHandle = Selector.GetHandle ("enableManualImpressions");
		[CompilerGenerated]
		const string selSetEnableManualImpressions_ = "setEnableManualImpressions:";
		static readonly IntPtr selSetEnableManualImpressions_Handle = Selector.GetHandle ("setEnableManualImpressions:");
		[CompilerGenerated]
		const string selInitWithAdSizeOrigin_ = "initWithAdSize:origin:";
		static readonly IntPtr selInitWithAdSizeOrigin_Handle = Selector.GetHandle ("initWithAdSize:origin:");
		[CompilerGenerated]
		const string selInitWithAdSize_ = "initWithAdSize:";
		static readonly IntPtr selInitWithAdSize_Handle = Selector.GetHandle ("initWithAdSize:");
		[CompilerGenerated]
		const string selRecordImpression = "recordImpression";
		static readonly IntPtr selRecordImpressionHandle = Selector.GetHandle ("recordImpression");
		[CompilerGenerated]
		const string selResize_ = "resize:";
		static readonly IntPtr selResize_Handle = Selector.GetHandle ("resize:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("DFPBannerView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public DFPBannerView () : base (NSObjectFlag.Empty)
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
		public DFPBannerView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public DFPBannerView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DFPBannerView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAdSize:origin:")]
		[CompilerGenerated]
		public DFPBannerView (GADAdSize size, global::System.Drawing.PointF origin)
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
		public DFPBannerView (GADAdSize size)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSend_GADAdSize (this.Handle, selInitWithAdSize_Handle, size);
			} else {
				Handle = ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_GADAdSize (this.SuperHandle, selInitWithAdSize_Handle, size);
			}
		}
		
		[Export ("recordImpression")]
		[CompilerGenerated]
		public virtual void RecordImpression ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRecordImpressionHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRecordImpressionHandle);
			}
		}
		
		[Export ("resize:")]
		[CompilerGenerated]
		public virtual void Resize (GADAdSize size)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_GADAdSize (this.Handle, selResize_Handle, size);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_GADAdSize (this.SuperHandle, selResize_Handle, size);
			}
		}
		
		[CompilerGenerated]
		public GADAppEventDelegate AppEventDelegate {
			get {
				return WeakAppEventDelegate as GADAppEventDelegate;
			}
			set {
				WeakAppEventDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakAppEventDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakAppEventDelegate {
			[Export ("appEventDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAppEventDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAppEventDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakAppEventDelegate_var = ret;
				return ret;
			}
			
			[Export ("setAppEventDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAppEventDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAppEventDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakAppEventDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public GADAdSizeDelegate AdSizeDelegate {
			get {
				return WeakAdSizeDelegate as GADAdSizeDelegate;
			}
			set {
				WeakAdSizeDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakAdSizeDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakAdSizeDelegate {
			[Export ("adSizeDelegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdSizeDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdSizeDelegateHandle));
				}
				MarkDirty ();
				__mt_WeakAdSizeDelegate_var = ret;
				return ret;
			}
			
			[Export ("setAdSizeDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdSizeDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAdSizeDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakAdSizeDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ValidAdSizes_var;
		[CompilerGenerated]
		public virtual NSArray ValidAdSizes {
			[Export ("validAdSizes", ArgumentSemantic.Retain)]
			get {
				NSArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selValidAdSizesHandle));
				} else {
					ret =  Runtime.GetNSObject<NSArray> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selValidAdSizesHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ValidAdSizes_var = ret;
				return ret;
			}
			
			[Export ("setValidAdSizes:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetValidAdSizes_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetValidAdSizes_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ValidAdSizes_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool EnableManualImpressions {
			[Export ("enableManualImpressions")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableManualImpressionsHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selEnableManualImpressionsHandle);
				}
			}
			
			[Export ("setEnableManualImpressions:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableManualImpressions_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetEnableManualImpressions_Handle, value);
				}
			}
		}
		
		//
		// Events and properties from the delegate
		//
		
		_GADAppEventDelegate EnsureGADAppEventDelegate ()
		{
			var del = WeakAppEventDelegate;
			if (del == null || (!(del is _GADAppEventDelegate))){
				del = new _GADAppEventDelegate ();
				WeakAppEventDelegate = del;
			}
			return (_GADAppEventDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADAppEventDelegate : GoogleAdMobAds.GADAppEventDelegate { 
			public _GADAppEventDelegate () { IsDirectBinding = false; }
			
			internal EventHandler<GADAppEventDelegateNameInfoEventArgs> adViewDidReceiveAppEvent;
			[Preserve (Conditional = true)]
			public override void AdViewDidReceiveAppEvent (GoogleAdMobAds.GADBannerView banner, string name, string info)
			{
				EventHandler<GADAppEventDelegateNameInfoEventArgs> handler = adViewDidReceiveAppEvent;
				if (handler != null){
					var args = new GADAppEventDelegateNameInfoEventArgs (name, info);
					handler (banner, args);
				}
			}
			
			internal EventHandler<GADAppEventDelegateInterstitialEventArgs> interstitialDidReceiveAppEvent;
			[Preserve (Conditional = true)]
			public override void InterstitialDidReceiveAppEvent (GoogleAdMobAds.GADInterstitial interstitial, string name, string info)
			{
				EventHandler<GADAppEventDelegateInterstitialEventArgs> handler = interstitialDidReceiveAppEvent;
				if (handler != null){
					var args = new GADAppEventDelegateInterstitialEventArgs (name, info);
					handler (interstitial, args);
				}
			}
			
		}
		#pragma warning restore 672
		_GADAdSizeDelegate EnsureGADAdSizeDelegate ()
		{
			var del = WeakAdSizeDelegate;
			if (del == null || (!(del is _GADAdSizeDelegate))){
				del = new _GADAdSizeDelegate ();
				WeakAdSizeDelegate = del;
			}
			return (_GADAdSizeDelegate) del;
		}
		
		#pragma warning disable 672
		[Register]
		sealed class _GADAdSizeDelegate : GoogleAdMobAds.GADAdSizeDelegate { 
			public _GADAdSizeDelegate () { IsDirectBinding = false; }
			
			internal EventHandler<GADAdSizeDelegateSizeEventArgs> willChangeAdSizeTo;
			[Preserve (Conditional = true)]
			public override void WillChangeAdSizeTo (GoogleAdMobAds.GADBannerView view, GoogleAdMobAds.GADAdSize size)
			{
				EventHandler<GADAdSizeDelegateSizeEventArgs> handler = willChangeAdSizeTo;
				if (handler != null){
					var args = new GADAdSizeDelegateSizeEventArgs (size);
					handler (view, args);
				}
			}
			
		}
		#pragma warning restore 672
		
		public event EventHandler<GADAppEventDelegateNameInfoEventArgs> AdViewDidReceiveAppEvent {
			add { EnsureGADAppEventDelegate ().adViewDidReceiveAppEvent += value; }
			remove { EnsureGADAppEventDelegate ().adViewDidReceiveAppEvent -= value; }
		}
		
		public event EventHandler<GADAppEventDelegateInterstitialEventArgs> InterstitialDidReceiveAppEvent {
			add { EnsureGADAppEventDelegate ().interstitialDidReceiveAppEvent += value; }
			remove { EnsureGADAppEventDelegate ().interstitialDidReceiveAppEvent -= value; }
		}
		
		public event EventHandler<GADAdSizeDelegateSizeEventArgs> WillChangeAdSizeTo {
			add { EnsureGADAdSizeDelegate ().willChangeAdSizeTo += value; }
			remove { EnsureGADAdSizeDelegate ().willChangeAdSizeTo -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakAppEventDelegate_var = null;
				__mt_WeakAdSizeDelegate_var = null;
				__mt_ValidAdSizes_var = null;
			}
		}
	} /* class DFPBannerView */
	
	
	//
	// EventArgs classes
	//
	public partial class GADAppEventDelegateNameInfoEventArgs : EventArgs {
		public GADAppEventDelegateNameInfoEventArgs (string name, string info)
		{
			this.Name = name;
			this.Info = info;
		}
		public string Name { get; set; }
		public string Info { get; set; }
	}
	
	public partial class GADAppEventDelegateInterstitialEventArgs : EventArgs {
		public GADAppEventDelegateInterstitialEventArgs (string name, string info)
		{
			this.Name = name;
			this.Info = info;
		}
		public string Name { get; set; }
		public string Info { get; set; }
	}
	
	public partial class GADAdSizeDelegateSizeEventArgs : EventArgs {
		public GADAdSizeDelegateSizeEventArgs (GoogleAdMobAds.GADAdSize size)
		{
			this.Size = size;
		}
		public GoogleAdMobAds.GADAdSize Size { get; set; }
	}
	
}
