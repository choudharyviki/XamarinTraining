using System;
using Foundation;
using iOSTraining.Cell;
using ObjCRuntime;
using UIKit;

namespace iOSTraining.Source
{
    public class MyTableviewSource: UITableViewSource
    {
        public MyTableviewSource()
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            MyTableViewCell cell = tableView.DequeueReusableCell("MyXibCell") as MyTableViewCell;
            if(cell==null)
            {
                var bundel = NSBundle.MainBundle.LoadNib("MyTableViewCell", null, null);
                cell = Runtime.GetNSObject(bundel.ValueAt(0)) as MyTableViewCell;
            }
            cell.Name = "Xib table view";
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 10;
        }
    }
}
