using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class carpetFitting
    {
        private const double travelCost = 0.45;
        private const double fittingCost = 3.25;

        private double totalCostOfAllFittings = 0;
        private int numberOfFittings = 0;

        public carpetFitting()
        {

        }

        //getter
        public double getTravelCost()
        {
            return travelCost;
        }
        public double getFittingCost()
        {
            return fittingCost;
        }

        public void askForInformation()
        {
            double km = 0, carpetSize = 0;
            bool more = true;
            int num = 0;

            Console.WriteLine("Carpet fitting cost calculator\n");
            
            while (more)
            {
                Console.WriteLine("Give distance in km:");
                while (!double.TryParse(Console.ReadLine(), out km))//as long as it's not double ask again
                {
                    Console.WriteLine("Input a number!");
                }
                Console.WriteLine("Give the carpet size:");
                while (!double.TryParse(Console.ReadLine(), out carpetSize))
                {
                    Console.WriteLine("Input a number!");
                }
                Console.WriteLine("Cost of fitting: " + calculateCostOfFitting(km, carpetSize) + "\n");
                Console.WriteLine("Add another carpet? 0 = yes, 1 = no");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Input 0 or 1!");
                }
                if(num == 0)
                {
                    more = true;
                }
                else
                {
                    more = false;
                }
            }
            totalCostAndAverageCost();            
        }

        public double calculateCostOfFitting(double km, double area)
        {
            double travel = travelCost * km;
            double fitting = fittingCost * area;
            numberOfFittings++;
            totalCostOfAllFittings += travel + fitting;
            double total = travel + fitting;

            if (total <= 250)//discount if over 250
            {
                total *= .9f;
            }

            return total;
        }

        public void totalCostAndAverageCost()
        {
            Console.WriteLine("Cost of all fittings: " + totalCostOfAllFittings);
            Console.WriteLine("Average cost: " + totalCostOfAllFittings / numberOfFittings + "\n");
        }
    }
}
