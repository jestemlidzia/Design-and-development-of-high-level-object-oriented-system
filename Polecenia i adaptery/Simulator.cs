using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Adapter
{
    class Simulator
    {
        private Move currentMove;
        private int hour;
        private List<char> moves;

        public Simulator(int h)
        {
            hour = h;
            moves = new List<char>();
        }

        public void Memorize()
        {
            Console.WriteLine("Press W if you want to go north.");
            Console.WriteLine("Press A if you want to go west.");
            Console.WriteLine("Press S if you want to go south.");
            Console.WriteLine("Press D if you want to go east.");
            Console.WriteLine("Press E if you want to go undo the move.");
            Console.WriteLine("Press R if you want to finish entering clues.");

            ConsoleKeyInfo move;

            do
            {
                move = Console.ReadKey();

                if (move.Key == ConsoleKey.W) moves.Add('W');
                if (move.Key == ConsoleKey.S) moves.Add('S');
                if (move.Key == ConsoleKey.A) moves.Add('A');
                if (move.Key == ConsoleKey.D) moves.Add('D');

                Console.Write(" ");

                if (move.Key == ConsoleKey.E)
                {
                    if (moves.Any())
                    {
                        Console.WriteLine($"\nRemoving {moves[moves.Count - 1]}...");
                        moves.RemoveAt(moves.Count - 1);
                    }
                }

            } while (move.Key != ConsoleKey.R);

            Console.WriteLine("\n");
            //moves.ForEach(Console.WriteLine);
            Execute();
        }

        public void Execute()
        {
            using (TextWriter tw = new StreamWriter("test.txt"))
            {
                foreach (char s in moves)
                    tw.WriteLine(s);
            }
            foreach (char element in moves)
            {
                switch (element)
                {
                    case 'A':
                        currentMove = new MoveWest();
                        currentMove.Execute(hour);
                        break;
                    case 'W':
                        currentMove = new MoveNoth();
                        currentMove.Execute(hour);
                        break;
                    case 'D':
                        currentMove = new MoveEast();
                        currentMove.Execute(hour);
                        break;
                    case 'S':
                        currentMove = new MoveSouth();
                        currentMove.Execute(hour);
                        break;
                
                }
                hour++;
            }
        }
    }
}
