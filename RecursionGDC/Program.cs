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


        static void Main(string[] args)
        {
            int devisor = GreatestCommonDivisor(345, 150);

            Console.WriteLine("Devisor: " + devisor);
        }

    }
}
