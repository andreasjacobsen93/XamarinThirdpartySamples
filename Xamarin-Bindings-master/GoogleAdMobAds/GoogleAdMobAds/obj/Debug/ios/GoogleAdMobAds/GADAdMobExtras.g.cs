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
	[Register("GADAdMobExtras", true)]
	public unsafe partial class GADAdMobExtras : NSObject {
		[CompilerGenerated]
		const string selAdditionalParameters = "additionalParameters";
		static readonly IntPtr selAdditionalParametersHandle = Selector.GetHandle ("additionalParameters");
		[CompilerGenerated]
		const string selSetAdditionalParameters_ = "setAdditionalParameters:";
		static readonly IntPtr selSetAdditionalParameters_Handle = Selector.GetHandle ("setAdditionalParameters:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADAdMobExtras");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADAdMobExtras () : base (NSObjectFlag.Empty)
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
		public GADAdMobExtras (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADAdMobExtras (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADAdMobExtras (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_AdditionalParameters_var;
		[CompilerGenerated]
		public virtual NSDictionary AdditionalParameters {
			[Export ("additionalParameters", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalParametersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalParametersHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalParameters_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalParameters:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdditionalParameters_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAdditionalParameters_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalParameters_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AdditionalParameters_var = null;
			}
		}
	} /* class GADAdMobExtras */
}
