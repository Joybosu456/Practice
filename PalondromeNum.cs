using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PalondromeNum
    {
        public static void PalnNumber()
        {
            Console.WriteLine("Please provide your Input number:=");
            int input=Convert.ToInt32(Console.ReadLine());

            int backup = input;
            int remainder, revarse = 0;

            while(input > 0)
            {
                remainder = input % 10;
                revarse = revarse * 10 + remainder;
                input = input / 10;
            }
            if(backup==revarse)
            {
                Console.WriteLine(backup + "is a palondrom number");
            }
            else
            {
                Console.WriteLine(backup + "is not a palondrom number");
            }
        }
    }
}
