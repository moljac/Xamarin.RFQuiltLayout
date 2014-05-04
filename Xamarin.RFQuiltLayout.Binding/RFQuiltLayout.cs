using System.Drawing;
using System;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace RFQuilt 
{
	[Model]
	[Protocol]
	// [BaseType (typeof (IUICollectionViewDelegate))] // base class
	public partial interface IRFQuiltLayoutDelegate 
			: 
			/*
				UICollectionViewDelegate	 	// ObjectiveSharpie generated
												// ./native/RFQuiltLayout.h
				Error CS0527: 
				Type `MonoTouch.UIKit.UICollectionViewDelegate' in interface list is not an interface (CS0527)				
			 */
			 IUICollectionViewDelegate			// shuts up compiler, but is this right?
	{

		[Export ("BlockSizeForItemAtIndexPath:")]
		SizeF BlockSizeForItemAtIndexPath (NSIndexPath indexPath);

		[Export ("InsetsForItemAtIndexPath:")]
		UIEdgeInsets InsetsForItemAtIndexPath (NSIndexPath indexPath);
	}

	[BaseType (typeof (UICollectionViewLayout))]
	public partial interface RFQuiltLayout {

		[Export ("delegate", ArgumentSemantic.Assign)]
		NSObject					// typed is better!   
		//IRFQuiltLayoutDelegate  	// Better but cannot compile 
			Delegate 
			{ 
				get; 
				[NullAllowed] set; 
			}

		[Export ("blockPixels", ArgumentSemantic.Assign)]
		SizeF BlockPixels { get; set; }

		[Export ("direction")]
		UICollectionViewScrollDirection Direction { get; set; }

		[Export ("prelayoutEverything")]
		bool PrelayoutEverything { get; set; }
	}
}
