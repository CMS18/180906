using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionLabyrinth
{
    class Labyrinth
    {
        char[,] labyrinth = new char[5,6]
        {
            { ' ', ' ', ' ', 'X', ' ', ' ',},
            { 'X', 'X', ' ', 'X', 'X', ' ',},
            { ' ', ' ', ' ', ' ', ' ', ' ',},
            { 'X', ' ', 'X', 'X', 'X', ' ',},
            { ' ', ' ', ' ', ' ', ' ', 'E',}
        };

        public void FindPathFrom(int row, int col, char dropStone)
        {
            // Kolla att vi inte trillar av brädet
            if (row < 0 || col < 0 ||
                row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1)) return;

            // Kolla om utgång
            if (labyrinth[row, col] == 'E')
            {
                Console.WriteLine("Jag hittade ut!");
                PrintLabyrinth();
                return;
            }

            // Kolla om inte tomt
            if (labyrinth[row, col] != ' ') return;

            labyrinth[row, col] = dropStone;

            FindPathFrom(row - 1, col, '^'); // Uppåt
            FindPathFrom(row, col + 1, '>'); // Höger
            FindPathFrom(row + 1, col, 'v'); // Nedåt
            FindPathFrom(row, col - 1, '<'); // Vänster

            labyrinth[row, col] = ' ';
        }

        public void PrintLabyrinth()
        {
            PrintBorder();
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                Console.Write("|");
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    Console.Write(labyrinth[row, col]);
                }
                Console.WriteLine("|");
            }
            PrintBorder();
        }

        private void PrintBorder()
        {
            Console.Write("+");
            for (int col = 0; col < labyrinth.GetLength(1); col++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
