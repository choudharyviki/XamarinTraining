using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using UIKit;

namespace iOSTraining
{
    internal class EmployeeTVS : UITableViewSource
    {
        private List<Employee> employees;

        public EmployeeTVS(List<Employee> employee)
        {
            this.employees = employee;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
           var  cell = (EMployeecell)tableView.DequeueReusableCell("cellid", indexPath);
            var employee = employees[indexPath.Row];
          //cell.Layer.ShadowRadius = 2.0f;
          //  cell.Layer.ShadowColor = UIColor.Red.CGColor;
          //  cell.Layer.ShadowOffset = new CGSize(2, 2);
          //  cell.Layer.ShadowOpacity = 0.80f;
          //  cell.Layer.MasksToBounds = false;

            cell.SetEMployeeData(employee);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
           return employees.Count;
        }
    }
}