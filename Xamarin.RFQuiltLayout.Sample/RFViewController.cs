using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using RFQuilt;

namespace Xamarin.RFQuiltLayout.Sample
{
	public partial class RFViewController
		: 
		// objective-c: UIViewController <RFQuiltLayoutDelegate>
		//global::RFQuilt.RFQuiltLayoutDelegate
	UIViewController , IRFQuiltLayoutDelegate
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get
			{
				return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;
			}
		}

		public RFViewController ()
			: base (UserInterfaceIdiomIsPhone ? "RFViewController_iPhone" : "RFViewController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		#region - UICollectionView Delegate
		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			
			
		}
		
		
		
		#endregion
		
	}
}

