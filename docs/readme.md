
Error:

MonoTouch.Foundation.MonoTouchException: Objective-C exception thrown.  
	Name: NSInternalInconsistencyException 
	Reason: Unable to instantiate the UIApplication delegate instance. No class named RFAppDelegate is loaded.
  at at (wrapper managed-to-native) MonoTouch.UIKit.UIApplication:UIApplicationMain (int,string[],intptr,intptr)
  at MonoTouch.UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x0004c] in /Developer/MonoTouch/Source/monotouch/src/UIKit/UIApplication.cs:38
  at Xamarin.RFQuiltLayout.Sample.Application.Main (System.String[] args) [0x00008] in Xamarin.RFQuiltLayout/Xamarin.RFQuiltLayout.Sample/Main.cs:16

Solution:

	[Register("RFAppDelegate")]
	public class RFAppDelegate : UIApplicationDelegate
  

Error:

MonoTouch.Foundation.MonoTouchException: Objective-C exception thrown.  
	Name: NSInvalidArgumentException 
	Reason: Could not find a storyboard named 'MainStoryboard_iPhone' in bundle NSBundle  
  at at (wrapper managed-to-native) MonoTouch.UIKit.UIApplication:UIApplicationMain (int,string[],intptr,intptr)
  at MonoTouch.UIKit.UIApplication.Main (System.String[] args, System.String principalClassName, System.String delegateClassName) [0x0004c] in /Developer/MonoTouch/Source/monotouch/src/UIKit/UIApplication.cs:38
  at Xamarin.RFQuiltLayout.Sample.Application.Main (System.String[] args) [0x00008] in Xamarin.RFQuiltLayout/Xamarin.RFQuiltLayout.Sample/Main.cs:16

Set 
	Project +/ Options +/ Build +/ iOS Application +/ Main Interface 
	
to
	RFViewController_iPhone