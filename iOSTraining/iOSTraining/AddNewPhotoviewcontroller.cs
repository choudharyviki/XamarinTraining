using System;
using System.Threading.Tasks;
using Foundation;
using Plugin.Media;
using UIKit;

namespace iOSTraining
{
    public partial class AddNewPhotoviewcontroller : UIViewController
    {
        int topconstraint = 0;
        UIScrollView scrollView;
       static UIImageView myimage;
        UIImagePickerController imagePicker;
        public AddNewPhotoviewcontroller() : base("AddNewPhotoviewcontroller", null)
        {
        }
        public AddNewPhotoviewcontroller(IntPtr handle) : base(handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            sendmailbtn.Layer.BorderWidth = 0.5f;
            sendmailbtn.Layer.BorderColor = UIColor.Blue.CGColor;
            sendmailbtn.Layer.CornerRadius = 15;
            editbtn.Layer.BorderWidth = 0.5f;
            editbtn.Layer.BorderColor = UIColor.Blue.CGColor;
            editbtn.Layer.CornerRadius = 15;
            NotstartedBtn.Layer.BorderWidth = 0.5f;
            NotstartedBtn.Layer.BorderColor = UIColor.Red.CGColor;
            NotstartedBtn.Layer.CornerRadius = 5;
            HightBtn.Layer.CornerRadius = 5;
            addphotobtn.Layer.CornerRadius = 15;
            scrollView = new UIScrollView();
            scrollView.TranslatesAutoresizingMaskIntoConstraints = false;
            scrollView.ContentSize = new CoreGraphics.CGSize(2000, 110);
            View.Add(scrollView);
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, View, NSLayoutAttribute.Leading, 1.0f, 50).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Top, NSLayoutRelation.Equal, addphotobtn, NSLayoutAttribute.Top, 1.0f, 26).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Trailing, NSLayoutRelation.Equal, View, NSLayoutAttribute.Trailing, 1.0f, 0).Active = true;

            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 110).Active = true;
            NSLayoutConstraint.Create(scrollView, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 2000).Active = true;
         
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void Addphotobtn_TouchUpInside(UIButton sender)
        {
           myimage = new UIImageView();
            myimage.TranslatesAutoresizingMaskIntoConstraints = false;
           // myimage.Image = UIImage.FromFile("abc.jpg");
            myimage.BackgroundColor = UIColor.Red;
            scrollView.Add(myimage);
            NSLayoutConstraint.Create(myimage, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Leading, 1.0f, topconstraint).Active = true;
            NSLayoutConstraint.Create(myimage, NSLayoutAttribute.Top, NSLayoutRelation.Equal, scrollView, NSLayoutAttribute.Top, 1.0f, 20).Active = true;
            NSLayoutConstraint.Create(myimage, NSLayoutAttribute.Height, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
            NSLayoutConstraint.Create(myimage, NSLayoutAttribute.Width, NSLayoutRelation.Equal, multiplier: 1, constant: 90).Active = true;
            topconstraint += 100;
            // PickPhoto();
            // GetImagePath();
            TakePhoto();
        }

        private async Task GetImagePath()
        {
            PhotoPickerService tt = new PhotoPickerService();
            await tt.GetImageStreamAsync();

            var jpegData = NSData.FromFile(tt.path);
            if (jpegData != null)
                myimage.Image = UIImage.LoadFromData(jpegData);
           // var asdf=UIImage.LoadFromData(tt.path);
            //myimage.Image = asdf;
        }

        private async void add()

        {
            //string ss = await PhotoPickerService.path;
           // myimage.Image = await UIImage.FromFile(PhotoPickerService.path);
        }
            //private async void AddImage() // This is your method for your button
        //{
        //    string chosen = await _dialogService.DisplayActionSheetAsync("Which source do you want to use?", "Cancel", null, "Camera", "Galery");
        //    if (chosen == "Camera")
        //    {
        //        TakePhoto();
        //    }
        //    else if (chosen == "Galery")
        //    {
        //        PickPhoto();
        //    }
        //}
        private async void TakePhoto()
        {
            imagePicker = new UIImagePickerController();
            imagePicker.PrefersStatusBarHidden();

            imagePicker.SourceType = UIImagePickerControllerSourceType.Camera;

            //Add event handlers when user finished Capturing image or Cancel
            imagePicker.FinishedPickingMedia += Handle_FinishedPickingMedia;
            imagePicker.Canceled += Handle_Canceled;
           // PresentViewController(picker, true, () => { });
        }

        private void Handle_Canceled(object sender, EventArgs e)
        {
            imagePicker.DismissModalViewController(true);
        }

        private void Handle_FinishedPickingMedia(object sender, UIImagePickerMediaPickedEventArgs e)
        {
            bool isImage = false;
            switch (e.Info[UIImagePickerController.MediaType].ToString())
            {
                case "public.image":
                    Console.WriteLine("Image selected");
                    isImage = true;
                    break;
                case "public.video":
                    Console.WriteLine("Video selected");
                    break;
            }
            NSUrl referenceURL = e.Info[new NSString("UIImagePickerControllerReferenceUrl")] as NSUrl;
            if (referenceURL != null)
                Console.WriteLine("Url:" + referenceURL.ToString());

            // if it was an image, get the other image info
            if (isImage)
            {
                // get the original image
                UIImage originalImage = e.Info[UIImagePickerController.OriginalImage] as UIImage;
                if (originalImage != null)
                {
                    // do something with the image
                    Console.WriteLine("got the original image");
                    myimage.Image = originalImage; // display
                }
            }
            else
            { // if it's a video
              // get video url
                NSUrl mediaURL = e.Info[UIImagePickerController.MediaURL] as NSUrl;
                if (mediaURL != null)
                {
                    Console.WriteLine(mediaURL.ToString());
                }
            }
            // dismiss the picker
            imagePicker.DismissModalViewController(true);
        }
    }
}

