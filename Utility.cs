using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAdventuresv2
{
    class Utility
    {
        public static string MenuOptions(string menuOptions)
        {
            Game game = new Game();
            menuOptions = Console.ReadLine();

            try
            {
                if (menuOptions == "Start Game")
                {
                    Console.Clear();
                    Console.WriteLine("Loading....Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    game.StartGame();
                }
                
                if (menuOptions == "End Game")
                {
                    Console.Clear();
                    Console.WriteLine("Ending Game....");
                    game.EndGameFromOptions();
                }
               
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid option");
            }


            return MenuOptions(menuOptions);
        }

       public static string CommandCenterMission(string firstMission)
        {
            Game game = new Game();
            firstMission = Console.ReadLine();
            try
            {
                if (firstMission == "Solaris")
                {
                    Console.WriteLine("Milly: Great! Sending a transport to pick you up now");
                    game.LevelSolaris();
                }
                if (firstMission == "Ardas")
                {
                    Console.WriteLine("Milly: Great! Sending a transport to pick you up now");
                    game.LevelArdas();
                }
                if (firstMission == "Batuu")
                {
                    Console.WriteLine("Milly: Great! Sending a transport to pick you up now");
                    game.LevelBatuu();
                }
                if (firstMission == "Contraxia")
                {
                    Console.WriteLine("Milly: Great! Sending a transport to pick you up now");
                    game.LevelContraxia();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please select one of the planets on your mission");
            }
            return CommandCenterMission(firstMission);
        }
    }
}
