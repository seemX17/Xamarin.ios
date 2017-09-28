using System;

using UIKit;

namespace Backgrounding
{
    public partial class ViewController : UIViewController
    {
      
        public ViewController(IntPtr handle) : base(handle)
        {
            UIApplication.Notifications.ObserveWillEnterForeground((sender, args) => {
                label.Text = "Welcome back!";
            });
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

       
    }
}