using System;
using Foundation;
using UIKit;

namespace iOSTraining.Source
{
    public class TableSource:UITableViewSource
    {
        public TableSource()
        {
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("CellIdentifier");
            
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 20;
        }
    }
}
