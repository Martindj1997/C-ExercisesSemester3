using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6B_Moon
{
    class AstronautTrip
    {
        public string Name { get; private set; }
        public DateTime Depart { get; }
        public DateTime Arrival { get; }

        public AstronautTrip(string name, DateTime depart)
        {
            Name = name;
            Depart = depart;  //3 days, 8 hours and 30 minutes
            Arrival = Depart.AddDays(3).AddHours(8).AddMinutes(30);
        }

        public override string ToString()
        {
            return $"Astronaut: {Name}, Departure: {Depart}, Arrival: {Arrival}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is AstronautTrip))
                return false;
            //AstronautTrip at = (AstronautTrip)obj;  // old style C cast
            AstronautTrip at = obj as AstronautTrip;  // C# as keyword

            //return (Name == at.Name) && (Depart == at.Depart);  // shorthand way of comparing
            if ((Name == at.Name) && (Depart == at.Depart) && (Arrival == at.Arrival))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
