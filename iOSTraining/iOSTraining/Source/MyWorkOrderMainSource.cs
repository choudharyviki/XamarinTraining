using System;
using Foundation;
using iOSTraining.Cell;
using ObjCRuntime;
using UIKit;

namespace iOSTraining.Source
{
    public class MyWorkOrderMainSource: UITableViewSource
    {
        public MyWorkOrderMainSource()
        {

        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            MyworkorderCell celltwo = null;
            celltwo = tableView.DequeueReusableCell("Allworkordercell") as MyworkorderCell;
            if (celltwo == null)
            {
                var bundel = NSBundle.MainBundle.LoadNib("MyworkorderCell", null, null);
                celltwo = Runtime.GetNSObject(bundel.ValueAt(0)) as MyworkorderCell;
            }
            return celltwo;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 5;
        }
    }
}
