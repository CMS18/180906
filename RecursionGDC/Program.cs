using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionGDC
{
    class Program
    {
        static int GreatestCommonDivisor(int value1, int value2)
        {

            if (value2 == 0) return value1;

            return GreatestCommonDivisor(value2, value1 % value2);
        }

        static int GreatestCommonDivisorWithNoRecursion(int value1, int value2)
        {
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                {
                    value1 = value1 % value2;
                }
                else
                {
                    value2 = value2 % value1;
                }
            }

            return value1 == 0 ? value2 : value1;

        }


        static void Main(string[] args)
        {
            //int devisor = GreatestCommonDivisor(345, 150);
            int devisor = GreatestCommonDivisorWithNoRecursion(345, 150);

            Console.WriteLine("Devisor: " + devisor);
        }

    }
}
