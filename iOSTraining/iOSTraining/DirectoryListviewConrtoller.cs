using System;
using System.Collections.Generic;
using iOSTraining.Source;
using UIKit;

namespace iOSTraining
{
    public partial class DirectoryListviewConrtoller : UIViewController
    {
        public DirectoryListviewConrtoller() : base("DirectoryListviewConrtoller", null)
        {
        }
        public DirectoryListviewConrtoller(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            var employee = new List<Employee> {
            {
                new Employee{ EmployeeName="Himansu Arora", EmployeeVendor="Vendor-Electricity"}
            },
            {
                new Employee { EmployeeName = "Johan ", EmployeeVendor = "Vendor-Engineer" }
            },
            {
                new Employee { EmployeeName = "lizies", EmployeeVendor = "Vendor-Teacher" }
            },
            {
                new Employee { EmployeeName = "Harry", EmployeeVendor = "Vendor-Driver" }
            },
            {
                new Employee { EmployeeName = "Bond", EmployeeVendor = "Vendor-Actor" }
            }
            };
            table.Source = new EmployeeTVS(employee);
            table.SeparatorStyle = UITableViewCellSeparatorStyle.None;

            //table.RowHeight = UITableView.AutomaticDimension;
            // table.EstimatedRowHeight = 40;
            //table.ReloadData();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

