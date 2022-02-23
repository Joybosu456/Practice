using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Fibonacci
    {
        public static void Fibonaccinu()
        {
            Console.WriteLine("Please provied ip value :");
            int count = Int32(Console.ReadLine());
            Console.WriteLine(p1 + " " + p2);

            for (int i = 2; i < count; i++)
            {
                p3 = p1 + p2;
                Console.WriteLine(p3);
                p1 = p2;
                p2 = p3;
            }
            Console.WriteLine();
        }
    }
}
