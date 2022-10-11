using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_Using_Classes
{    
    internal class Line
    {
        public static double length1;
        public static double length2;
        public static int x1, x2, x3, x4;
        public static int y1, y2, y3, y4;
        public static void Main(String[] args)
        {
            input();
            checkEquality();
            compare();
        }
        public static void input()
        {
            //taking the user inputs for co - ordinates of line 1
            Console.WriteLine("Enter coordinate of line-1\n" + "Enter x1 point");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 point");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1 point");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2 point");
            y2 = Convert.ToInt32(Console.ReadLine());
            //computing the length of line 1
            length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            //taking the user inputs for co-ordinates of line 2
            Console.WriteLine("Enter coordinate of line-2\n" + "Enter x3 point");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x4 point");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y3 point");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y4 point");
            y4 = Convert.ToInt32(Console.ReadLine());
            //computing the length of line 2
            length2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            //printing the lengths of lines
            Console.WriteLine($"Length of line-1 ( {x1},{y1} ),( {x2},{y2} ) = {length1}");
            Console.WriteLine($"Length of line-2 ( {x3},{y3} ),( {x4},{y4} ) = {length2}");
            Console.ReadLine();
        }
        public static void checkEquality()
        {
            if (length1 == (length2))
            {
                Console.WriteLine("Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("Both Lines are not Equal");
            }
            Console.ReadLine();
        }
        public static void compare()
        {
            if (length1.CompareTo(length2) == 0)

            {
                Console.WriteLine("Both lines are equal");
            }
            else if (length1.CompareTo(length2) == 1)
            {
                Console.WriteLine("Line1 is greater");
            }
            else if (length1.CompareTo(length2) == -1)
            {
                Console.WriteLine("Line2 is greater");
            }
            Console.ReadLine();
        }

    }

}
