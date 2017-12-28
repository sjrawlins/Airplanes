using System;
using System.Collections.Generic;
using System.Linq;
using Airplane.Models;
using MonoCross.Navigation;

namespace Airplane.Controllers
{
    public class ListViewController : MXController<List<Aircraft>>
    {

        private List<Aircraft> _aircraftDirectory = new List<Aircraft>
            {
                new Aircraft(Manufacturers.Airbus, "A319", 132),
                new Aircraft(Manufacturers.Airbus, "A320", 150),
                new Aircraft(Manufacturers.Airbus, "A330-200", 234),
                new Aircraft(Manufacturers.Airbus, "A330-300", 293),
                new Aircraft(Manufacturers.Airbus, "A330-300", 293),
                new Aircraft(Manufacturers.Airbus, "A330 MRTT", 0),
                new Aircraft(Manufacturers.Airbus, "A380", 525),
                new Aircraft(Manufacturers.Boeing, "717-200", 110),
                new Aircraft(Manufacturers.Boeing, "737-700", 124),
                new Aircraft(Manufacturers.Boeing, "737-800", 160),
                new Aircraft(Manufacturers.Boeing, "737-900ER", 180),
                new Aircraft(Manufacturers.Boeing, "737-800BCF", 0),
                new Aircraft(Manufacturers.Boeing, "747-200", 180),
                new Aircraft(Manufacturers.Boeing, "747-400", 416),
                new Aircraft(Manufacturers.Boeing, "747-400F", 0),
                new Aircraft(Manufacturers.Boeing, "747-8F", 0),
                new Aircraft(Manufacturers.Boeing, "757-200", 193),
                new Aircraft(Manufacturers.Boeing, "757-300", 234),
                new Aircraft(Manufacturers.Boeing, "767-300", 261),
                new Aircraft(Manufacturers.Boeing, "767-300ER", 211),
                new Aircraft(Manufacturers.Boeing, "767-400ER", 246),
                new Aircraft(Manufacturers.Boeing, "767F", 0),
                new Aircraft(Manufacturers.Boeing, "777", 291),
                new Aircraft(Manufacturers.Boeing, "777F", 0),
                new Aircraft(Manufacturers.Boeing, "787-8", 242),
                new Aircraft(Manufacturers.Boeing, "787-9", 280),
                new Aircraft(Manufacturers.Boeing, "787-10", 310),
                new Aircraft(Manufacturers.Boeing, "787", 330),
                new Aircraft(Manufacturers.Boeing, "MD-88", 149),
                new Aircraft(Manufacturers.Boeing, "MD-90", 158),
                new Aircraft(Manufacturers.Bombardier, "CRJ-200", 50),
                new Aircraft(Manufacturers.Bombardier, "CRJ-700", 9999),
                new Aircraft(Manufacturers.Bombardier, "CRJ-900", 76),
                new Aircraft(Manufacturers.BritishAerospace, "146", 70),
                new Aircraft(Manufacturers.BritishAerospace, "RJ", 70),
                new Aircraft(Manufacturers.Embraer, "ERJ-170", 66),
                new Aircraft(Manufacturers.Embraer, "ERJ-175", 76),
                new Aircraft(Manufacturers.Embraer, "ERJ-190", 100),
                new Aircraft(Manufacturers.Embraer, "ERJ-195", 100),
            };
        public override string Load(string uri, Dictionary<string, string> parameters)
        {
            Model = _aircraftDirectory;
            if (parameters.ContainsKey("Freighters"))
            {
                if (parameters["Freighters"] == "true")
                {
                    Model = _aircraftDirectory.Where(ac => ac.Capacity == 0).ToList();
                }
            }
 

            // return ViewPerpective based on the state of the Model
            return ViewPerspective.Default;

        }

        public const string Uri = "ListViewControllerUri";
    }
}