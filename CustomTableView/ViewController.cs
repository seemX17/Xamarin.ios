using System;

using UIKit;

namespace CustomTableView
{
    public partial class ViewController : UITableViewController
    {
       
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var states = tableRepository.GetStates();

            tableview1.Source = new MyTableViewSource(states);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            if (UIDevice.CurrentDevice.CheckSystemVersion(7, 0))

            {
                this.TableView.ContentInset = new UIEdgeInsets(this.TopLayoutGuide.Length, 0, 0, 0);
            }
        }
    }
}


//var conferences = ConferenceRepository.GetConferences();

//TableView.Source = new MyTableViewSource(conferences);
//		}

//		public override void ViewDidLayoutSubviews()
//{
//    base.ViewDidLayoutSubviews();

//    if (UIDevice.CurrentDevice.CheckSystemVersion(7, 0))
//    {
//        this.TableView.ContentInset = new UIEdgeInsets(this.TopLayoutGuide.Length, 0, 0, 0);
//    }
//}