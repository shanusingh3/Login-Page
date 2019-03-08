using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace EventApp
{
    public partial class ViewController : UIViewController
    {
        
        static CGRect ScreenDimension = UIScreen.MainScreen.Bounds;
        nfloat X = ScreenDimension.Size.Width;
        nfloat Y = ScreenDimension.Size.Height;
       
        UILabel Label;
        UILabel PassLabel;
        UITextField PassField;

        void BackGroundImage()
        {
            //var BackgroundImage = UIImage.FromFile("Images/Girl.jpeg");
            //SubView.Layer.Contents = BackgroundImage.CGImage;
        }
        void LogoAndLabel()
        {
            
            CGRect LogoFrame = new CGRect(X,Y,500,500);
            UIImageView Logo = new UIImageView(LogoFrame);

            Logo.Center = new CGPoint(View.Frame.Size.Width / 2, View.Frame.Size.Height / 6);
            Logo.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            Logo.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;

            var ImageFile = UIImage.FromFile("Images/Circle.png");
            Logo.Layer.Contents = ImageFile.CGImage;


            CGRect LabelFrame = new CGRect(X, Y, 250, 100);
            Label = new UILabel(LabelFrame);
            Label.Text = "Shanu Singh";
            //Label.Font = Label.Font.WithSize(5.0f);
            Label.Font = UIFont.FromName("GillSans-Bold", 25.0f);
            Label.TextColor = UIColor.Black;
            Label.TextAlignment = UITextAlignment.Center;

            Label.Center = new CGPoint(View.Frame.Size.Width / 2, Logo.Frame.GetMaxY());
            Label.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            Label.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;

            SubView.AddSubview(Logo);
            SubView.AddSubview(Label);

        }

        void TextField()
        {
            var EmailFrame = new CGRect(X, Y, ScreenDimension.Width/2, 40);
            UITextField SignIn = new UITextField(EmailFrame);
            SignIn.BackgroundColor = UIColor.White;
           
            //Centre Alignment of the TextField
            SignIn.Center = new CGPoint(View.Frame.Size.Width / 2, Label.Frame.GetMaxY()+100);
            SignIn.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            SignIn.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;
            //
            //Bottom Line of the Text Field - Start//
            SignIn.Layer.ShadowColor = UIColor.Yellow.CGColor;
            SignIn.Layer.ShadowOffset = new CGSize(0.0f, 1.0f);
            SignIn.Layer.ShadowOpacity = 1.0f;
            SignIn.Layer.ShadowRadius = 0.0f;
            //End

            //Email Label In TextField
            CGRect IconFrame = new CGRect(SignIn.Frame.GetMinX(), SignIn.Frame.GetMinY()-26, 100, 25);
            UILabel EmailLabel = new UILabel(IconFrame);
            EmailLabel.Text = "Email";
            EmailLabel.TextColor = UIColor.Black;
            

            //PlaceHolder
            SignIn.Placeholder = "Enter Username";

            //


            //PassWord
            var PassFrame = new CGRect(X, Y, ScreenDimension.Width / 2, 40);
            PassField = new UITextField(PassFrame);
            PassField.BackgroundColor = UIColor.White;

            //Centre Alignment of the TextField
            PassField.Center = new CGPoint(View.Frame.Size.Width / 2, SignIn.Frame.GetMaxY()+50);
            PassField.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            PassField.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;
            //
            //Bottom Line of the Text Field - Start//
            PassField.Layer.ShadowColor = UIColor.Yellow.CGColor;
            PassField.Layer.ShadowOffset = new CGSize(0.0f, 1.0f);
            PassField.Layer.ShadowOpacity = 1.0f;
            PassField.Layer.ShadowRadius = 0.0f;
            //End

            //PlaceHolder
            PassField.Placeholder = "Enter Password";

            //

            // Email Label In TextField
            CGRect PassLabelFrame = new CGRect(PassField.Frame.GetMinX(), PassField.Frame.GetMinY() - 26, 100, 25);
            PassLabel = new UILabel(PassLabelFrame);
            PassLabel.Text = "Password";
            PassLabel.TextColor = UIColor.Black;
            

            SubView.AddSubview(SignIn);
            SubView.AddSubview(EmailLabel);
            SubView.AddSubview(PassField);
            SubView.AddSubview(PassLabel);


        }


        void Button()
        {
            CGRect ButtonFrame = new CGRect(X, Y, 120, 40);
            UIButton LoginButton = new UIButton(ButtonFrame);

            LoginButton.Center = new CGPoint(View.Frame.Size.Width / 2, PassField.Frame.GetMaxY()+45);
            LoginButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            LoginButton.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;

            LoginButton.Layer.BackgroundColor = UIColor.White.CGColor;
            LoginButton.SetTitle("Login", UIControlState.Normal);
            LoginButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            LoginButton.Layer.BorderColor = UIColor.Yellow.CGColor;            
            LoginButton.Layer.CornerRadius = 25.0f;
            LoginButton.Layer.BorderWidth = 3;
            LoginButton.Layer.MasksToBounds = true;
        
            

            CGRect SignUpFrame = new CGRect(X, Y, 100, 20);
            UIButton SignUpButton = new UIButton(SignUpFrame);
            SignUpButton.SetTitle("Sign Up", UIControlState.Normal);
            SignUpButton.Layer.BorderWidth = 0f;
            SignUpButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            SignUpButton.Font = UIFont.SystemFontOfSize(10.0f);

            SignUpButton.Center = new CGPoint(View.Frame.Size.Width / 2, LoginButton.Frame.GetMaxY()+20);
            SignUpButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            SignUpButton.AutoresizingMask = UIViewAutoresizing.FlexibleHeight;

            LoginButton.TouchUpInside += LoginButton_TouchUpInside;
           

            SubView.AddSubview(LoginButton);
            SubView.AddSubview(SignUpButton);

        }

        private void LoginButton_TouchUpInside(object sender, EventArgs e)
        {

            //UIStoryboard storyboard = UIStoryboard.FromName("Application", null);

            //HomeViewController controller =
            //    (HomeViewController)storyboard.InstantiateViewController("HomeViewController");
            
            NavigationController.PushViewController(new HomePage(), true);
            NavigationController.NavigationBarHidden = true;
            Console.WriteLine("Clicked");
        }

        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            BackGroundImage();
            LogoAndLabel();
            TextField();
            Button();
            this.NavigationController.NavigationBarHidden = true;

        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}