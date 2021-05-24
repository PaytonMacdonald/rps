// player types in char
// if "r" pChoice = "rock"
// if "p" pChoice = "paper"
// if "s" pChoice = "scissors"
// log "player has chosen"
// time pause
// log "computer is choosing"
// time pause
// computer chooses random number between 1-3 minus 1 for the array
// if 0 comChoice = "rock"
// if 1 comChoice = "paper"
// if 2 comChoice = "scissors"
// log "computer has made it's choice"
// time pause
// run Game
// if pChoice == "rock"


using System;
using System.Collections.Generic;
using System.Threading;
using rps.Models;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rock, paper, scissors? (r/p/s)");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            int pChoice = 0;
            if (choice == 'r')
            {
                pChoice = 0;
            }
            else if (choice == 'p')
            {
                pChoice = 1;
            }
            else if (choice == 's')
            {
                pChoice = 2;
            }
            else
            {
                Console.WriteLine("that was not an option");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("resetting game");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }





        }
    }
}
