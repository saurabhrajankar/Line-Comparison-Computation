using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_CalculateLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taking the user inputs for co-ordinates of line 
            Console.WriteLine("Enter coordinate of line\n" + "Enter x1 point");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 point");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 point");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 point");
            int y2 = Convert.ToInt32(Console.ReadLine());


            //computing the length of line 1
            double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine($"Length of line ( {x1},{y1} ),( {x2},{y2} ) = {length}");
            Console.ReadLine();
        }
    }
}
