using System;
using System.Json;
using Foundation;
using UIKit;
using Xamarin.Auth;

namespace iOSTraining
{
    public partial class FacebookVIewCOntroller : UIViewController
    {
        public FacebookVIewCOntroller() : base("FacebookVIewCOntroller", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
        public FacebookVIewCOntroller(IntPtr handle) : base(handle)
        {
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton481609_TouchUpInside(UIButton sender)
        {
            var auth = new OAuth2Authenticator(clientId: "454940485435451",
                scope: "",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("https://www.facebook.com/connect/login_success.html"));
            auth.Completed += auth_complete;
            var ui = auth.GetUI();
            PresentViewController(ui, true, null);

        }
        private async void auth_complete(object sender, AuthenticatorCompletedEventArgs e)
        {
            if(e.IsAuthenticated)
            {
                var request = new OAuth2Request("GET", new Uri("https://graph.facebook.com/me?fields=name,picture"), null, e.Account);
                var fbresponse = await request.GetResponseAsync();
                var fbuser = JsonValue.Parse(fbresponse.GetResponseText());
                var name = fbuser["name"];
                var id = fbuser["id"];
                var pic = fbuser["picture"]["data"]["url"];
               
                // var coverphoto = fbuser["cover"]["source"];
               // Fcoverpageimage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(coverphoto)));
                myprofileimage.Image = UIImage.LoadFromData(NSData.FromUrl(new NSUrl(pic)));
                Nameofuser.Text = name;
                fbid.Text = id;
            }
            DismissViewController(true, null);
        }
    }
}

