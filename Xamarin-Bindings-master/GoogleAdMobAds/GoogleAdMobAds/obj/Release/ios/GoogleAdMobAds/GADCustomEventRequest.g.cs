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
	[Register("GADCustomEventRequest", true)]
	public unsafe partial class GADCustomEventRequest : NSObject {
		[CompilerGenerated]
		const string selUserGender = "userGender";
		static readonly IntPtr selUserGenderHandle = Selector.GetHandle ("userGender");
		[CompilerGenerated]
		const string selUserBirthday = "userBirthday";
		static readonly IntPtr selUserBirthdayHandle = Selector.GetHandle ("userBirthday");
		[CompilerGenerated]
		const string selUserHasLocation = "userHasLocation";
		static readonly IntPtr selUserHasLocationHandle = Selector.GetHandle ("userHasLocation");
		[CompilerGenerated]
		const string selUserLatitude = "userLatitude";
		static readonly IntPtr selUserLatitudeHandle = Selector.GetHandle ("userLatitude");
		[CompilerGenerated]
		const string selUserLongitude = "userLongitude";
		static readonly IntPtr selUserLongitudeHandle = Selector.GetHandle ("userLongitude");
		[CompilerGenerated]
		const string selUserLocationAccuracyInMeters = "userLocationAccuracyInMeters";
		static readonly IntPtr selUserLocationAccuracyInMetersHandle = Selector.GetHandle ("userLocationAccuracyInMeters");
		[CompilerGenerated]
		const string selUserLocationDescription = "userLocationDescription";
		static readonly IntPtr selUserLocationDescriptionHandle = Selector.GetHandle ("userLocationDescription");
		[CompilerGenerated]
		const string selUserKeywords = "userKeywords";
		static readonly IntPtr selUserKeywordsHandle = Selector.GetHandle ("userKeywords");
		[CompilerGenerated]
		const string selAdditionalParameters = "additionalParameters";
		static readonly IntPtr selAdditionalParametersHandle = Selector.GetHandle ("additionalParameters");
		[CompilerGenerated]
		const string selIsTesting = "isTesting";
		static readonly IntPtr selIsTestingHandle = Selector.GetHandle ("isTesting");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADCustomEventRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADCustomEventRequest () : base (NSObjectFlag.Empty)
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
		public GADCustomEventRequest (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADCustomEventRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADCustomEventRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual GADGender UserGender {
			[Export ("userGender")]
			get {
				if (IsDirectBinding) {
					return (GADGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selUserGenderHandle);
				} else {
					return (GADGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selUserGenderHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UserBirthday_var;
		[CompilerGenerated]
		public virtual NSDate UserBirthday {
			[Export ("userBirthday")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserBirthdayHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserBirthdayHandle));
				}
				MarkDirty ();
				__mt_UserBirthday_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool UserHasLocation {
			[Export ("userHasLocation")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUserHasLocationHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUserHasLocationHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float UserLatitude {
			[Export ("userLatitude")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selUserLatitudeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selUserLatitudeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float UserLongitude {
			[Export ("userLongitude")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selUserLongitudeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selUserLongitudeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual float UserLocationAccuracyInMeters {
			[Export ("userLocationAccuracyInMeters")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selUserLocationAccuracyInMetersHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selUserLocationAccuracyInMetersHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string UserLocationDescription {
			[Export ("userLocationDescription")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserLocationDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserLocationDescriptionHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_UserKeywords_var;
		[CompilerGenerated]
		public virtual NSObject[] UserKeywords {
			[Export ("userKeywords")]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserKeywordsHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserKeywordsHandle));
				}
				MarkDirty ();
				__mt_UserKeywords_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AdditionalParameters_var;
		[CompilerGenerated]
		public virtual NSDictionary AdditionalParameters {
			[Export ("additionalParameters")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalParametersHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAdditionalParametersHandle));
				}
				MarkDirty ();
				__mt_AdditionalParameters_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsTesting {
			[Export ("isTesting")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTestingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTestingHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UserBirthday_var = null;
				__mt_UserKeywords_var = null;
				__mt_AdditionalParameters_var = null;
			}
		}
	} /* class GADCustomEventRequest */
}
