using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3A___ModelView
{
    /// <summary>
    /// This class is the main class in the application and controls the flow of the whole application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method of the class and starting point for this application.  This method controls the application
        /// by loading the cars from the file, creating a view and controlling the view.
        /// </summary>
        /// <param name="args">Optional command line parameters which are not used for this application</param>
        static void Main(string[] args)
        {
            List<Car> myCars = LoadCars();
            //new Car[]
            //{
            //    new Car("Honda", "Civic", 40, 550),
            //    new Car("Ford", "Mustang", 45, 432),
            //    new Car("VW", "Golf", 34, 667),
            //    new Car("Ford", "Focus", 39, 600),
            //    new Car("Chevrolet", "Cruz", 40, 525),
            //    new Car("Dodge", "Charger", 60, 300),
            //};
            if (myCars != null)
            {
                CarView carView = new CarView(myCars);
                carView.ProcessUserSelection();
            }
            else
            {
                Console.WriteLine("Program terminated due to exception.  Click any key to close");
                Console.ReadKey();
            } 

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static List<Car> LoadCars()
        {
            List<Car> myCarList = new List<Car>();
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(@"..\..\cars.txt", FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream) //&& count < myCars.Length)
                {
                    // Read the next line
                    string input = sr.ReadLine();

                    // parse the values
                    string[] values = input.Split(',');
                    string make = values[0];
                    string model = values[1];
                    if (double.TryParse(values[2], out double fuelAmount) == false)
                        Console.WriteLine("Failed to parse the fuelAmount from the file");
                    if (double.TryParse(values[3], out double mileage) == false)
                        Console.WriteLine("Failed to parse the mileage from the file");

                    // create a new car
                    myCarList.Add(new Car(make, model, fuelAmount, mileage));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception loading cars from file due to: {ex.Message}");
                return null;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
                if (sr != null)
                    sr.Close();
            }
            return myCarList;
        }
    }
}
