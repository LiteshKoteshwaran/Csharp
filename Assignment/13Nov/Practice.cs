using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    public class Team
    {
        public string Name;
        public int Score;
        Player player = new Player();
        public void CaptureTeamDetails()
        {
            Console.WriteLine("ENTER THE TEAM NAME");
            Name = Console.ReadLine();
            player.CapturePlayerEntries();
            Score = player.Score;
        }
        public void DisplayTeamDetails()
        {
            Console.WriteLine("TEAM "+ Name +" DETAILS");
            player.DisplayPlayerDetails();
        }

    }
    public class Player
    {
        public string Name;
        public int ID,Score;
        public void CapturePlayerEntries()
        {
            Console.WriteLine("ENTER THE PLAYER NAME");
            Name = Console.ReadLine();
            Console.WriteLine("ENTER THE PLAYER ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE PLAYER SCORE");
            Score = int.Parse(Console.ReadLine()); 
        }

        public void DisplayPlayerDetails()
        {
            Console.WriteLine("PLAYER DETAILS");
            Console.WriteLine("THE NAME AND SCORE OF THE PLAYER IS "+Name+", "+Score);
        }
    }


    class Match
    {

        string Result = " ";
       
        public static void Main(string[] args)
        {
            Team Team1 = new Team();
            Team1.CaptureTeamDetails();
            Team1.DisplayTeamDetails();
            Team Team2 = new Team();
            Team2.CaptureTeamDetails();
            Team2.DisplayTeamDetails();
            if (Team1.Score > Team2.Score)
                Console.WriteLine("Team 1 won");
            else
                Console.WriteLine("Team 2 won");
        }
    }
}
