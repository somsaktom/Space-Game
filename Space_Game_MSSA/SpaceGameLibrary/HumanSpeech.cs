using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    public class HumanSpeech
    {

        public void PlayerToPlanet(string characterName, string playerPlanetName)
        {
            Console.WriteLine($"Hi, my name is {characterName} from planet {playerPlanetName}");
        }
        public void PlayerTalkingSale(string characterName, string product)
        {
            Console.WriteLine("I came from far off land. I'm looking to trade with you.");
        }

      
        public void PlayerToBuy(Speech planetName, string characterName)
        {
            Console.WriteLine("These are what I have to sell to you, {characterName}");
          //  Console.WriteLine(planetName.PlanetGoodyBags.quantity());

        }

        public void PlayerToSell()
        {

        }

        public void PlayerToNegotiate()
        {

        }

        public void PlayerRejectOffer()
        {

        }

        public void PlayerAcceptOffer()
        {

        }

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
        public double quantity()
        {
            double result = 0;

            return result;
        }

    }
}
