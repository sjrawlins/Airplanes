using Android.App;
using Android.OS;
using Android.Views;
using iFactr.Core;
using iFactr.Droid;

namespace Airplane.Android
{
    [Activity(MainLauncher = true, WindowSoftInputMode = SoftInput.AdjustPan)]
    public class MainActivity : iFactrActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            if (DroidFactory.TheApp != null)
            {
                base.OnCreate(bundle);
                return;
            }

            DroidFactory.MainActivity = this;
            //Instantiate your iFactr application and set the Factory App property
            DroidFactory.TheApp = new Airplane.MyApp();

            base.OnCreate(bundle);

            iApp.OnLayerLoadComplete += layer => DroidFactory.Instance.OutputLayer(layer);
            iApp.Navigate(iApp.Instance.NavigateOnLoad);

        }
    }
}