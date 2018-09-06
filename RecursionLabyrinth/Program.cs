using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionLabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            Labyrinth lab = new Labyrinth();

            lab.PrintLabyrinth();
            lab.FindPathFrom(0, 0, 'S');

        }
    }
}
