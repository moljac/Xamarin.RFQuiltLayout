using System.Drawing;
using System;

namespace RFQuiltLayout {

	[Model]
	public partial interface RFQuiltLayoutDelegate : UICollectionViewDelegate {

		[Export ("BlockSizeForItemAtIndexPath")]
		SizeF BlockSizeForItemAtIndexPath (NSIndexPath indexPath);

		[Export ("InsetsForItemAtIndexPath")]
		UIEdgeInsets InsetsForItemAtIndexPath (NSIndexPath indexPath);
	}

	[BaseType (typeof (UICollectionViewLayout))]
	public partial interface RFQuiltLayout {

		[Export ("delegate", ArgumentSemantic.Assign)]
		NSObject Delegate { get; set; }

		[Export ("blockPixels", ArgumentSemantic.Assign)]
		SizeF BlockPixels { get; set; }

		[Export ("direction")]
		UICollectionViewScrollDirection Direction { get; set; }

		[Export ("prelayoutEverything")]
		bool PrelayoutEverything { get; set; }
	}
}
