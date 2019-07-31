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
            mainManu();
        }

        static void mainManu()
        {
           
            Planets Planet1 = new Planets();
           

            Planet1.PlanetName = "Earth 3.0";
            //Planet1.WelcomeToPlanet(Planet1.PlanetName, "Tom");
            Planet1.money = 1000;
            Planet1.Gold = 50;
            Planet1.Silver = 60;
            Planet1.Brass = 10;
            Planet1.Bronze = 90;
            Planet1.Copper = 100;
            
            //Planet1.PlanetToBuy(Planet1);

        }
    }
}
