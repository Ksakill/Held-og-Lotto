using System;
using System.Threading;

namespace Held_og_Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp; 
            int[] Mylotto = new int[8];

            Random random = new Random(); 

            for (int i = 0; i < 8; i++)
            {
                temp = random.Next(1, 36);
                Mylotto[i] = temp;
            }

            Console.Write($"Lotto nummerne er: ");

            for (int i = 0; i < 8; i++)
            {
                if (i == 7) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Mylotto[i] + " ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(Mylotto[i] + " ");
                }

                Thread.Sleep(2000); 
            }

            Console.ReadKey();
        }
    }
}
// once more got some help online to creeate this.
