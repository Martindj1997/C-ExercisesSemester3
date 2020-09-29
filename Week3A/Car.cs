using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3A___ModelView
{
    public class Car
    {
        private double fuelAmount;
        private double mileage;

        // automatic properties have private backing fields created by the compiler
        public string Make { get; set; }
        public string Model { get; set; }

        // manual properties require us to provide the private backing fields and are for more
        // complex properties and data validation
        public double FuelAmount 
        {   get { return fuelAmount; } 
              private set {
                if (value > 0)
                    fuelAmount = value;
                else
                    fuelAmount = 0;
              } 
        }
        public double Mileage
        {
            get { return mileage; }
            private set
            {
                if (value > 0)
                    mileage = value;
                else
                    mileage = 0;
            }
        }

        public Car(string make, string model, double fuelAmount, double mileage)
        {
            Make = make;
            Model = model;
            FuelAmount = fuelAmount;
            Mileage = mileage;
        }

        //public string getMake() { return make; }
        //public void setMake(string make) { this.make = make; }
        public double calculateFuelEfficiency() { return FuelAmount/Mileage * 100; }
        public override string ToString()
        {
            return $"[{Make},{Model},Fuel Used={FuelAmount},Mileage={Mileage}," +
                    $"FuelEfficiency={calculateFuelEfficiency()}]";
        }
    }
}
