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
	[Register("libAdmobExporter", true)]
	public unsafe partial class GADAdSizeCons : NSObject {
		[CompilerGenerated]
		const string selKGADAdSizeBannerGlobal = "kGADAdSizeBannerGlobal";
		static readonly IntPtr selKGADAdSizeBannerGlobalHandle = Selector.GetHandle ("kGADAdSizeBannerGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeMediumRectangleGlobal = "kGADAdSizeMediumRectangleGlobal";
		static readonly IntPtr selKGADAdSizeMediumRectangleGlobalHandle = Selector.GetHandle ("kGADAdSizeMediumRectangleGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeFullBannerGlobal = "kGADAdSizeFullBannerGlobal";
		static readonly IntPtr selKGADAdSizeFullBannerGlobalHandle = Selector.GetHandle ("kGADAdSizeFullBannerGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeLeaderboardGlobal = "kGADAdSizeLeaderboardGlobal";
		static readonly IntPtr selKGADAdSizeLeaderboardGlobalHandle = Selector.GetHandle ("kGADAdSizeLeaderboardGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeSkyscraperGlobal = "kGADAdSizeSkyscraperGlobal";
		static readonly IntPtr selKGADAdSizeSkyscraperGlobalHandle = Selector.GetHandle ("kGADAdSizeSkyscraperGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeSmartBannerPortraitGlobal = "kGADAdSizeSmartBannerPortraitGlobal";
		static readonly IntPtr selKGADAdSizeSmartBannerPortraitGlobalHandle = Selector.GetHandle ("kGADAdSizeSmartBannerPortraitGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeSmartBannerLandscapeGlobal = "kGADAdSizeSmartBannerLandscapeGlobal";
		static readonly IntPtr selKGADAdSizeSmartBannerLandscapeGlobalHandle = Selector.GetHandle ("kGADAdSizeSmartBannerLandscapeGlobal");
		[CompilerGenerated]
		const string selKGADAdSizeInvalidGlobal = "kGADAdSizeInvalidGlobal";
		static readonly IntPtr selKGADAdSizeInvalidGlobalHandle = Selector.GetHandle ("kGADAdSizeInvalidGlobal");
		[CompilerGenerated]
		const string selGADAdSizeFromCGSizeGlobal_ = "GADAdSizeFromCGSizeGlobal:";
		static readonly IntPtr selGADAdSizeFromCGSizeGlobal_Handle = Selector.GetHandle ("GADAdSizeFromCGSizeGlobal:");
		[CompilerGenerated]
		const string selGADAdSizeFullWidthPortraitWithHeightGlobal_ = "GADAdSizeFullWidthPortraitWithHeightGlobal:";
		static readonly IntPtr selGADAdSizeFullWidthPortraitWithHeightGlobal_Handle = Selector.GetHandle ("GADAdSizeFullWidthPortraitWithHeightGlobal:");
		[CompilerGenerated]
		const string selGADAdSizeFullWidthLandscapeWithHeightGlobal_ = "GADAdSizeFullWidthLandscapeWithHeightGlobal:";
		static readonly IntPtr selGADAdSizeFullWidthLandscapeWithHeightGlobal_Handle = Selector.GetHandle ("GADAdSizeFullWidthLandscapeWithHeightGlobal:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("libAdmobExporter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GADAdSizeCons () : base (NSObjectFlag.Empty)
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
		public GADAdSizeCons (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public GADAdSizeCons (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public GADAdSizeCons (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("GADAdSizeFromCGSizeGlobal:")]
		[CompilerGenerated]
		public static GADAdSize GADAdSizeFromSizeF (global::System.Drawing.SizeF size)
		{
			GADAdSize ret;
			ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret_SizeF (out ret, class_ptr, selGADAdSizeFromCGSizeGlobal_Handle, size);
			return ret;
		}
		
		[Export ("GADAdSizeFullWidthPortraitWithHeightGlobal:")]
		[CompilerGenerated]
		public static GADAdSize GADAdSizeFullWidthPortraitWithHeight (float height)
		{
			GADAdSize ret;
			ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret_float (out ret, class_ptr, selGADAdSizeFullWidthPortraitWithHeightGlobal_Handle, height);
			return ret;
		}
		
		[Export ("GADAdSizeFullWidthLandscapeWithHeightGlobal:")]
		[CompilerGenerated]
		public static GADAdSize GADAdSizeFullWidthLandscapeWithHeight (float height)
		{
			GADAdSize ret;
			ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret_float (out ret, class_ptr, selGADAdSizeFullWidthLandscapeWithHeightGlobal_Handle, height);
			return ret;
		}
		
		[CompilerGenerated]
		public static GADAdSize Banner {
			[Export ("kGADAdSizeBannerGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeBannerGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize MediumRectangle {
			[Export ("kGADAdSizeMediumRectangleGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeMediumRectangleGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize FullBanner {
			[Export ("kGADAdSizeFullBannerGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeFullBannerGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize Leaderboard {
			[Export ("kGADAdSizeLeaderboardGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeLeaderboardGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize Skyscraper {
			[Export ("kGADAdSizeSkyscraperGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeSkyscraperGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize SmartBannerPortrait {
			[Export ("kGADAdSizeSmartBannerPortraitGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeSmartBannerPortraitGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize SmartBannerLandscape {
			[Export ("kGADAdSizeSmartBannerLandscapeGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeSmartBannerLandscapeGlobalHandle);
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static GADAdSize Invalid {
			[Export ("kGADAdSizeInvalidGlobal")]
			get {
				GADAdSize ret;
				ApiDefinition.Messaging.GADAdSize_objc_msgSend_stret (out ret, class_ptr, selKGADAdSizeInvalidGlobalHandle);
				return ret;
			}
			
		}
		
	} /* class GADAdSizeCons */
}
