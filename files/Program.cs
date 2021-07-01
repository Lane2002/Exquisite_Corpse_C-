using System;


namespace Exquisite_Corpse
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomMode();
            Console.Read();
        }
        static void BuildACreature(string head, string body, string feet)
        {

            switch (head)
            {
                case ("ghost"):
                    GhostHead();

                    break;
                case ("monster"):
                    MonsterHead();
                    break;

                case ("bug"):
                    BugHead();
                    break;

                default:
                    break;
            }



            switch (body)
            {
                case ("ghost"):
                    GhostBody();
                    break;

                case ("monster"):
                    MonsterBody();
                    break;

                case ("bug"):
                    BugBody();
                    break;

                default:
                    break;
            }



            switch (feet)
            {
                case ("ghost"):
                    GhostFeet();
                    break;

                case ("monster"):
                    MonsterFeet();
                    break;

                case ("bug"):
                    BugFeet();
                    break;

                default:
                    break;

            }
           
        }
            static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);

        }
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    BugHead();
                    break;
                default:
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    BugBody();
                    break;
                default:
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;

                case 2:
                    MonsterFeet();
                    break;

                case 3:
                    BugFeet();
                    break;

                default:
                    break;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}