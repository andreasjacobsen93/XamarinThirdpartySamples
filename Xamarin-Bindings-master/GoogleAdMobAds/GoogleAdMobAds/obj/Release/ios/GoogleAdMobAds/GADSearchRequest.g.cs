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
	[Register("GADSearchRequest", true)]
	public unsafe partial class GADSearchRequest : NSObject {
		[CompilerGenerated]
		const string selQuery = "query";
		static readonly IntPtr selQueryHandle = Selector.GetHandle ("query");
		[CompilerGenerated]
		const string selSetQuery_ = "setQuery:";
		static readonly IntPtr selSetQuery_Handle = Selector.GetHandle ("setQuery:");
		[CompilerGenerated]
		const string selBackgroundColor = "backgroundColor";
		static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle ("backgroundColor");
		[CompilerGenerated]
		const string selGradientFrom = "gradientFrom";
		static readonly IntPtr selGradientFromHandle = Selector.GetHandle ("gradientFrom");
		[CompilerGenerated]
		const string selGradientTo = "gradientTo";
		static readonly IntPtr selGradientToHandle = Selector.GetHandle ("gradientTo");
		[CompilerGenerated]
		const string selHeaderColor = "headerColor";
		static readonly IntPtr selHeaderColorHandle = Selector.GetHandle ("headerColor");
		[CompilerGenerated]
		const string selSetHeaderColor_ = "setHeaderColor:";
		static readonly IntPtr selSetHeaderColor_Handle = Selector.GetHandle ("setHeaderColor:");
		[CompilerGenerated]
		const string selDescriptionTextColor = "descriptionTextColor";
		static readonly IntPtr selDescriptionTextColorHandle = Selector.GetHandle ("descriptionTextColor");
		[CompilerGenerated]
		const string selSetDescriptionTextColor_ = "setDescriptionTextColor:";
		static readonly IntPtr selSetDescriptionTextColor_Handle = Selector.GetHandle ("setDescriptionTextColor:");
		[CompilerGenerated]
		const string selAnchorTextColor = "anchorTextColor";
		static readonly IntPtr selAnchorTextColorHandle = Selector.GetHandle ("anchorTextColor");
		[CompilerGenerated]
		const string selSetAnchorTextColor_ = "setAnchorTextColor:";
		static readonly IntPtr selSetAnchorTextColor_Handle = Selector.GetHandle ("setAnchorTextColor:");
		[CompilerGenerated]
		const string selFontFamily = "fontFamily";
		static readonly IntPtr selFontFamilyHandle = Selector.GetHandle ("fontFamily");
		[CompilerGenerated]
		const string selSetFontFamily_ = "setFontFamily:";
		static readonly IntPtr selSetFontFamily_Handle = Selector.GetHandle ("setFontFamily:");
		[CompilerGenerated]
		const string selHeaderTextSize = "headerTextSize";
		static readonly IntPtr selHeaderTextSizeHandle = Selector.GetHandle ("headerTextSize");
		[CompilerGenerated]
		const string selSetHeaderTextSize_ = "setHeaderTextSize:";
		static readonly IntPtr selSetHeaderTextSize_Handle = Selector.GetHandle ("setHeaderTextSize:");
		[CompilerGenerated]
		const string selBorderColor = "borderColor";
		static readonly IntPtr selBorderColorHandle = Selector.GetHandle ("borderColor");
		[CompilerGenerated]
		const string selSetBorderColor_ = "setBorderColor:";
		static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle ("setBorderColor:");
		[CompilerGenerated]
		const string selBorderType = "borderType";
		static readonly IntPtr selBorderTypeHandle = Selector.GetHandle ("borderType");
		[CompilerGenerated]
		const string selSetBorderType_ = "setBorderType:";
		static readonly IntPtr selSetBorderType_Handle = Selector.GetHandle ("setBorderType:");
		[CompilerGenerated]
		const string selBorderThickness = "borderThickness";
		static readonly IntPtr selBorderThicknessHandle = Selector.GetHandle ("borderThickness");
		[CompilerGenerated]
		const string selSetBorderThickness_ = "setBorderThickness:";
		static readonly IntPtr selSetBorderThickness_Handle = Selector.GetHandle ("setBorderThickness:");
		[CompilerGenerated]
		const string selCustomChannels = "customChannels";
		static readonly IntPtr selCustomChannelsHandle = Selector.GetHandle ("customChannels");
		[CompilerGenerated]
		const string selSetCustomChannels_ = "setCustomChannels:";
		static readonly IntPtr selSetCustomChannels_Handle = Selector.GetHandle ("setCustomChannels:");
		[CompilerGenerated]
		const string selCallButtonColor = "callButtonColor";
		static readonly IntPtr selCallButtonColorHandle = Selector.GetHandle ("callButtonColor");
		[CompilerGenerated]
		const string selSetCallButtonColor_ = "setCallButtonColor:";
		static readonly IntPtr selSetCallButtonColor_Handle = Selector.GetHandle ("setCallButtonColor:");
		[CompilerGenerated]
		const string selRequest = "request";
		static readonly IntPtr selRequestHandle = Selector.GetHandle ("request");
		[CompilerGenerated]
		const string selSetBackgroundSolid_ = "setBackgroundSolid:";
		static readonly IntPtr selSetBackgroundSolid_Handle = Selector.GetHandle ("setBackgroundSolid:");
		[CompilerGenerated]
		const string selSetBackgroundGradientFromToColor_ = "setBackgroundGradientFrom:toColor:";
		static readonly IntPtr selSetBackgroundGradientFromToColor_Handle = Selector.GetHandle ("setBackgroundGradientFrom:toColor:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("GADSearchRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADSearchRequest () : base (NSObjectFlag.Empty)
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
		public GADSearchRequest (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADSearchRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADSearchRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setBackgroundSolid:")]
		[CompilerGenerated]
		public virtual void SetBackgroundSolid (global::MonoTouch.UIKit.UIColor color)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundSolid_Handle, color.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundSolid_Handle, color.Handle);
			}
		}
		
		[Export ("setBackgroundGradientFrom:toColor:")]
		[CompilerGenerated]
		public virtual void SetBackgroundGradient (global::MonoTouch.UIKit.UIColor fromColor, global::MonoTouch.UIKit.UIColor toColor)
		{
			if (fromColor == null)
				throw new ArgumentNullException ("fromColor");
			if (toColor == null)
				throw new ArgumentNullException ("toColor");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetBackgroundGradientFromToColor_Handle, fromColor.Handle, toColor.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetBackgroundGradientFromToColor_Handle, fromColor.Handle, toColor.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string Query {
			[Export ("query", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selQueryHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selQueryHandle));
				}
			}
			
			[Export ("setQuery:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetQuery_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetQuery_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BackgroundColor {
			[Export ("backgroundColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundColorHandle));
				}
				MarkDirty ();
				__mt_BackgroundColor_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_GradientFrom_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor GradientFrom {
			[Export ("gradientFrom")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGradientFromHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGradientFromHandle));
				}
				MarkDirty ();
				__mt_GradientFrom_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_GradientTo_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor GradientTo {
			[Export ("gradientTo")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGradientToHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selGradientToHandle));
				}
				MarkDirty ();
				__mt_GradientTo_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_HeaderColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor HeaderColor {
			[Export ("headerColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHeaderColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHeaderColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_HeaderColor_var = ret;
				return ret;
			}
			
			[Export ("setHeaderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHeaderColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHeaderColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_HeaderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DescriptionTextColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor DescriptionTextColor {
			[Export ("descriptionTextColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDescriptionTextColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDescriptionTextColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_DescriptionTextColor_var = ret;
				return ret;
			}
			
			[Export ("setDescriptionTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDescriptionTextColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDescriptionTextColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_DescriptionTextColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AnchorTextColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor AnchorTextColor {
			[Export ("anchorTextColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAnchorTextColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAnchorTextColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnchorTextColor_var = ret;
				return ret;
			}
			
			[Export ("setAnchorTextColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAnchorTextColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAnchorTextColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_AnchorTextColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string FontFamily {
			[Export ("fontFamily", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFontFamilyHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFontFamilyHandle));
				}
			}
			
			[Export ("setFontFamily:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFontFamily_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFontFamily_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int HeaderTextSize {
			[Export ("headerTextSize")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHeaderTextSizeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHeaderTextSizeHandle);
				}
			}
			
			[Export ("setHeaderTextSize:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHeaderTextSize_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHeaderTextSize_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_BorderColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BorderColor {
			[Export ("borderColor", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBorderColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBorderColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BorderColor_var = ret;
				return ret;
			}
			
			[Export ("setBorderColor:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBorderColor_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBorderColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BorderColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual GADSearchBorderType BorderType {
			[Export ("borderType")]
			get {
				if (IsDirectBinding) {
					return (GADSearchBorderType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBorderTypeHandle);
				} else {
					return (GADSearchBorderType) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBorderTypeHandle);
				}
			}
			
			[Export ("setBorderType:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetBorderType_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetBorderType_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int BorderThickness {
			[Export ("borderThickness")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBorderThicknessHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selBorderThicknessHandle);
				}
			}
			
			[Export ("setBorderThickness:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetBorderThickness_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetBorderThickness_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CustomChannels {
			[Export ("customChannels", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomChannelsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCustomChannelsHandle));
				}
			}
			
			[Export ("setCustomChannels:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomChannels_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCustomChannels_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual GADSearchCallButtonColor CallButtonColor {
			[Export ("callButtonColor")]
			get {
				if (IsDirectBinding) {
					return (GADSearchCallButtonColor) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCallButtonColorHandle);
				} else {
					return (GADSearchCallButtonColor) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selCallButtonColorHandle);
				}
			}
			
			[Export ("setCallButtonColor:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetCallButtonColor_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetCallButtonColor_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Request_var;
		[CompilerGenerated]
		public virtual GADRequest Request {
			[Export ("request")]
			get {
				GADRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GADRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestHandle));
				} else {
					ret =  Runtime.GetNSObject<GADRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestHandle));
				}
				MarkDirty ();
				__mt_Request_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackgroundColor_var = null;
				__mt_GradientFrom_var = null;
				__mt_GradientTo_var = null;
				__mt_HeaderColor_var = null;
				__mt_DescriptionTextColor_var = null;
				__mt_AnchorTextColor_var = null;
				__mt_BorderColor_var = null;
				__mt_Request_var = null;
			}
		}
	} /* class GADSearchRequest */
}
