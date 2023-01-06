using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programme_Day6
{
    public class Fibonacci_Series
    {
        public static void CheckFibonacci()//lets take 2->0+1=1,1+1=2
        {
            Console.WriteLine("Enter two number for checking Febonacci");
            int n1, n2, count;
            Console.WriteLine("Enter a N1 Value" );
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a N1 Value");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter febonacci count value");
            count = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=count;i++)
            {
                int n3 = n1 + n2;
                Console.WriteLine(""+n3);
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
