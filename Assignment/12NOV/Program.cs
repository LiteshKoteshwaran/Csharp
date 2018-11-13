using System;

namespace _12NOV
{
    class InstitutionCricketHospital
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("ENTER 1 FOR CRICKET");
            Console.WriteLine("ENTER 2 FOR HOSPITAL");
            int Input = int.Parse(Console.ReadLine());
            if (Input == 1)
            {
                Team Team = new Team();
                Team.main();
            }
            if(Input==2)
            {

            }
        }
    }

    public class Patient
    {
        string[] PatientName,PatientSymptoms;
        int[] PatientID;

        public void EntryPatientDetails()
        {
            Console.WriteLine("ENTER THE NOS OF ENTRIES YOU WANT TO MAKE");
            int NosOfPatient = int.Parse(Console.ReadLine());
            PatientName = new string[NosOfPatient];
            PatientSymptoms = new string[NosOfPatient];
            for (int i = 0; i < NosOfPatient; i++)
            {
                Console.WriteLine("ENTER THE PATIENT NAME");
                PatientName[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE PATIENT ID");
                PatientID[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE PATIENT SYMPTOMS");
                PatientSymptoms[i] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public void DisplayPatientDetails()
        {

        }
    }

    public class Doctor
    {
        string[] DoctorName,DoctorSpecialization;
        int NosOfDoctor;
        int[] DoctorID;
        Time[] DoctorAvailability;

        public void EntryDoctorDetails()
        {
            Console.WriteLine("ENTER THE NOS OF ENTRIES YOU WNAT TO MAKE");
            NosOfDoctor = int.Parse(Console.ReadLine());
            DoctorAvailability = new Time[NosOfDoctor];
            for (int i = 0; i > NosOfDoctor; i++)
            {
                Console.WriteLine("ENTER THE DOCTOR ID");
                DoctorID[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE DOCTOR NAME");
                DoctorName[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE DOCTOR SPECIALIZATION");
                DoctorSpecialization[i] = Console.ReadLine();
                Console.WriteLine();

                DoctorAvailability[i].EntryDoctorTimeAvailability(NosOfDoctor,DoctorID);
            }
        }

        public void DisplayDoctorTimeAvailability()
        {
            
            Console.WriteLine("DOCTOR ID" + "\t\t" + "DOCTOR NAME" + "\t\t" + "DOCTOR STARTTIME" + "\t\t" + "DOCTOR ENDTIME");
            for (int i = 0; i < NosOfDoctor; i++)
            {
                Console.WriteLine(DoctorID[i]+"\t\t\t\t"+DoctorName[i]+ "\t\t\t\t" + DoctorAvailability[i].StartTime[i] + "\t\t\t\t" + DoctorAvailability[i].EndTime[i]);
            }

        }
    }

    public class Time
    {
        public TimeSpan[] StartTime, EndTime;
        int[] DoctorId;
        string[] DoctorAvailability;

        public void EntryDoctorTimeAvailability(int NosOfDoctor,int[] DoctorID)
        { 
            DoctorId = new int[NosOfDoctor];
            StartTime = new TimeSpan[NosOfDoctor];
            EndTime = new TimeSpan[NosOfDoctor];
            for(int i =0; i<NosOfDoctor; i++)
            {
                DoctorId[i] = DoctorID[i];

                Console.WriteLine("ENTER THE STARTING AVAILABILITY TIME FOR DOCTOR HAVING ID :"+DoctorId[i]);
                Console.WriteLine("FORMAT --->>  24-HOUR [HH]:[MM]");
                StartTime[i] = TimeSpan.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE END TIME FOR DOCTOR HAVING ID :" + DoctorId[i]);
                Console.WriteLine("FORMAT --->>  24-HOUR [HH]:[MM]");
                EndTime[i] = TimeSpan.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }


        public void DoctorAvailabilityCheck(int NosOfDoctor, TimeSpan[] PatientCheckInTime, TimeSpan[] EndTime)
        {
            int TimeCheck = 0;
            DoctorAvailability = new string[NosOfDoctor];
            for (int i = 0; i < NosOfDoctor; i++)
            {
                TimeCheck = TimeSpan.Compare(PatientCheckInTime[i], EndTime[i]);
                if (TimeCheck == -1)
                {
                    DoctorAvailability[i] = "Available";
                }
                if (TimeCheck == 0)
                {
                    DoctorAvailability[i] = "Not Available";
                }
                if (TimeCheck == 1)
                {
                    DoctorAvailability[i] = "Not Available";
                }
            }
        }
    }





   









    class Team
    {
        string TeamName;
        int NosOfplayer;
        public void Teaminfo()
        {
            Console.WriteLine("ENTER THE TEAM NAME");
            TeamName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("ENTER THE TOTAL NOS OF PLAYERS IN THE TEAM");
            NosOfplayer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Player Player = new Player();
            Player.EnterPlayerDetails(TeamName, NosOfplayer);
            Player.DisplayPlayerDetails();

        }
        public void main()
        {
            string ManOfTeamA, ManOfTeamB;
            int ScoreA, ScoreB;
            Player P = new Player();
            Team[] Team = new Team[2];
            Team[0] = new Team();
            Team[0].Teaminfo();
            ScoreA = P.ScoreOfManOfTheTeam;
            ManOfTeamA = P.NameOfManOfTheTeam;

            Team[1] = new Team();
            Team[1].Teaminfo();
            ScoreB = P.ScoreOfManOfTheTeam;
            ManOfTeamB = P.NameOfManOfTheTeam;

            if (ScoreA > ScoreB)
            {
                Console.WriteLine("MAN OF THE MATCH IS " + ManOfTeamA);
            }
            else
                Console.WriteLine("MAN OF THE MATCH IS " + ManOfTeamB);
            Console.ReadLine();
        }

    }
    class Player
    {
        string[] PlayerName;
        int[] PlayerScore;
        public int ScoreOfManOfTheTeam = 0, TeamTotalScore, TeamAvgScore, Nosplayer;
        public string NameOfManOfTheTeam;

        public void EnterPlayerDetails(string TeamName, int NosOfplayer)
        {
            Nosplayer = NosOfplayer;
            TeamTotalScore = 0;
            TeamAvgScore = 0;
            PlayerScore = new int[NosOfplayer];
            PlayerName = new string[NosOfplayer];
            for (int i = 0; i < NosOfplayer; i++)
            {
                Console.WriteLine("ENTER THE PLAYER NAME");
                PlayerName[i] = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("ENTER THE SCORE OF " + PlayerName[i]);
                PlayerScore[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (ScoreOfManOfTheTeam < PlayerScore[i])
                {
                    ScoreOfManOfTheTeam = PlayerScore[i];
                    NameOfManOfTheTeam = PlayerName[i];
                }
                TeamTotalScore += PlayerScore[i];
                TeamAvgScore = (TeamTotalScore / NosOfplayer);
            }
        }

        public void DisplayPlayerDetails()
        {
            Console.WriteLine("PLAYER NAME" + "\t\t\t\t" + "PLAYER SCORE");
            for (int i = 0; i < Nosplayer; i++)
            {
                Console.WriteLine(PlayerName[i] + "\t\t\t\t\t\t\t\t" + PlayerScore[i]);
            }
            Console.WriteLine();
            Console.WriteLine("THE AVG SCORE OF THE TEAM IS " + TeamAvgScore);
            Console.WriteLine();
            Console.WriteLine("THE MAN THE TEAM IS " + NameOfManOfTheTeam + " AND HIS SCORE IS " + ScoreOfManOfTheTeam);
            Console.WriteLine();
        }
    }
}