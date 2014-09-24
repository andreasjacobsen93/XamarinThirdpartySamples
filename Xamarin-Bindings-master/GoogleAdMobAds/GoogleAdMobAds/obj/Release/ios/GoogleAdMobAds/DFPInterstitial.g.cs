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
	[Register("DFPInterstitial", true)]
	public unsafe partial class DFPInterstitial : GADInterstitial {
		[CompilerGenerated]
		const string selAppEventDelegate = "appEventDelegate";
		static readonly IntPtr selAppEventDelegateHandle = Selector.GetHandle ("appEventDelegate");
		[CompilerGenerated]
		const string selSetAppEventDelegate_ = "setAppEventDelegate:";
		static readonly IntPtr selSetAppEventDelegate_Handle = Selector.GetHandle ("setAppEventDelegate:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("DFPInterstitial");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public DFPInterstitial () : base (NSObjectFlag.Empty)
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
		public DFPInterstitial (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public DFPInterstitial (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public DFPInterstitial (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		
		public event EventHandler<GADAppEventDelegateNameInfoEventArgs> AdViewDidReceiveAppEvent {
			add { EnsureGADAppEventDelegate ().adViewDidReceiveAppEvent += value; }
			remove { EnsureGADAppEventDelegate ().adViewDidReceiveAppEvent -= value; }
		}
		
		public event EventHandler<GADAppEventDelegateInterstitialEventArgs> InterstitialDidReceiveAppEvent {
			add { EnsureGADAppEventDelegate ().interstitialDidReceiveAppEvent += value; }
			remove { EnsureGADAppEventDelegate ().interstitialDidReceiveAppEvent -= value; }
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakAppEventDelegate_var = null;
			}
		}
	} /* class DFPInterstitial */
}
