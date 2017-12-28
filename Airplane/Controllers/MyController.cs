using System.Collections.Generic;
using MonoCross.Navigation;

namespace Airplane.Controllers
{
    public class MyController : MXController<string>
    {
        public override string Load(string uri, Dictionary<string, string> parameters)
        {
            Model = string.Empty;

            // return ViewPerpective based on the state of the Model
            return ViewPerspective.Default;
        }

        public const string Uri = "MyControllerUri";
    }
}