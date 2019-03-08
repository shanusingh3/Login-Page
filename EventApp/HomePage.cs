using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace EventApp
{
    public partial class HomePage : UIViewController
    {
        public HomePage()
        {
          
        }

        public HomePage (IntPtr handle) : base (handle)
        {
        }

        void LabelUI()
        {
           
        }

        public override void ViewDidLoad()
        {
            Console.WriteLine("Excecuted");
            LabelUI();

        }
        }
}