using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express! Please follow the instructions below.");

            Console.WriteLine("Please enter package weight in lbs.:");

            int weight = Int32.Parse(Console.ReadLine());


            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                return;
            }

            else
            {
                Console.WriteLine("\nPlease enter package dimensions:\n\n Width:");
                int width = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Height:");
                int height = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Length:");
                int length = Int32.Parse(Console.ReadLine());

                int totalDimension = width + height + length;


                if (totalDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    return;
                }
                else
                {
                    int size = width * height * length;
                    decimal Quote = (size * weight) / 100;
                    Console.WriteLine("Your estimated shipping cost is: " + Quote.ToString("C"));
                    Console.WriteLine("\n \n Thank you for your Business! ");
                }
            }
            Console.ReadLine();
        }
    }
}
