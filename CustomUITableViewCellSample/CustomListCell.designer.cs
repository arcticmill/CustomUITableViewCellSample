// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace CustomUITableViewCellSample
{
	[Register ("CustomListCell")]
	partial class CustomListCell
	{
		[Outlet]
		MonoTouch.UIKit.UIButton testButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (testButton != null) {
				testButton.Dispose ();
				testButton = null;
			}
		}
	}
}
