using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using iFactr.Core;
using MonoCross.Navigation;
using Airplane.Views;
using Airplane.Controllers;
using Airplane.Models;
using MonoCross.Utilities;

namespace Airplane
{
    public class MyApp : iApp
    {
        // Add code to initialize your application here.  For more information, see http://support.ifactr.com/
        public override void OnAppLoad()
        {
            // Set the application title
            Title = "Airplanes";
            //FormFactor = FormFactor.Fullscreen;
            Device.Log.LoggingLevel = MonoCross.Utilities.Logging.LoggingLevel.Debug;

            string appPath = Device.ApplicationPath;
            string dataPath = Device.DataPath;

            // Optional: Set the application style
            // Example Style.HeaderColor = new Color(0, 0, 0);

            // Add navigation mappings
            NavigationMap.Add(MyController.Uri, new MyController());
            NavigationMap.Add("ListView", new ListViewController());

            // Add Views to ViewMap
            MXContainer.AddView<string>(typeof(MyGridView));
            MXContainer.AddView<List<Aircraft>>(typeof(MyListView));

            // Set default navigation URI
            NavigateOnLoad = MyController.Uri;

        }
    }
}
