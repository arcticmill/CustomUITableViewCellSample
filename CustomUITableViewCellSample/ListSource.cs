using System;
using MonoTouch.UIKit;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace CustomUITableViewCellSample
{
	public class ListSource : UITableViewSource
	{
		private List<string> _testData = new List<string> ();
		
		public ListSource ()
		{
			_testData.Add ("Green");
			_testData.Add ("Red");
			_testData.Add ("Blue");
			_testData.Add ("Yellow");
			_testData.Add ("Purple");
			_testData.Add ("Orange");			
		}
		
		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			// Reuse a cell if one exists
			CustomListCell cell = tableView.DequeueReusableCell ("ColorCell") as CustomListCell;
			
			if (cell == null) {			
				// We have to allocate a cell
				var views = NSBundle.MainBundle.LoadNib ("CustomListCell", tableView, null);
				cell = Runtime.GetNSObject (views.ValueAt (0)) as CustomListCell;
			}
			
			// This cell has been used before, so we need to update it's data
			cell.UpdateWithData (_testData [indexPath.Row]);			
						
			return cell;
		}
		
		public override int RowsInSection (UITableView tableview, int section)
		{
			return _testData.Count;
		}
	}
}





//		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
//		{
//			// Reuse a cell if one exists
//			UITableViewCell cell = tableView.DequeueReusableCell ("ColorCell");
//			
//			if (cell == null) {			
//				// We have to allocate a cell
//				cell = new UITableViewCell(UITableViewCellStyle.Default, "ColorCell");
//				
//				// Set initial data
//				cell.TextLabel.Text = _testData[indexPath.Row];
//			} else {
//					
//				// This cell has been used before, so we need to update it's data
//				cell.TextLabel.Text = _testData[indexPath.Row];	
//			}
//						
//			return cell;
//		}