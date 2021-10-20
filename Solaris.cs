using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticAdventuresv2
{
    class Solaris
    {
        public string playerChoice = "Unknown";
        public string playerName { get; set; }
        public void Mission()
        {
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
                Console.WriteLine("Milly: Alright, maybe we can try again later");
            }
            if (playerChoice == "No")
            {
                Console.WriteLine("Milly: Alright, maybe we can try again later");
            }
        }
    }
}
