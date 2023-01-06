using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programme_Day6
{
    internal class Perfect_Number
    {
        public static void Check_Number_Perfect()
        {
            int n = 0, sum = 0;
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<n;i++)
            {
                if(n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n==sum)
            {
                Console.WriteLine("{0}: Perfect Number",n);
            }
            else
            {
                Console.WriteLine("{0}: is Not a PerfectNumber",n);
            }

        }
    }
}
