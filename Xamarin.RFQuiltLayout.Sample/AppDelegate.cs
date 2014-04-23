using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using RFQuilt;

namespace Xamarin.RFQuiltLayout.Sample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : RFAppDelegate
	{
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

