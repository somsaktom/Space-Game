using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    public class Menu
    {
        public void HomeMenu()
        {

            try
            {


                Console.Clear();
                Planets p = new Planets();
                GoodyBag g = new GoodyBag();
                Console.WriteLine("Welcome home!!!");
                p.HomePlanet();
                string pick = Console.ReadLine();
                int option;
                while (!int.TryParse(pick, out option))
                {
                    p.HomePlanet();
                    pick = Console.ReadLine();

                }
                if (option >= 1 && option <= 4)
                {
                    switch (option)
                    {
                        case 1:
                            Buy();
                            break;
                        case 2:
                            Sell();
                            break;
                        case 3:
                            g.CashOut();
                            break;
                        case 4:
                            MainMenu();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number try again.");
                    Console.ReadLine();
                    HomeMenu();
                }

            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.ReadLine();
            }
            catch (InvalidOperationException ioEx)
            {
                Console.WriteLine(ioEx.Message);
                Console.ReadLine();
            }
            catch (OverflowException ofEx)
            {
                Console.WriteLine(ofEx.Message);
                Console.ReadLine();
            }
            catch (DivideByZeroException dZe)
            {
                Console.WriteLine(dZe.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("This program has finally terminated.");
                Console.ReadLine();
            }
        }
        public void PlanetMenu()
        {
            GoodyBag g = new GoodyBag();
            Planets p = new Planets();
            Console.Clear();
            Console.WriteLine("What method do you wish to use?");
            p.PlanetMenu();
            string pick = Console.ReadLine();
            int option;
            while (!int.TryParse(pick, out option))
            {
                p.PlanetMenu();
                pick = Console.ReadLine();
            }
            if (option >= 1 && option <= 3)
            {
                switch (option)
                {
                    case 1:
                        Buy();
                        break;
                    case 2:
                        Sell();
                        break;
                    case 3:
                        MainMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number try again.");
                Console.ReadLine();
                PlanetMenu();
            }
        }
        public void MainMenu()
        {
            Console.Clear();
            Planets p = new Planets();
            Console.WriteLine("Where do you want to go? ");
            p.Menu();
            string pick = Console.ReadLine();
            int option;
            while (!int.TryParse(pick, out option))
            {
                p.Menu();
                pick = Console.ReadLine();
            }
            if (option >= 1 && option <= 6)
            {
                switch (option)
                {
                    case 1:
                        p.GoldPlanet();
                        break;
                    case 2:
                        p.SilverPlanet();
                        break;
                    case 3:
                        p.BrassPlanet();
                        break;
                    case 4:
                        p.BronzePlanet();
                        break;
                    case 5:
                        p.CopperPlanet();
                        break;
                    case 6:
                        HomeMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number try again.");
                Console.ReadLine();
                MainMenu();
            }
        }
        public void Buy()
        {
            GoodyBag g = new GoodyBag();
            Console.Clear();
            Console.WriteLine("What do you want to buy?");
            Console.WriteLine("Buy my crap");
            Console.WriteLine("1. I want it. Give it to me!!");
            Console.WriteLine("2. That is way to much. Get bent NERD!!");
            string pick = Console.ReadLine();
            int option;
            while (!int.TryParse(pick, out option))
            {
                Buy();
                pick = Console.ReadLine();
            }
            if (option >= 1 && option <= 2)
            {
                switch (option)
                {
                    case 1:
                        g.buy();
                        break;
                    case 2:
                        BuyNegotiate();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number try again.");
                Console.ReadLine();
                PlanetMenu();
            }
        }
        public void Sell()
        {
            GoodyBag g = new GoodyBag();
            Console.Clear();
            Console.WriteLine("Fine, What do you want to sell");
            Console.WriteLine("Don't show some worthless crap!\n");
            Console.WriteLine("Here is my offer\n\n");
            Console.WriteLine("1. Yes, I will sell.");
            Console.WriteLine("2. Get out here with that low ball offer!!!");
            string pick = Console.ReadLine();
            int option;
            while (!int.TryParse(pick, out option))
            {
                Sell();
                pick = Console.ReadLine();
            }
            if (option >= 1 && option <= 2)
            {
                switch (option)
                {
                    case 1:
                        g.sell();
                        break;
                    case 2:
                        g.negotiation();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number try again.");
                Console.ReadLine();
                PlanetMenu();
            }
        }
        public void BuyNegotiate()
        {
            GoodyBag g = new GoodyBag();
            Console.WriteLine("Seriuosly?");
            Console.WriteLine("This is what I'm willing to do\n");
            Console.WriteLine("1. Yes, give that thang.");
            Console.WriteLine("2. No, thats a terrible offer.");
            string pick = Console.ReadLine();
            int option;
            while (!int.TryParse(pick, out option))
            {
                BuyNegotiate();
                pick = Console.ReadLine();
            }
            if (option >= 1 && option <= 2)
            {
                switch (option)
                {
                    case 1:
                        g.buy();
                        break;
                    case 2:
                        PlanetMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number try again.");
                Console.ReadLine();
                BuyNegotiate();
            }
        }
        public void SellNegotiate()
        {
            GoodyBag g = new GoodyBag();
            Console.WriteLine("Seriuosly?");
            Console.WriteLine("This is how much I would sell it for");
            //need to set up the negotiation before bring it back
            //g.negotiation();
            Console.WriteLine("How much do you want for it?\n");
            Console.WriteLine("1. Yes, give me that money.");
            Console.WriteLine("2. No, thats a terrible offer.");
            string pick = Console.ReadLine();
            int option;
            while (!int.TryParse(pick, out option))
            {
                BuyNegotiate();
                pick = Console.ReadLine();
            }
            if (option >= 1 && option <= 2)
            {
                switch (option)
                {
                    case 1:
                        g.sell();
                        break;
                    case 2:
                        PlanetMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number try again.");
                Console.ReadLine();
                BuyNegotiate();
            }
        }
    }
}
