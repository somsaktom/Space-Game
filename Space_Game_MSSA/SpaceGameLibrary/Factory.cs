using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Game_MSSA
{
    class Factory
    {
        public void Menus()
        {
           
            try
            {
                
                Human h = new Human();
                Planets P = new Planets();
                Console.WriteLine("Space Game");
                Console.WriteLine("Welcome to space. Collect $1 Billion and win the game!");
                Console.WriteLine("Enter in your name: ");
                h.CharacterName();
                Console.ReadKey();
                HomeMenu();
                

                void HomeMenu()
                {
                    Console.Clear();
                    Planets p = new Planets();
                    Console.WriteLine("Welcome home!!!");
                    p.HomePlanet();
                    string pick = Console.ReadLine();
                    int option;
                    while (!int.TryParse(pick, out option))
                    {
                        p.HomePlanet();
                        pick = Console.ReadLine();

                    }
                    switch (option)
                    {
                        case 1:
                            p.buy();
                            break;
                        case 2:
                            p.sell();
                            break;
                        case 3:
                            p.CashOut();
                            break;
                        case 4:
                            MainMenu();
                            break;
                    }

                }


                void MainMenu()
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

              void PlanetMenu()
              {
                Planets p = new Planets();
                Console.WriteLine("What method do you wish to use?");
                p.PlanetMenu();
                string pick = Console.ReadLine();
                int option;
                while (!int.TryParse(pick, out option))
                {
                    p.PlanetMenu();
                    pick = Console.ReadLine();
                }
                switch (option)
                {
                    case 1:
                        p.buy();
                        break;
                    case 2:
                        p.sell();
                        break;
                    case 3:
                        p.Menu();
                        break;
                }
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
    }
}
