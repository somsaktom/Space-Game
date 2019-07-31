using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    public class Human
    {
        public decimal money { get; set; }
        public int gold { get; set; }
        public int silver { get; set; }
        public int brass { get; set; }
        public int bronze { get; set; }
        public int copper { get; set; }
        public HumanSpeech HumanSpeech { get; set; }
        public GoodyBag HumanGoodyBags { get; set; }
        public Human()
        {
            HumanGoodyBags = new GoodyBag();
            this.HumanSpeech = new HumanSpeech();
            this.money = 10000;
            this.gold = 0;
            this.silver = 0;
            this.brass = 0;
            this.bronze = 0;
            this.copper = 0;
        }
        public void CharacterName()
        {
            String CharacterName = " ";

            Console.WriteLine($"Your name is {CharacterName}");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"Welcome, {CharacterName}, and good luck!");


        }

    }
}
