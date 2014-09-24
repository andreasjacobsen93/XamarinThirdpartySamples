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
	[Register("GADRequest", true)]
	public unsafe partial class GADRequest : NSObject {
		[CompilerGenerated]
		const string selRequest = "request";
		static readonly IntPtr selRequestHandle = Selector.GetHandle ("request");
		[CompilerGenerated]
		const string selMediationExtras = "mediationExtras";
		static readonly IntPtr selMediationExtrasHandle = Selector.GetHandle ("mediationExtras");
		[CompilerGenerated]
		const string selSetMediationExtras_ = "setMediationExtras:";
		static readonly IntPtr selSetMediationExtras_Handle = Selector.GetHandle ("setMediationExtras:");
		[CompilerGenerated]
		const string selSdkVersion = "sdkVersion";
		static readonly IntPtr selSdkVersionHandle = Selector.GetHandle ("sdkVersion");
		[CompilerGenerated]
		const string selTestDevices = "testDevices";
		static readonly IntPtr selTestDevicesHandle = Selector.GetHandle ("testDevices");
		[CompilerGenerated]
		const string selSetTestDevices_ = "setTestDevices:";
		static readonly IntPtr selSetTestDevices_Handle = Selector.GetHandle ("setTestDevices:");
		[CompilerGenerated]
		const string selGender = "gender";
		static readonly IntPtr selGenderHandle = Selector.GetHandle ("gender");
		[CompilerGenerated]
		const string selSetGender_ = "setGender:";
		static readonly IntPtr selSetGender_Handle = Selector.GetHandle ("setGender:");
		[CompilerGenerated]
		const string selBirthday = "birthday";
		static readonly IntPtr selBirthdayHandle = Selector.GetHandle ("birthday");
		[CompilerGenerated]
		const string selSetBirthday_ = "setBirthday:";
		static readonly IntPtr selSetBirthday_Handle = Selector.GetHandle ("setBirthday:");
		[CompilerGenerated]
		const string selKeywords = "keywords";
		static readonly IntPtr selKeywordsHandle = Selector.GetHandle ("keywords");
		[CompilerGenerated]
		const string selSetKeywords_ = "setKeywords:";
		static readonly IntPtr selSetKeywords_Handle = Selector.GetHandle ("setKeywords:");
		[CompilerGenerated]
		const string selAdditionalParameters = "additionalParameters";
		static readonly IntPtr selAdditionalParametersHandle = Selector.GetHandle ("additionalParameters");
		[CompilerGenerated]
		const string selSetAdditionalParameters_ = "setAdditionalParameters:";
		static readonly IntPtr selSetAdditionalParameters_Handle = Selector.GetHandle ("setAdditionalParameters:");
		[CompilerGenerated]
		const string selIsTesting = "isTesting";
		static readonly IntPtr selIsTestingHandle = Selector.GetHandle ("isTesting");
		[CompilerGenerated]
		const string selSetTesting_ = "setTesting:";
		static readonly IntPtr selSetTesting_Handle = Selector.GetHandle ("setTesting:");
		[CompilerGenerated]
		const string selRegisterAdNetworkExtras_ = "registerAdNetworkExtras:";
		static readonly IntPtr selRegisterAdNetworkExtras_Handle = Selector.GetHandle ("registerAdNetworkExtras:");
		[CompilerGenerated]
		const string selAdNetworkExtrasFor_ = "adNetworkExtrasFor:";
		static readonly IntPtr selAdNetworkExtrasFor_Handle = Selector.GetHandle ("adNetworkExtrasFor:");
		[CompilerGenerated]
		const string selRemoveAdNetworkExtrasFor_ = "removeAdNetworkExtrasFor:";
		static readonly IntPtr selRemoveAdNetworkExtrasFor_Handle = Selector.GetHandle ("removeAdNetworkExtrasFor:");
		[CompilerGenerated]
		const string selSetBirthdayWithMonthDayYear_ = "setBirthdayWithMonth:day:year:";
		static readonly IntPtr selSetBirthdayWithMonthDayYear_Handle = Selector.GetHandle ("setBirthdayWithMonth:day:year:");
		[CompilerGenerated]
		const string selSetLocationWithLatitudeLongitudeAccuracy_ = "setLocationWithLatitude:longitude:accuracy:";
		static readonly IntPtr selSetLocationWithLatitudeLongitudeAccuracy_Handle = Selector.GetHandle ("setLocationWithLatitude:longitude:accuracy:");
		[CompilerGenerated]
		const string selSetLocationWithDescription_ = "setLocationWithDescription:";
		static readonly IntPtr selSetLocationWithDescription_Handle = Selector.GetHandle ("setLocationWithDescription:");
		[CompilerGenerated]
		const string selTagForChildDirectedTreatment_ = "tagForChildDirectedTreatment:";
		static readonly IntPtr selTagForChildDirectedTreatment_Handle = Selector.GetHandle ("tagForChildDirectedTreatment:");
		[CompilerGenerated]
		const string selAddKeyword_ = "addKeyword:";
		static readonly IntPtr selAddKeyword_Handle = Selector.GetHandle ("addKeyword:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public GADRequest (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("registerAdNetworkExtras:")]
		[CompilerGenerated]
		public virtual void RegisterAdNetworkExtras (GADAdNetworkExtras extras)
		{
			if (extras == null)
				throw new ArgumentNullException ("extras");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRegisterAdNetworkExtras_Handle, extras.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRegisterAdNetworkExtras_Handle, extras.Handle);
			}
		}
		
		[Export ("adNetworkExtrasFor:")]
		[CompilerGenerated]
		public virtual GADAdNetworkExtras AdNetworkExtrasFor (Class clazz)
		{
			if (clazz == null)
				throw new ArgumentNullException ("clazz");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<GADAdNetworkExtras> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAdNetworkExtrasFor_Handle, clazz.Handle));
			} else {
				return  Runtime.GetNSObject<GADAdNetworkExtras> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selAdNetworkExtrasFor_Handle, clazz.Handle));
			}
		}
		
		[Export ("removeAdNetworkExtrasFor:")]
		[CompilerGenerated]
		public virtual void RemoveAdNetworkExtrasFor (Class clazz)
		{
			if (clazz == null)
				throw new ArgumentNullException ("clazz");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveAdNetworkExtrasFor_Handle, clazz.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveAdNetworkExtrasFor_Handle, clazz.Handle);
			}
		}
		
		[Export ("setBirthdayWithMonth:day:year:")]
		[CompilerGenerated]
		public virtual void SetBirthday (int m, int d, int y)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int_int_int (this.Handle, selSetBirthdayWithMonthDayYear_Handle, m, d, y);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int_int_int (this.SuperHandle, selSetBirthdayWithMonthDayYear_Handle, m, d, y);
			}
		}
		
		[Export ("setLocationWithLatitude:longitude:accuracy:")]
		[CompilerGenerated]
		public virtual void SetLocationWithLatitude (float latitude, float longitude, float accuracyInMeters)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_float_float_float (this.Handle, selSetLocationWithLatitudeLongitudeAccuracy_Handle, latitude, longitude, accuracyInMeters);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_float_float_float (this.SuperHandle, selSetLocationWithLatitudeLongitudeAccuracy_Handle, latitude, longitude, accuracyInMeters);
			}
		}
		
		[Export ("setLocationWithDescription:")]
		[CompilerGenerated]
		public virtual void SetLocationWithDescription (string locationDescription)
		{
			if (locationDescription == null)
				throw new ArgumentNullException ("locationDescription");
			var nslocationDescription = NSString.CreateNative (locationDescription);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocationWithDescription_Handle, nslocationDescription);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocationWithDescription_Handle, nslocationDescription);
			}
			NSString.ReleaseNative (nslocationDescription);
			
		}
		
		[Export ("tagForChildDirectedTreatment:")]
		[CompilerGenerated]
		public virtual void TagForChildDirectedTreatment (bool childDirectedTreatment)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selTagForChildDirectedTreatment_Handle, childDirectedTreatment);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selTagForChildDirectedTreatment_Handle, childDirectedTreatment);
			}
		}
		
		[Export ("addKeyword:")]
		[CompilerGenerated]
		public virtual void AddKeyword (string keyword)
		{
			if (keyword == null)
				throw new ArgumentNullException ("keyword");
			var nskeyword = NSString.CreateNative (keyword);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddKeyword_Handle, nskeyword);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddKeyword_Handle, nskeyword);
			}
			NSString.ReleaseNative (nskeyword);
			
		}
		
		[CompilerGenerated]
		static object __mt_Request_var_static;
		[CompilerGenerated]
		public static GADRequest Request {
			[Export ("request")]
			get {
				GADRequest ret;
				ret =  Runtime.GetNSObject<GADRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selRequestHandle));
				__mt_Request_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_MediationExtras_var;
		[CompilerGenerated]
		public virtual NSDictionary MediationExtras {
			[Export ("mediationExtras", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMediationExtrasHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMediationExtrasHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MediationExtras_var = ret;
				return ret;
			}
			
			[Export ("setMediationExtras:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMediationExtras_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMediationExtras_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MediationExtras_var = value;
			}
		}
		
		[CompilerGenerated]
		public static string SdkVersion {
			[Export ("sdkVersion")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSdkVersionHandle));
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.String[] TestDevices {
			[Export ("testDevices", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTestDevicesHandle));
				} else {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTestDevicesHandle));
				}
			}
			
			[Export ("setTestDevices:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTestDevices_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTestDevices_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual GADGender Gender {
			[Export ("gender", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (GADGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selGenderHandle);
				} else {
					return (GADGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selGenderHandle);
				}
			}
			
			[Export ("setGender:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetGender_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetGender_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Birthday_var;
		[CompilerGenerated]
		public virtual NSDate Birthday {
			[Export ("birthday", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBirthdayHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBirthdayHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Birthday_var = ret;
				return ret;
			}
			
			[Export ("setBirthday:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBirthday_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBirthday_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Birthday_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.String[] keywords {
			[Export ("keywords", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKeywordsHandle));
				} else {
					return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selKeywordsHandle));
				}
			}
			
			[Export ("setKeywords:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value == null ? null : NSArray.FromStrings (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKeywords_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetKeywords_Handle, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				}
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		object __mt_AdditionalParameters_var;
		[CompilerGenerated]
		[Obsolete ("Please use void RegisterAdNetworkExtras(GADAdNetworkExtras extras) instead", false)]
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
		[Obsolete ("Please set TestDevices instead.", false)]
		public virtual bool Testing {
			[Export ("isTesting")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTestingHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTestingHandle);
				}
			}
			
			[Export ("setTesting:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTesting_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTesting_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_MediationExtras_var = null;
				__mt_Birthday_var = null;
				__mt_AdditionalParameters_var = null;
			}
		}
	} /* class GADRequest */
}
