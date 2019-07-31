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

        
        enum PlanetSpecializedIn { Gold, Silver, Copper, Brass, Bronze }

    }
}