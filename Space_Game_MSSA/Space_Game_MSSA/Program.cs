using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();
            Human h = new Human();
            Console.WriteLine("Space Game");
            Console.WriteLine("Welcome to space. Collect $1 Billion and win the game!");
            Console.WriteLine("Enter in your name: ");
            h.CharacterName();
            Console.ReadKey();
            m.HomeMenu();
           
        }

    }
}
