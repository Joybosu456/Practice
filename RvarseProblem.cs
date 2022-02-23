using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class RvarseProblem
    {
        public static void Practice1()
        {
            Console.WriteLine("Plese enter your Input:=");
            int input=Convert.ToInt32(Console.ReadLine());

            int reminder, revarse = 0;
            while(input>0)
            {
                reminder = input % 10;
                revarse = revarse * 10 + reminder;
                input = input / 10;
            }
            Console.WriteLine("revarse number is" +revarse);
        }
    }
}
