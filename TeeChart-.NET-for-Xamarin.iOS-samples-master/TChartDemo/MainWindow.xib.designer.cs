
namespace TChartDemo
{


	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("AppDelegate")]
	public partial class AppDelegate
	{

		private MonoTouch.UIKit.UIWindow __mt_window;

		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				this.__mt_window = ((MonoTouch.UIKit.UIWindow)(this.GetNativeField ("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField ("window", value);
			}
		}

		private MonoTouch.UIKit.UINavigationController __mt_navigationController;

		[MonoTouch.Foundation.Connect("navigationController")]
		private MonoTouch.UIKit.UINavigationController navigationController {
			get {
				this.__mt_navigationController = ((MonoTouch.UIKit.UINavigationController)(this.GetNativeField ("navigationController")));
				return this.__mt_navigationController;
			}
			set {
				this.__mt_navigationController = value;
				this.SetNativeField ("navigationController", value);
			}
		}
	}
}

