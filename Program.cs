using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XO Game");
            Console.WriteLine();
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("------------");
            Console.WriteLine(" 6 | 5 | 4 ");
            Console.WriteLine("------------");
            Console.WriteLine(" 7 | 8 | 9 ");

            gameprocess g = new gameprocess();
            Boolean gamewinner = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("X Select number : ");
                String play1 = Console.ReadLine();

                g.set_process1(play1);
                g.show();
                gamewinner = g.CheckWin1();
                if (gamewinner == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player x winer");
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("O Select number : ");
                String play2 = Console.ReadLine();

                g.set_process2(play2);
                g.show();
                gamewinner = g.CheckWin2();
                if (gamewinner == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player o winer");
                    break;
                }
            } while (gamewinner);
        }
    }
}
