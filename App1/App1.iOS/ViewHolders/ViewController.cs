using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace App1.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;
        string translatedNumber = "";
        public List<string> PhoneNumbers { get; set; }

        public ViewController (IntPtr handle) : base (handle)
		{
            PhoneNumbers = new List<string>();

        }

        public override void ViewDidLoad ()
		{
           // string translatedNumber = "";


            base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				var title = string.Format ("{0} clicks!", count++);
				Button.SetTitle (title, UIControlState.Normal);
			};

          

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            // set the View Controller that’s powering the screen we’re
            // transitioning to

            var callHistoryContoller = segue.DestinationViewController as CallHistoryController;

            //set the Table View Controller’s list of phone numbers to the
            // list of dialed phone numbers

            if (callHistoryContoller != null)
            {
                callHistoryContoller.PhoneNumbers = PhoneNumbers;
            }
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        partial void TranslateButton_TouchUpInside(UIButton sender)
        {
            // Convert the phone number with text to a number
            // using PhoneTranslator.cs
            translatedNumber = PhoneTranslator.ToNumber(PhoneNumberText.Text);

            // Dismiss the keyboard if text field was tapped
            PhoneNumberText.ResignFirstResponder();

            if (translatedNumber == "")
            {
                CallButton.SetTitle("Call", UIControlState.Normal);//uicontrol state to disable to enable button 
                CallButton.Enabled = false;
            }
            else
            {
                CallButton.SetTitle("Call " + translatedNumber, UIControlState.Normal);
                CallButton.Enabled = true;
            }
        }

        partial void CallButton_TouchUpInside(UIButton sender)
        {
            //Store the phone number that we're dialing in PhoneNumbers
            PhoneNumbers.Add(translatedNumber);

            // Use URL handler with tel: prefix to invoke Apple's Phone app...
            var url = new NSUrl("tel:" + translatedNumber);

            // otherwise show an alert dialog
            if (!UIApplication.SharedApplication.OpenUrl(url))
            {
                var alert = UIAlertController.Create("Not supported", "Scheme 'tel:' is not supported on this device", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }

        }
    }
}

