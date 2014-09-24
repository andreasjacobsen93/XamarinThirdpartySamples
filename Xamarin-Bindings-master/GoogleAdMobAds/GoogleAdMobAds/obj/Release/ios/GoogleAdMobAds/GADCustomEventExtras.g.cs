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
	[Register("GADCustomEventExtras", true)]
	public unsafe partial class GADCustomEventExtras : GADAdNetworkExtras {
		[CompilerGenerated]
		const string selAllExtras = "allExtras";
		static readonly IntPtr selAllExtrasHandle = Selector.GetHandle ("allExtras");
		[CompilerGenerated]
		const string selSetExtrasForLabel_ = "setExtras:forLabel:";
		static readonly IntPtr selSetExtrasForLabel_Handle = Selector.GetHandle ("setExtras:forLabel:");
		[CompilerGenerated]
		const string selExtrasForLabel_ = "extrasForLabel:";
		static readonly IntPtr selExtrasForLabel_Handle = Selector.GetHandle ("extrasForLabel:");
		[CompilerGenerated]
		const string selRemoveAllExtras = "removeAllExtras";
		static readonly IntPtr selRemoveAllExtrasHandle = Selector.GetHandle ("removeAllExtras");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADCustomEventExtras");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADCustomEventExtras () : base (NSObjectFlag.Empty)
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
		public GADCustomEventExtras (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADCustomEventExtras (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADCustomEventExtras (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setExtras:forLabel:")]
		[CompilerGenerated]
		public virtual void SetExtras (NSDictionary extras, string label)
		{
			if (extras == null)
				throw new ArgumentNullException ("extras");
			if (label == null)
				throw new ArgumentNullException ("label");
			var nslabel = NSString.CreateNative (label);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetExtrasForLabel_Handle, extras.Handle, nslabel);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetExtrasForLabel_Handle, extras.Handle, nslabel);
			}
			NSString.ReleaseNative (nslabel);
			
			#pragma warning disable 168
			var postget0 = AllExtras;
			#pragma warning restore 168
		}
		
		[Export ("extrasForLabel:")]
		[CompilerGenerated]
		public virtual NSDictionary ExtrasForLabel (string label)
		{
			if (label == null)
				throw new ArgumentNullException ("label");
			var nslabel = NSString.CreateNative (label);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selExtrasForLabel_Handle, nslabel));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selExtrasForLabel_Handle, nslabel));
			}
			NSString.ReleaseNative (nslabel);
			
			return ret;
		}
		
		[Export ("removeAllExtras")]
		[CompilerGenerated]
		public virtual void RemoveAllExtras ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllExtrasHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRemoveAllExtrasHandle);
			}
			#pragma warning disable 168
			var postget0 = AllExtras;
			#pragma warning restore 168
		}
		
		[CompilerGenerated]
		object __mt_AllExtras_var;
		[CompilerGenerated]
		public virtual NSDictionary AllExtras {
			[Export ("allExtras")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAllExtrasHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAllExtrasHandle));
				}
				MarkDirty ();
				__mt_AllExtras_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AllExtras_var = null;
			}
		}
	} /* class GADCustomEventExtras */
}
