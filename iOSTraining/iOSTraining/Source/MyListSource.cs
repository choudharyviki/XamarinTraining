using System;
using Foundation;
using iOSTraining.Cell;
using ObjCRuntime;
//using Mono;
using UIKit;

namespace iOSTraining.Source
{
    public class MyListSource: UITableViewSource
    {
        public MyListSource()
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            listcell cell = tableView.DequeueReusableCell("mylistcell") as listcell;
            if (cell == null)
            {
                var bundel = NSBundle.MainBundle.LoadNib("listcell", null, null);
                cell = Runtime.GetNSObject(bundel.ValueAt(0)) as listcell;
            }
            //cell.Name = "Xib table view";
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
           return 1;
        }
    }
}
