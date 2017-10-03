using CoreLocation;
using System;

using UIKit;

namespace Location
{
    public partial class ViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            // It is better to handle this with notifications, so that the UI updates
            // resume when the application re-enters the foreground!
            Manager.LocationUpdated += HandleLocationChanged;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region Computed Properties
        public static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public static LocationManager Manager { get; set; }
        #endregion

        #region Constructors
        public ViewController(IntPtr handle) : base(handle)
        {
            // As soon as the app is done launching, begin generating location updates in the location manager
            Manager = new LocationManager();
          //  Manager.StartLocationUpdates();
        }

        #endregion

        #region Public Methods
        public void HandleLocationChanged(object sender, LocationUpdatedEventArgs e)
        {
            // Handle foreground updates
            CLLocation location = e.Location;

            LblAltitude.Text = location.Altitude + " meters";
            LblLongitude.Text = location.Coordinate.Longitude.ToString();
            LblLatitude.Text = location.Coordinate.Latitude.ToString();
            LblCourse.Text = location.Course.ToString();
            LblSpeed.Text = location.Speed.ToString();

            Console.WriteLine("foreground updated");
        }

        #endregion
    }
}