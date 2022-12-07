using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_Final
{
    public class Owner
    {
        //Fields
        string _name;
        public List<Car> cars = new List<Car>();

        //Constructor (only take in name)
        public Owner(string name)
        {
            _name = name;
        }

        //Properties (no set for list)
        public string Name { get => _name; set => _name = value; }
        public List<Car> Cars { get => cars; }

        //Simple method to add car, meant to be called for adding cars to specific owners
        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        //Method to calculate average mileage of cars specifically associated with owners
        public double AverageMileage()
        {
            //Declare sum and average variables (sum starts at 0 so it can be added to)
            double sum = 0;
            double average;

            //Loop to cycle through cars list
            for (int i = 0; i < Cars.Count; i++)
            {
                //Adds mileage of car at index and uses += to add to previous total
                sum += Cars[i].Mileage;
            }

            //Calculates average by dividing sum after loop by the count of cars in list
            average = sum / Cars.Count;

            //Return the average
            return average;
        }
    }
}
