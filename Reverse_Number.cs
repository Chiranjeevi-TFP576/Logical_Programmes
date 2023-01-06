using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programme_Day6
{
    public class Reverse_Number
    {
        public static void CheckReverse()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a Number");//432
            n = Convert.ToInt32(Console.ReadLine());
            while (n!=0)
            {
                rem = n % 10;//reminder
                reverse = reverse * 10 + rem;
                n = n / 10;//quotient

            }
            Console.WriteLine("Reverse Number is "+reverse);
        }
    }
}
