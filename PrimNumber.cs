using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PrimNumber
    {
        public static void PrimeNUmCheck()
        {
            Console.WriteLine("Please enter number :");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                int flag = 0;
                for (int i = 2; i < number; i++)
                {
                    if (number / i == 0)
                    
                        Console.WriteLine({ 0} "is not prime number");
                   flag = 1;
                   break;
            }
            
                
            
        }
    }
}
