using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    public class Planets
    {
        public string PlanetName { get; set; }
        public decimal money { get; set; }
        public double Gold { get; set; }
        public double Silver { get; set; }
        public double Brass { get; set; }
        public double Bronze { get; set; }
        public double Copper { get; set; }
        public GoodyBag PlanetGoodyBags { get; set; }
        public Planets()
        {
            PlanetGoodyBags = new GoodyBag();
            this.Speech = new Speech();
            this.money = 1000;
            this.Gold = 50;
            this.Silver = 60;
            this.Brass = 10;
            this.Bronze = 90;
            this.Copper = 100;
        }
        public Speech Speech { get; set; }

        public double sell()
        {
            double result = 0;
            return result;
        }

        public double buy()
        {
            double result = 0;

            return result;
        }

        public double negotiation()
        {
            double result = 0;

            return result;
        }

        public double counterOffer()
        {
            double result = 0;

            return result;
        }
        public double CashOut()
        {
            //This where you cash out to win the game. 
            //It should be in the home planet
            double result = 0;
            return result;
        }

        
       
        public void Menu()
        {
            Console.WriteLine("Select option from below!");
            Console.WriteLine("1. Gold Planet");
            Console.WriteLine("2. Silver Planet");
            Console.WriteLine("3. Brass Planet");
            Console.WriteLine("4. Bronze Planet");
            Console.WriteLine("5. Copper Planet");
            Console.WriteLine("6. Home");
        }

        public void HomePlanet()
        {
            Console.WriteLine("Select option from below");
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Sell");
            Console.WriteLine("3. Cash in $1 billion to win");
            Console.WriteLine("4. Go to Space!");

        }
        public void PlanetMenu()
        {
            Console.WriteLine("Select option from below");
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Sell");
            Console.WriteLine("3. Go back to space");
        }

    }
}