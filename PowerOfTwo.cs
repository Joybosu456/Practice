using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PowerOfTwo
    {
        public static void PowerOfTwoCheck()
        {
            int num, power;
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number1 :");
            power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Answer is : " + pow(num, power));
            Console.ReadLine();

        }
        //Recurcive Method
        public static int pow(int num, int power)
        {
            if (power == 0)
                return 1;
            return num * pow(num, --power);
        }
        
    }
    
}
