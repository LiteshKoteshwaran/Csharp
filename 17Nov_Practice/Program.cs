using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Nov_Practice
{
    class Person
    {
        private string Name;
        private int Age;
        public void AddData()
        {

            Console.WriteLine("Enter the Name ");
            Name = Console.ReadLine();
            if (Name.Length <= 5)
                throw new Exception("Please give the full name ");
            Console.WriteLine("Enter the Age ");
            Age = Convert.ToInt32(Console.ReadLine());



        }
        public void FetchData()
        {
            Console.WriteLine("The entered data name is " + Name + " and his age is " + Age);
        }


    }

    class Player : Person
    {
        int RunsScored;
        bool IsCaptain;

        public void PlayerDetails()
        {
            try
            {
                AddData();
                Console.WriteLine("Enter the runs scored by player ");
                RunsScored = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(" Please enter the full name");
                Console.WriteLine(e.Message);
            }


            try
            {

                Console.WriteLine("Enter the player is a captain or not ");
                IsCaptain = Convert.ToBoolean(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("please enter either True or False ");
                Console.WriteLine(e.StackTrace);
            }
        }
        public void DisplayDetails()
        {
            FetchData();
            Console.WriteLine("The runs scored by the player is  " + RunsScored + " is he captain " + IsCaptain);
        }
    }
    class Team
    {
        public string TeamName;
        public int NoOfPlayers;
        public string ManOfTheMatch;
        //  List<Player> P = new List<Player>();
        Player[] P = new Player[5];

        public void PlayerDataEntry()
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    P[i] = new Player();
                    P[i].PlayerDetails();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You have enterd more then the maximum player");
                Console.WriteLine(e.Message);

            }
        }
        public void PlayerDetails()
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    P[i].DisplayDetails();
                    Console.WriteLine("You are entered into the Players details ");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("You have enterd into the catch block of the players details ");
            }
        }



    }
    class PracticalApp
    {
        static void Main(string[] args)
        {
            Team T = new Team();
            T.PlayerDataEntry();
            T.PlayerDetails();


            Console.ReadLine();
        }
    }

}
