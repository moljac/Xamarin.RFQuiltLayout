using System;

using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace Xamarin.RFQuiltLayout.Sample
{
	//[Register("RFAppDelegate")]
	public class RFAppDelegate : UIApplicationDelegate
	{
		// @property (strong, nonatomic) UIWindow *window;
		public UIWindow window;
		
		// @property (strong, nonatomic) RFViewController *viewController;
		public RFViewController ViewController;
		
		public RFAppDelegate ()
			: base()
		{
		}
		
		// class-level declarations
		public override UIWindow Window
		{
			get;
			set;
		}
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Window = new UIWindow (UIScreen.MainScreen.Bounds);
			
		    // Override point for customization after application launch.
			this.ViewController = new RFViewController();
		    this.Window.RootViewController = this.ViewController;

			Window.MakeKeyAndVisible ();

			return true;
		}
		// This method is invoked when the application is about to move from active to inactive state.
		// OpenGL applications should use this method to pause.
		public override void OnResignActivation (UIApplication application)
		{
		}
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		// This method is called when the application is about to terminate. Save data, if needed.
		public override void WillTerminate (UIApplication application)
		{
		}
		
	}
}

