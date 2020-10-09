using System;

namespace Slagspel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            Random r = new Random();
            string fighterName1 = "";
            int fighterHp1 = 100;
            int fighterPunch1 = 0;
            string fighterName2 = "";
            int fighterHp2 = 100;
            int fighterPunch2 = 0;
            int rounds = 0;
            string[] fighter2Names = {"KLEVIN", "BOB", "LUKE"};
            fighterName2 = fighter2Names[r.Next(0,3)];

            //Input name
            System.Console.WriteLine("What's your name young boi?");
            fighterName1 = Console.ReadLine().ToUpper();

            Intro(fighterName1, fighterName2);

            //Subtract damage each round until one dies
            while (fighterHp1 > 0 && fighterHp2 > 0)
            {
                fighterPunch1 = r.Next(0, 100);
                fighterPunch2 = r.Next(0, 100);
                fighterHp1 -= fighterPunch2;
                fighterHp2 -= fighterPunch1;
                rounds++;
            }

            //Give Results
            if (fighterHp1 < 0 && fighterHp2 < 0)
            {
                System.Console.WriteLine("THEY BOTH DIED ON ROUND: " + rounds);
            }
            else if (fighterHp1 < 0)
            {
                System.Console.WriteLine(fighterName2 + " WON WITH " + fighterHp2 + " HEALTH REMAINING ON ROUND " + rounds);
            }
            else
            {
                System.Console.WriteLine(fighterName1 + " WON WITH " + fighterHp1 + " HEALTH REMAINING ON ROUND " + rounds);
            }

            Console.ReadLine();
        }

        //Just the intro text with the names
        static void Intro(string n1, string n2)
        {
            System.Console.WriteLine("WELCOME TO THE ARENA!");
            System.Console.WriteLine("LET'S SEE WHO WINS!");
            System.Console.WriteLine("ON THE LEFT SIDE WE HAVE: " + n1);
            System.Console.WriteLine("ON THE RIGHT SIDE WE HAVE: " + n2);
        }
    }
}
