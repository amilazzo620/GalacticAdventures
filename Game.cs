using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAdventuresv2
{
    public class Game
    {
        
        public Player CurrentPlayer;
        public int DataNumber = 0;
        static string gameTitle = "Galactic Adventures!";
        public string playerName { get;  set; }
        public string mission = "Unknown";
        public string playerChoice = "Unknown";
        public void StartGame()
        {
            Game game = new Game();
            Console.WriteLine($" {gameTitle}");
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //introduction text
            Console.WriteLine("Welcome! You have been recruited to extract data from planets and solar systems and bring that data back to the lab.\n\n");
            game.PlayerInput();
           
        }

        public void PlayerInput()
        {
            Game game = new Game();
            Console.WriteLine("We need to assign you a code name, what will it be?");
            Console.Write("Enter your code name: ");
            playerName = Console.ReadLine();

            Console.WriteLine($"\nCongratulations recruit, your codename is {playerName}. \nGood luck on your mission!");
            Console.WriteLine("Press any key to go to the Command Center for your first assignment");
            Console.ReadKey();
            Console.Clear();
            game.CommandCenter();
        }

        public void MenuOptions()
        {
            Game game = new Game();
            string options = "Start";
            string[] menuOptions = { "Start Game", "End Game" };
            Console.WriteLine("Please select an option");
            for (int i = 0; i < menuOptions.Length; i++)
            {
                string details = $"{menuOptions[i]}";
                Console.WriteLine(details);
            }
            string userChoice = Utility.MenuOptions(options);
        }

        public void CommandCenter()
        {
            Game game = new Game();
            Console.WriteLine($"Hello, {playerName}! Welcome to the Command Center! My codename's Milly, and I'm here to help you on your mission!\n\n Here's all the data that is needed from your journey:");
            string[] dataNeeded = { "Strandwalker", "Remnant of Ardasian Space Shuttle", "Ancestral Plasma Cannon", "Orb of Regeneration" };
            Console.WriteLine("General: WOAH WOAH WOAH.\n Before you leave, I need to give you the list of data we're in search of. \n");
            for (int i = 0; i < dataNeeded.Length; i++)
            {
                string data = $"{dataNeeded[i]}";
                Console.WriteLine(data);
            }
            Console.WriteLine($"\n\n General: Good luck {playerName}, I know your in good hands with Milly");
            Console.Clear();
            
        }

        


        public void PlanetChoice()
        {
            string[] firstMission = { "Solaris", "Ardas", "Batuu", "Contraxia" };
            Console.WriteLine("Milly: Well now that he's gone, select the planet you wish to travel to first:\n");
            for (int i = 0; i < firstMission.Length; i++)
            {
                string planets = $"{firstMission[i]}";
                Console.WriteLine(planets);
            }
            string userChoice = Utility.CommandCenterMission(mission);
        }
        
        public void LevelSolaris()
        {
            Game game = new Game();
            Solaris solaris = new Solaris();
            Console.WriteLine("Traveling to Solaris.....");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Traveling to Solaris.....");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //player name needs to save
            Console.WriteLine($"Transport Driver: Well {playerName}, this is Solaris\n");
            Console.WriteLine("Milly: Can you hear me?....\n Great! Let's start our mission! \n\n Wait wait, what's that? It looks like some sort of lifeform.\n Press any key to check it out");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Unknown Species: Welcome to Solaris, I am a Solarian. There are very few of us left on Solaris after the plague.\n I heard you were looking for data, maybe I can give you a sample for your mission....\n Interested?");
            playerChoice = Console.ReadLine();
            if (playerChoice == "Yes")
            {
                Console.WriteLine("Solarian: Great! All you have to do is solve this question about space travel and I'll give you the data sample you're looking for. \n");
                Console.WriteLine("Solarian: Just press any key to let me know you're ready!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Solarian: Ok let's get started! \n  ");

            }
            if (playerChoice == "yes")
            {
                Console.WriteLine("Solarian: Great! All you have to do is solve this question about space travel and I'll give you the data sample you're looking for. \n");
                Console.WriteLine("Solarian: Just press any key to let me know you're ready!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Solarian: Ok let's get started! \n  ");

            }
            if (playerChoice == "no")
            {
                Console.WriteLine("Milly: Maybe we can try a different planet");
                game.PlanetTravel();
            }
            if (playerChoice == "no")
            {
                Console.WriteLine("Milly: Maybe we can try a different planet");
                game.PlanetTravel();
            }

        }

        public void LevelArdas()
        {
            Console.WriteLine("Traveling to Ardas.....");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine($"Transport Driver: {playerName}, Welcome to Ardas.\n\n");
            Console.WriteLine("Milly: Well it's not the prettiest planet... \n But let's get started!");
        }

        public void LevelBatuu()
        {
            Console.WriteLine("Traveling to Batuu.....");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //player name needs to save
            Console.WriteLine($"Transport Driver: Well {playerName}, this is Batuu");
            Console.WriteLine("Milly: Can you hear me?....\n Great! Let's start our mission!");
        }

        public void LevelContraxia()
        {
            Console.WriteLine("Traveling to Contraxia.....");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //player name needs to save
            Console.WriteLine($"Transport Driver: Well {playerName}, this is Contraxia");
            Console.WriteLine("Milly: Can you hear me?.... \n Great! Let's start our mission!");
        }

        public void EndGameFromOptions()
        {
            Console.WriteLine("We hate to see you give up Recruit! Come back when you're ready for the Mission!\n Press any key to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void FinishGame()
        {

            //end of game text
            Console.WriteLine("Milly: Wow! I'm so proud of all the work you've done for our research lab\n Now let's see how much data you collected during your first ever mission:\n\n");
            Console.WriteLine($"You collected {DataNumber} data samples....\n");
            if (DataNumber > 3)
            {
                Console.WriteLine("Congratulations, you have sucessfully collected enough data for our lab !");
            }
            else
            {
                Console.WriteLine("I'm sorry, you haven't collected enough data, looks like you have to go on another mission.");
            }

        }

        public void QuestionWrong() 
        {
            Console.WriteLine("I'm sorry that is not the answer I was looking for. \n Maybe you can go to another planet and find some data there");

        }

        public void PlanetTravel()
        {
            string newplanetchoice = "Unknown";
            string[] newplanet = { "Solaris", "Ardas", "Batuu", "Contraxia" };
            Console.WriteLine("Milly: Maybe you can have some luck on a different planet\n");
            for (int i = 0; i < newplanet.Length; i++)
            {
                string planets = $"{newplanet[i]}";
                Console.WriteLine(planets);
            }
            string userChoice = Utility.CommandCenterMission(newplanetchoice);
        }
    }

}