using System;
using Foundation;
using iOSTraining.Cell;
using ObjCRuntime;
using UIKit;

namespace iOSTraining.Source
{
    public class MyWorkOrderSource: UITableViewSource
    {
        int choice;
        MyworkorderCell celltwo = null;

        AssigneCell cellone = null;
        public MyWorkOrderSource(int ch)
        {
            choice = ch;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            
            if (choice == 0)
            {
                cellone = tableView.DequeueReusableCell("assignecell") as AssigneCell;
                if (cellone == null)
                {
                    var bundel = NSBundle.MainBundle.LoadNib("AssigneCell", null, null);
                    cellone = Runtime.GetNSObject(bundel.ValueAt(0)) as AssigneCell;
                }

                // cell.Name = "Xib table view";
            }
            else if (choice == 1)
            {
                celltwo = tableView.DequeueReusableCell("Allworkordercell") as MyworkorderCell;
                if (celltwo == null)
                {
                    var bundel = NSBundle.MainBundle.LoadNib("MyworkorderCell", null, null);
                    celltwo = Runtime.GetNSObject(bundel.ValueAt(0)) as MyworkorderCell;
                }

                //cell.Name = "Xib table view";

            }
            if (choice == 0)
                return cellone;
            else
                return celltwo;
        }


        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 5;
        }
    }
}
