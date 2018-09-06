using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxProblem
{
    class Program
    {
        static void HittaLägstaOchHögstaTal(int tal1, int tal2, int tal3, 
                                            out int lägstaTalet, out int högstaTalet)
        {
            if (tal1 >= tal2 && tal1 >= tal3)
            {
                högstaTalet = tal1;
            }
            else if (tal2 >= tal1 && tal2 >= tal3)
            {
                högstaTalet = tal2;
            }
            else 
            {
                högstaTalet = tal3;
            }

            if (tal1 <= tal2 && tal1 <= tal3)
            {
                lägstaTalet = tal1;
            }
            else if (tal2 <= tal1 && tal2 <= tal3)
            {
                lägstaTalet = tal2;
            }
            else
            {
                lägstaTalet = tal3;
            }
        }

        static void HittaLägstaOchHögstaTal2(int tal1, int tal2, int tal3,
                                             out int lägstaTalet, out int högstaTalet)
        {
            högstaTalet = (tal1 >= tal2) ? 
                            (tal1 >= tal3 ? tal1 : tal3) : 
                            (tal2 >= tal3 ? tal2 : tal3);

            lägstaTalet = (tal1 <= tal2) ? tal1 : tal2;
            lägstaTalet = (lägstaTalet <= tal3) ? lägstaTalet : tal3;
        }

        static void HittaLägstaOchHögstaTal3(int tal1, int tal2, int tal3,
                                             out int lägstaTalet, out int högstaTalet)
        {
            högstaTalet = Math.Max(tal1, Math.Max(tal2, tal3));

            lägstaTalet = Math.Min(tal1, Math.Min(tal2, tal3));
        }


        static void Main(string[] args)
        {
            int min;
            int max;

            HittaLägstaOchHögstaTal2(1, 3, 7, högstaTalet: out max, lägstaTalet: out min);

            Console.WriteLine("Lägst: "+ min);

            Console.WriteLine("Högst: " + max);

        }
    }
}
