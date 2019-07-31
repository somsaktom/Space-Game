using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    public class Speech
    {
        public void WelcomeToPlanet(string Planet, string SalerName)
        {
            Console.WriteLine($"Traveler from a far off land, welcome to planet {Planet}");
            Console.WriteLine($"My name is {SalerName}");
            Console.WriteLine($"What bring you here to our lovely Planet, {Planet}");
        }
        public void PlanetTalkingSale(string characterName, string product)
        {
            Console.WriteLine($"{characterName}, are planet is specialized in producing {product}. ");
            Console.WriteLine();
        }

        public string PlanetAskPlayer(string characterName)
        {
            string userInput = "";
            Console.WriteLine($"{characterName}, do you want to buy or sell?");
            try
            {
                userInput = Console.ReadLine();
            }
            catch(Exception e)
            {

            }
            return userInput;
        }

        public void PlanetToBuy(Speech planetName, string characterName)
        {
            Console.WriteLine("These are what I have to sell to you, {characterName}");
           // Console.WriteLine(planetName.PlanetGoodyBags.quantity(PlanetName));

        }

        public void PlanetToSell()
        {

        }

        public void PlanetToNegotiate()
        {

        }

        public void PlanetRejectOffer()
        {

        }

        public void PlanetAcceptOffer()
        {

        }

    }
}
