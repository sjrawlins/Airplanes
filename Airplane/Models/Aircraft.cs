using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane.Models
{
    public enum Manufacturers
    {
        Airbus,
        Boeing,
        Bombardier,  // Canadair Regional Jet
        BritishAerospace,
        Embraer,  // Brazil
    }
    public class Aircraft
    {
        public Manufacturers Maker;
        public string Model;
        public int Capacity;

        public Aircraft(Manufacturers maker, string model, int cap)
        {
            Maker = maker;
            Model = model;
            Capacity = cap;
        }
    }
}
