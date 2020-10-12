using System;

namespace Slagspel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variables
            Random r = new Random();
            bool game = true;
            string fighterName1 = "";
            int fighterHp1 = 100;
            string fighterName2 = "";
            int fighterHp2 = 100;
            bool nameCorrect = false;
            string[] fighter2Names = { "KLEVIN", "BOB", "LUKE" };
            fighterName2 = fighter2Names[r.Next(0, 3)];
            string ans = "";

            while (game)
            {
                ans = "";
                fighterHp1 = 100;
                fighterHp2 = 100;
                fighterName2 = fighter2Names[r.Next(0, 3)];
                nameCorrect = false;



                //Input name
                System.Console.WriteLine("What's your name young boi?");
                fighterName1 = Console.ReadLine().ToUpper();

                if (fighterName1.Length > 2 && fighterName1.Length < 11)
                {
                    nameCorrect = true;
                }

                while (nameCorrect == false)
                {
                    System.Console.WriteLine("That's a weird name, only 3 to 10 characters man");
                    fighterName1 = Console.ReadLine().ToUpper();
                    if (fighterName1.Length > 1 && fighterName1.Length < 11)
                    {
                        nameCorrect = true;
                    }

                }

                Intro(fighterName1, fighterName2);

                Fight(fighterName1, fighterName2, fighterHp1, fighterHp2);



                System.Console.WriteLine("Y'all wanna try again? Y/N");
                ans = Console.ReadLine().ToUpper();

                while (ans != "Y" && ans != "N")
                {
                    System.Console.WriteLine("That wasn't an option...");
                    ans = Console.ReadLine().ToUpper();
                }


                if (ans == "N")
                {
                    System.Console.WriteLine("See Ya!");
                    game = false;
                }
                else
                {
                    System.Console.WriteLine("LETS GOO");
                }
                Console.ReadLine();
            }
        }

        //Just the intro text with the names
        static void Intro(string n1, string n2)
        {
            System.Console.WriteLine("WELCOME TO THE ARENA!");
            System.Console.WriteLine("LET'S SEE WHO WINS!");
            System.Console.WriteLine("ON THE LEFT SIDE WE HAVE: " + n1);
            System.Console.WriteLine("ON THE RIGHT SIDE WE HAVE: " + n2);
            Console.ReadLine();
            System.Console.WriteLine("FIGHT!");
            Console.WriteLine(@"                  .--.");
            Console.WriteLine(@"                 /.''.\");
            Console.WriteLine(@"                 ||   \_");
            Console.WriteLine(@"          /^\    '.'--,");
            Console.WriteLine(@"        .'_|_'.    `()");
            Console.WriteLine(@"       <   |   >    ||");
            Console.WriteLine(@"        \_____/     ||");
            Console.WriteLine(@"        {/a a\}     ||");
            Console.WriteLine(@"       {/-.^.-\}   (_|");
            Console.WriteLine(@"      .'{  `  }'-._/|;\");
            Console.WriteLine(@"     /  {     }  /; || |");
            Console.WriteLine(@"    /`'-{     }-';  || |");
            Console.WriteLine(@"   ; `'=|{   }|=' _/|| |");
            Console.WriteLine(@"   |   \| |~| |  |/ || |");
            Console.WriteLine(@"   |\   \ | | |  ;  || |");
            Console.WriteLine(@"   | \   ||=| |=<\  || |");
            Console.WriteLine(@"   | /\_/\| | |  \`-||_/");
            Console.WriteLine(@"   '-| `;'| | |  |  ||");
            Console.WriteLine(@"     |  | | | |  |  ||");
            Console.WriteLine(@"     |  |+| |+|  |  ||");
            Console.WriteLine(@"     |  |+|||+|  |  ||");
            Console.WriteLine(@"     |_ _ _ _ _ _|  ||");
            Console.WriteLine(@"     |,;,;,;,;,;,|  ||");
            Console.WriteLine(@"     `|||||||||||`  ||");
            Console.WriteLine(@"      |||||||||||   ||");
            Console.WriteLine(@"      `|||||||||`   ||");
            Console.ReadLine();
        }

        static void Fight(string n1, string n2, int hp1, int hp2)
        {
            Random r = new Random();
            int fighterPunch1 = 0;
            int fighterPunch2 = 0;
            int rounds = 0;
            //Subtract damage each round until one dies
            while (hp1 > 0 && hp2 > 0)
            {
                fighterPunch1 = r.Next(0, 20);
                fighterPunch2 = r.Next(0, 20);
                hp1 -= fighterPunch2;
                hp2 -= fighterPunch1;
                System.Console.WriteLine(n1 + " has " + hp1 + " hp left!");
                System.Console.WriteLine(n2 + " has " + hp2 + " hp left!");
                rounds++;
            }

            //Give Results
            if (hp1 < 0 && hp2 < 0)
            {
                System.Console.WriteLine("THEY BOTH DIED ON ROUND: " + rounds);
            }
            else if (hp2 > 0)
            {
                System.Console.WriteLine(n1 + " WON WITH " + hp2 + " HEALTH REMAINING ON ROUND " + rounds);
            }
            else
            {
                System.Console.WriteLine(n1 + " WON WITH " + hp1 + " HEALTH REMAINING ON ROUND " + rounds);
            }
        }
    }
}
