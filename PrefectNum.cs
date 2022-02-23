using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PrefectNum
    {
        public static void PerfectNumberFind()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the perfect number within given number");
            Console.WriteLine("*************************");
            Console.WriteLine("input the range or num");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the endingrange or num");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the perfect Number Whitin the given number");

            for( n = mn; n < mx; n ++)
            {
                i = 1;
                sum = 0;

                while( i < n )
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write(" {0} ", n);
            }
        }
    }
}
