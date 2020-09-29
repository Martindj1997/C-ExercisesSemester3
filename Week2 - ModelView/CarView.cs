using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2___ModelView
{
    class CarView
    {
        private Car[] cars;
        public CarView(Car[] cars)
        {
            this.cars = cars;
        }

        public bool ProcessUserSelection()
        {
            DisplayMenu();

            while (true)
            {
                string input = Console.ReadLine();
                Console.Clear();
                if ((int.TryParse(input, out int userSelection) == false) ||
                    userSelection < 1 || userSelection > 4)
                {
                    Console.WriteLine("Input invalid.  Please enter a value between 1 and 4.");
                    continue;
                }
                if (userSelection == 1)
                    DisplayAll();
                else if (userSelection == 2)
                    DisplayBestMileage();
                else if (userSelection == 3)
                    DisplayMake("Ford");
                else // userSelection must be 4, so exit
                    break;

                DisplayMenu();
            }
            return true;
        }

        private void DisplayMenu()
        {
            Console.WriteLine("CAR APPLICATION");
            Console.WriteLine("===============");
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Display all of the Cars");
            Console.WriteLine("2 - List car with best Mileage");
            Console.WriteLine("3 - List all Cars from Ford");
            Console.WriteLine("4 - Exit application");
            Console.WriteLine("\n Enter Option");
        }

        private void DisplayMake(string make)
        {
            // for (int i = 0; i < cars.Length; i++)
            foreach (Car car in cars)
            {
                if (car.getMake() == make)
                    Console.WriteLine(car);
            }
        }

        private void DisplayBestMileage()
        {
            //int count = 0, 
            int minIndex = 0;
            double min = cars[0].calculateFuelEfficiency();
            for (int i = 0; i < cars.Length; i++)
            {
                double fuelEfficiency = cars[i].calculateFuelEfficiency();
                if (fuelEfficiency < min)
                {
                    min = fuelEfficiency;
                    minIndex = i;
                }
            }

            Console.WriteLine(cars[minIndex]);
        }

        private void DisplayAll()
        {
            foreach (Car car in cars)
               Console.WriteLine(car);
        }
    }
}
