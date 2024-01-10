using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of liters (l).");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine();
            Console.WriteLine("Please select desired imperial liquid measurement."); Console.WriteLine();
            Console.WriteLine("\"1\" to convert to fluid ounces (fl oz)\n\"2\" to convert to gills (gi)\n\"3\" to convert to pints (pt)\n\"4\" to convert to quarts (qt)\n\"5\" to convert to gallons (gal)\n\"6\" to convert to tablespoons (tbsp)\n\"7\" to convert to teaspoons (tsp)\n\"8\" to convert to cups (c)");
            int to = 0;
            int.TryParse(Console.ReadLine(), out to);
            Console.WriteLine();
            switch (to)
            {
                case 1:
                    Console.WriteLine(num * 35.1951 + " fluid ounces (fl oz)");
                    break;
                case 2:
                    Console.WriteLine(num * 8.45351 + " gills (gi)");
                    break;
                case 3:
                    Console.WriteLine(num * 1.75975 + " pints (pt)");
                    break;
                case 4:
                    Console.WriteLine(num * 0.879877 + " quarts (qt)");
                    break;
                case 5:
                    Console.WriteLine(num * 0.219969 + " gallons (gal)");
                    break;
                case 6:
                    Console.WriteLine(num * 56.3121 + " tablespoons (tbsp)");
                    break;
                case 7:
                    Console.WriteLine(num * 168.936 + " teaspoons (tsp)");
                    break;
                case 8:
                    Console.WriteLine(num * 3.51951 + " cups (c)");
                    break;
                default:
                    Console.WriteLine("Invalid conversion");
                    break;
            }
            Console.ReadKey();
        }
    }
}
