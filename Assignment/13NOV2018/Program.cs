using System;

namespace Prac_13Nov
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace _13Nov
    {
        public class Person
        {
            public string PersonName;
            public int PersonID;

            public string EnterPersonDetails()
            {
                Console.WriteLine("ENTER THE PERSON NAME");
                PersonName = Console.ReadLine();
                Console.WriteLine();

                return PersonName;
            }

        }

        public class Team
        {
            public int Input, TotalTeamScore;
            public string Name;
            public Player[] player = new Player[11];
            public Player ManOftheteam = new Player();

            public void CaptureTeamDetails()
            {
                TotalTeamScore = 0;
                ManOftheteam.Score = 0;
                Console.WriteLine("ENTER THE TEAM NAME");
                Name = Console.ReadLine();
                Console.WriteLine("ENTER NOS. OF PLAYERS TO ENTRY");
                Input = int.Parse(Console.ReadLine());
                for (int i = 0; i < Input; i++)
                {
                    player[i] = new Player();
                    player[i].CapturePlayerEntries();
                    TotalTeamScore += player[i].Score;

                    if (ManOftheteam.Score < player[i].Score)
                    {
                        ManOftheteam.Score = player[i].Score;
                        ManOftheteam.Name = player[i].Name;
                    }
                }
            }
            public void DisplayTeamDetails()
            {
                Console.WriteLine("TEAM " + Name + " DETAILS");
                for (int i = 0; i < Input; i++)
                {
                    player[i].DisplayPlayerDetails();
                }
                Console.WriteLine("THE MAN OF THE TEAM IS :" + ManOftheteam.Name);
            }

        }
        public class Player : Person
        {
            public string Name;
            public int ID, Score;
            public void CapturePlayerEntries()
            {
                Name = EnterPersonDetails();
                //Console.WriteLine("ENTER THE PLAYER NAME");
                //Name = Console.ReadLine();
                Console.WriteLine("ENTER THE PLAYER ID");
                ID = int.Parse(Console.ReadLine());
                Console.WriteLine("ENTER THE PLAYER SCORE");
                Score = int.Parse(Console.ReadLine());
            }

            public void DisplayPlayerDetails()
            {
                Console.WriteLine("PLAYER DETAILS");
                Console.WriteLine("THE NAME AND SCORE OF THE PLAYER IS " + Name + ", " + Score);
            }
        }


        class Match
        {
            public Team Team1 = new Team();
            public Team Team2 = new Team();
            public string ManOfTheMatch;
            public void OutputResult()
            {
                if (Team1.TotalTeamScore > Team2.TotalTeamScore)
                    Console.WriteLine("Team 1 won");
                else
                    Console.WriteLine("Team 2 won");
                if (Team1.ManOftheteam.Score > Team2.ManOftheteam.Score)
                {
                    ManOfTheMatch = Team1.ManOftheteam.Name;
                }
                else
                    ManOfTheMatch = Team2.ManOftheteam.Name;
                Console.WriteLine("MAN OF THE MATCH IS :" + ManOfTheMatch);
            }
        }
        class Sport
        {


            public static void Main()
            {
                Match match = new Match();
                match.Team1.CaptureTeamDetails();
                match.Team1.DisplayTeamDetails();

                match.Team2.CaptureTeamDetails();
                match.Team2.DisplayTeamDetails();

                match.OutputResult();
                Console.ReadLine();
            }
        }
    }

}