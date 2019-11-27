using Foundation;
using iOSTraining.Model;
using System;
using UIKit;

namespace iOSTraining
{
    public partial class AllcontrolsControllers : UIViewController
    {
        public AllcontrolsControllers (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            NavigationItem.HidesBackButton = true;
            BackImage.UserInteractionEnabled = true;
            UITapGestureRecognizer tapgesture = new UITapGestureRecognizer(Tap);
            BackImage.AddGestureRecognizer(tapgesture);
        }

        private void Tap()
        {
            PerformSegue("GoToHomeSegue", this);
        }

        partial void SubmitButton_TouchUpInside(UIButton sender)
        {

            var info = ApiHelper.GetAsync();
            string password = PasswordTextFiels.Text;
            string resetPassword = ResetPasswordTextFiels.Text;
            //if(!string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(resetPassword))
            //{
            //    if (password.Length < 8 || resetPassword.Length < 8)
            //        ErrorMesage.Text = "Password length should 8 digit...";
            //    else
            //    {
            //        ErrorMesage.Text = "Password reset successfully";
            //        ErrorMesage.TextColor = UIColor.Green;
            //        PasswordTextFiels.Text = string.Empty;
            //        ResetPasswordTextFiels.Text = string.Empty;
            //     }
            //}
            //else
            //{
            //    ErrorMesage.Text = "Please fill both field...";
            //}
        }
    }
}