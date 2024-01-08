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
<<<<<<< HEAD
            Console.WriteLine("Please enter a number.");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine();
            for (int i = 0; i < 2 * num + 1; i++)
=======
            for (int i = 0; i < 101; i++)
>>>>>>> main
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
