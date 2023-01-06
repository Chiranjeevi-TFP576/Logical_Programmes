using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programme_Day6
{
    public class Prime_Number
    {
        public static void CheckPrime()
        {
            int n, prime = 0;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime++;
                }
            }
                if(prime == 2)
                {
                    Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
            
        }
    }
}
