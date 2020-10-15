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
            string ans = "";

            while (game)
            {
                //Resetting variables
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
                    if (fighterName1.Length > 2 && fighterName1.Length < 11)
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

                //Cancelling the loop
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

        //The entire automated fight inputing the names and their hp
        static void Fight(string n1, string n2, int hp1, int hp2)
        {
            //Declaring variables
            Random r = new Random();
            int fighterPunch1 = 0;
            int fighterPunch2 = 0;
            int rounds = 0;
            bool miss1 = false;
            bool miss2 = false;

            //Subtract damage each round until one dies
            while (hp1 > 0 && hp2 > 0)
            {
                //Raandomising the punch damage
                fighterPunch1 = r.Next(1, 21);
                fighterPunch2 = r.Next(1, 21);

                //Randomising miss chance for both
                if (r.Next(0, 8) == 0)
                {
                    miss1 = true;
                }
                if (r.Next(0, 8) == 0)
                {
                    miss2 = true;
                }

                //Subtracting the damage and outputting logs depending on if they missed or not, player 1
                if (miss1 == false)
                {
                    hp2 -= fighterPunch1;
                    if (hp2 <= 0)
                    {
                        System.Console.WriteLine("You hit " + n2 + " for " + fighterPunch1 + " damage killing him for good!");
                    }
                    else
                    {
                        System.Console.WriteLine("You hit " + n2 + " for " + fighterPunch1 + " damage leaving him with " + hp2 + " hp left!");
                    }

                }
                else
                {
                    System.Console.WriteLine("You missed!");
                    miss1 = false;
                }


                //Subtracting the damage and outputting logs depending on if they missed or not and make sure they're not dead, player 2
                if (miss2 == false && hp2 > 0)
                {
                    hp1 -= fighterPunch2;
                    if (hp1 <= 0)
                    {
                        System.Console.WriteLine(n2 + " hit you for " + fighterPunch2 + " damage killing you!");
                    }
                    else
                    {
                        System.Console.WriteLine(n2 + " hit you for " + fighterPunch2 + " damage leaving you with " + hp1 + " hp left!");
                    }
                }
                else if (hp2 > 0)
                {
                    System.Console.WriteLine(n2 + " missed!");
                    miss2 = false;
                }

                //Incrementing the roundcount
                rounds++;
            }

            //Give Final Results
            if (hp1 <= 0 && hp2 <= 0)
            {
                System.Console.WriteLine("THEY BOTH DIED ON ROUND: " + rounds);
            }
            else if (hp1 > 0)
            {
                System.Console.WriteLine("YOU WON WITH " + hp1 + " HEALTH REMAINING ON ROUND " + rounds);
            }
            else
            {
                System.Console.WriteLine(n2 + " WON WITH " + hp2 + " HEALTH REMAINING ON ROUND " + rounds);
            }
        }
    }
}
