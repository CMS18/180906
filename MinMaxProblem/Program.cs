using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxProblem
{
    class Program
    {
        static void HittaLägstaOchHögstaTal(int tal1, int tal2, int tal3, out int lägstaTalet, out int högstaTalet)
        {

            högstaTalet = 0;
            return 0;
        }


        static void Main(string[] args)
        {
            int min;
            int max;

            HittaLägstaOchHögstaTal(5, 3, 7, högstaTalet: out max, lägstaTalet: out min);

            Console.WriteLine("Lägst: "+ min);

            Console.WriteLine("Högst: " + max);

        }
    }
}
