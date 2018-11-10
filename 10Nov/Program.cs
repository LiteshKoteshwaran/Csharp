using System;

namespace _10Nov
{
    class InstituteHospitalCricket
    {
        //
        static int[] StudentId = new int[10];
        static int[] StudentCourseFee = new int[10];
        static int[] Coursefee = new int[10];
        static int[] NosOfCourseEnquiredPerEnquire = new int[10];
        static int[] TotalFeeToCollect = new int[10];
        static int[] AmountPaid = new int[10];
        static int[] DueAmount = new int[10];

        static int ChoiceForInstitution, TotalNosOfCourseAvaiable = 0, TotalNosOfEnquires = 0, TotalNosOfStudent = 0, NosOfCoursePerStudent;

        static string[] CourseName = new string[10];

        static string[] CourseDuration = new string[10];
        static string[] Enquirername = new string[10];
        static string[] NamesOfCourseEnquiredPerEnquire = new string[10];

        static string[] StudentName = new string[10];
        static string[] NamesOfCourseTakenByStudent = new string[10];
        //

        //
        static string[] PatientName = new string[10];
        static int[] PatientId = new int[10];
        static string[] PatientSymptoms = new string[10];
        static int TotalNoOfPatient = 0;
        static string[] AssignedDoctor = new string[10];

        static string[] DoctorName = new string[10];
        static int[] DoctorId = new int[10];
        static string[] DoctorSpeciality = new string[10];
        static char[] DoctorAvailablity = new char[10];
        static int Choice;
        static string[] str = new string[2];
        static string[] str1 = new string[2];
        static int TotalNoOfDoctors = 5;
        //

        //

        static string[] TeamplayersName = new string[10];
        static string[] TeamplayersNameA = new string[10];
        static string[] TeamplayersNameB = new string[10];
        static int[] TeamplayerScorce = new int[10];
        static int[] TeamplayerScorceA = new int[10];
        static int[] TeamplayerScorceB = new int[10];
        static int AvgTeamScorce1, AvgTeamScorce2, AvgTeamScorceA, AvgTeamScorceB, MaxScorcePerTeam = 0, MaxScorceA, MaxScorceB,sum=0, TotalNoOfPlayersTeamA, TotalNoOfPlayersTeamB, TotalNosPlayers;
        static string ManOfTheTeamA = " ";
        static string ManOfTheTeamB = " ";
        static string ManOfTheTeam = " ";
        
        //


        public static void MainFuncionForCricket()
        {
            Console.WriteLine("ENTER 1 TO ENTRY PLAYERS DETAILS");
            Console.WriteLine("ENTER 2 TO VIEW PLAYERS DETAILS");
            int Input = int.Parse(Console.ReadLine());
            Console.ReadLine();
            if (Input == 1)
                WriteTeamPlayersInfo();
            else
                DisplayTeamDetails();

        }

        public static void TeamPlayersInfo(char Team)
        {
        begin:
            int AvgTeamScorce=0;
             AvgTeamScorce1 = 0;
            Console.WriteLine("ENTER THE NO OF PLAYERS YOU WANT TO ENTRY");
            TotalNosPlayers = int.Parse(Console.ReadLine());
            if (TotalNosPlayers < 11)
            {
                for (int i = 0; i < TotalNosPlayers; i++)
                {
                    Console.WriteLine("ENTER THE NAME OF THE TEAM" + Team + "PLAYER");
                    TeamplayersName[i] = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("ENTER THE SCORCE OF " + TeamplayersName[i]);
                    TeamplayerScorce[i] = int.Parse(Console.ReadLine());

                    if (TeamplayerScorce[i] > MaxScorcePerTeam)
                    {
                        MaxScorcePerTeam = TeamplayerScorce[i];
                        ManOfTheTeam = TeamplayersName[i];
                    }
                    Console.WriteLine();
                    sum += TeamplayerScorce[i];
                    AvgTeamScorce = (sum/ TotalNosPlayers);
                    int AvgTeamScorce22 = (sum / TotalNosPlayers);
                    AvgTeamScorce1 = AvgTeamScorce;
                    AvgTeamScorce2 = AvgTeamScorce22;
                }
            }
            else
            {
                Console.WriteLine("MAX VALUE SHOULD BE BELOW 11");
                goto begin;
            }
            Console.WriteLine("MAN OF THE TEAM "+Team+" IS "+ ManOfTheTeam);
            Console.WriteLine();
            
        }

        public static void WriteTeamPlayersInfo()
        {
        begin:
            Console.WriteLine("ENTER 1 FOR TEAM "+"A");
            
            Console.WriteLine("ENTER 2 FOR TEAM "+"B");
            int Readinput = int.Parse(Console.ReadLine());
            if (Readinput == 1)
            {
                TeamPlayersInfo('A');
                MaxScorceA = MaxScorcePerTeam;
                ManOfTheTeamA = ManOfTheTeam;
                TotalNoOfPlayersTeamA = TotalNosPlayers;
                AvgTeamScorceA = AvgTeamScorce1;
                Console.WriteLine("AVG OF TEAM A IS " + AvgTeamScorce1);
                AvgTeamScorceA = AvgTeamScorce1;
                for (int i=0;i< TotalNosPlayers;i++)
                {
                    TeamplayersNameA[i] = TeamplayersName[i];
                    TeamplayerScorceA[i] = TeamplayerScorce[i];
                }
            }
            else
            {
                int AvgTeamScorce2;
                TeamPlayersInfo('B');
                MaxScorceB = MaxScorcePerTeam;
                ManOfTheTeamB = ManOfTheTeam;
                TotalNoOfPlayersTeamB = TotalNosPlayers;
                AvgTeamScorce2 = AvgTeamScorce1;
                Console.WriteLine("AVG OF TEAM B IS " + AvgTeamScorce2);
                AvgTeamScorceB = AvgTeamScorce2;
                for (int i = 0; i < TotalNosPlayers; i++)
                {
                    TeamplayersNameB[i] = TeamplayersName[i];
                    TeamplayerScorceB[i] = TeamplayerScorce[i];
                }
            }
            goto begin;

        }


        public static void DisplayTeamDetails()
        {
            Console.WriteLine("\t\t\t\t\t\t\tTEAM A DETAILS");
            Console.WriteLine("PLAYER NAME OF TEAM A"+"\t\t"+ "PLAYER SCORCE OF TEAM A");
            for(int i=0; i<TotalNoOfPlayersTeamA;i++)
            {
                Console.WriteLine(TeamplayersNameA[i]+ "\t\t\t" + TeamplayerScorceA[i]);
            }
            Console.WriteLine();
            Console.WriteLine("THE AVG SCORE OF TEAM A IS " + AvgTeamScorceA);
            Console.WriteLine();
            Console.WriteLine("THE MAN OF THE TEAM IS "+ ManOfTheTeamA);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("PLAYER NAME OF TEAM B" + "\t\t" + "PLAYER SCORCE OF TEAM B");
            for (int i = 0; i < TotalNoOfPlayersTeamB; i++)
            {
                Console.WriteLine(TeamplayersNameB[i] + "\t\t\t" + TeamplayerScorceB[i]);
            }
            Console.WriteLine();
            Console.WriteLine("THE AVG SCORE OF TEAM B IS " + AvgTeamScorceB);
            Console.WriteLine();
            Console.WriteLine("THE MAN OF THE TEAM IS " + ManOfTheTeamB);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (MaxScorceA > MaxScorceB)
            {

                Console.WriteLine("MAN OF THE MATCH IS "+ManOfTheTeamA);
            }
            else
                Console.WriteLine("MAN OF THE MATCH IS " + ManOfTheTeamB);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("ENTER 1 FOR INSTITUTION");
            Console.WriteLine();
            Console.WriteLine("ENTER 2 FOR HOSPITAL");
            Console.WriteLine();
            Console.WriteLine("ENTER 3 FOR INSTITUTION");
            Console.WriteLine();
            int ReadChoice = int.Parse(Console.ReadLine());
            switch (ReadChoice)
            {
                case 1:
                    MainFunctionForInstitution();
                    break;
                case 2:
                    MainFunctionForHospital();
                    break;
                case 3:
                    MainFuncionForCricket();
                    break;
            }

        }

        public static void MainFunctionForInstitution()
        {
        begin:
            Console.WriteLine("ENTER 1 FOR ENTERING COURSE DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 2 FOR ENTERING ENQUIRER DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 3 FOR ENTERING FEE STRUCTURE DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 4 TO VIEW COURSE DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 5 TO VIEW ENQUIRER DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 6 TO VIEW DETAILS OF STUDENT WHO ALL HAVE JOINED");
            Console.WriteLine();

            Console.WriteLine("ENTER 7 TO EXIT");


            ChoiceForInstitution = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (ChoiceForInstitution)
                {
                    case 1:
                        Console.WriteLine("                         ENTER THE COURSE DETAILS FOR ALL THE BELOW");
                        Console.WriteLine();
                        WriteCourseDetails();
                        goto begin;

                    case 2:
                        Console.WriteLine("                         ENTER THE ENQUIRER DETAILS FOR ALL THE BELOW");
                        Console.WriteLine();
                        WriteEnquirerDetails();
                        goto begin;
                    case 3:

                        Console.WriteLine("                         ENTER THE FEE STRUCTURE FOR ALL THE BELOW");
                        Console.WriteLine();
                        StudentDetails();
                        WriteFeeStructureDetails();
                        goto begin;

                    case 4:
                        Console.WriteLine("                                       COURSE DETAILS ");
                        Console.WriteLine();
                        DisplayCourseDetails();
                        goto begin;

                    case 5:
                        Console.WriteLine("                                       ENQUIRER DETAILS");
                        Console.WriteLine();
                        DisplayEnquirerDetails();
                        goto begin;

                    case 6:
                        Console.WriteLine("                                 DETAILS OF STUDENT WHO ALL HAVE JOINED");
                        Console.WriteLine();
                        DisplayDetailsOfStudentJoined();
                        goto begin;

                    case 7:
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("SELECT FROM GIVEN OPTIONS");
                        goto begin;
                }
            }
        }

        public static void WriteCourseDetails()
        {
            Console.WriteLine("ENTER THE NO. OF COURSE YOU WANT TO ENTRY");
            int CourseNos = int.Parse(Console.ReadLine());
            int a = 0;
            TotalNosOfCourseAvaiable += CourseNos;
            for (int i = a; i < CourseNos; i++)
            {
                Console.WriteLine("ENTER THE NAME OF THE COURSE");
                CourseName[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE FEE AMOUNT OF THE " + CourseName[i] + " COURSE");
                Coursefee[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE DURATION OF THE " + CourseName[i] + " COURSE");
                CourseDuration[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("COURSE NAME : " + CourseName[i] + " FEES : " + Coursefee[i] + " COURSE DURATION : " + CourseDuration[i]);
            }
            a += CourseNos;
            Console.WriteLine("THE TOTAL NOS OF ENTRIES ARE " + TotalNosOfCourseAvaiable);
            Console.WriteLine();

        }

        public static void WriteEnquirerDetails()
        {
            Console.WriteLine("ENTER THE NO. OF ENQUIRES");
            int EnquiresNos = int.Parse(Console.ReadLine());
            int a = 0;
            TotalNosOfEnquires += EnquiresNos;
            for (int i = a; i < EnquiresNos; i++)
            {
                Console.WriteLine("ENTER THE NAME OF THE ENQUIRER");
                Enquirername[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE NOS. OF COURSES " + Enquirername[i] + " HAS ENQUIRED");
                NosOfCourseEnquiredPerEnquire[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE NAMES OF THE COURSES " + Enquirername[i] + " HAS ENQUIRED");
                Console.WriteLine("IF MORE THAN ONE COURSE, START WITH UNDERSCORE");
                NamesOfCourseEnquiredPerEnquire[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENQUIRER NAME : " + Enquirername[i] + " NOS. OF COURSES : " + NosOfCourseEnquiredPerEnquire[i] + " NAMES OF THE COURSES : " + NamesOfCourseEnquiredPerEnquire[i]);
            }
            a += EnquiresNos;
            Console.WriteLine("THE TOTAL NOS OF ENQUIRES ARE " + TotalNosOfEnquires);
            Console.WriteLine();
        }

        public static void WriteFeeStructureDetails()
        {

            for (int i = 0; i < TotalNosOfStudent; i++)
            {
                Console.WriteLine("TOTAL FEE TO BE COLLECTED BY " + StudentName[i] + " is " + TotalFeeToCollect[i]);
                Console.WriteLine("TOTAL FEE PAID BY " + StudentName[i] + " is " + AmountPaid[i]);
                DueAmount[i] = (TotalFeeToCollect[i] - AmountPaid[i]);
                if (DueAmount[i] > 0)
                {
                    Console.WriteLine("THE BALANCE AMOUNT IS : " + DueAmount[i]);
                }
                else
                    Console.WriteLine("PAID");

            }
        }

        public static void StudentDetails()
        {
            Console.WriteLine("ENTER THE NOS OF STUDENT YOU WANT TO ENTRY");
            int StudentNos = int.Parse(Console.ReadLine());
            int a = 0;
            TotalNosOfStudent += StudentNos;
            for (int i = a; i < StudentNos; i++)
            {
                Console.WriteLine("ENTER THE STUDENT NAME");
                StudentName[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE STUDENT ID OF" + StudentName[i]);
                StudentId[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE NOS OF COURSES " + StudentName[i] + " HAS TAKEN");
                NosOfCoursePerStudent = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE NAMES OF THOSE COURSES " + StudentName[i] + " HAS TAKEN");
                Console.WriteLine("IF MORE THAN ONE COURSE, START WITH UNDERSCORE SYMBOL");
                NamesOfCourseTakenByStudent[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("THE TOTAL FEE TO BE PAID FOR INSTITUTION BY " + StudentName[i]);
                for (int j = 0; j < NosOfCoursePerStudent; j++)
                {
                    TotalFeeToCollect[i] = (NosOfCoursePerStudent * Coursefee[j]);
                }
                Console.WriteLine("TOTAL FEE TO BE COLLECTED IS : " + TotalFeeToCollect[i]);

                Console.WriteLine("THE TOTAL FEE PAID BY " + StudentName[i]);
                AmountPaid[i] = int.Parse(Console.ReadLine());


                Console.WriteLine(" STUDENT NAME : " + StudentName[i] + " STUDENT ID : " + StudentId[i] + " NOS OF COURSES TAKEN : " +
                    NosOfCoursePerStudent + " NAMES OF THOSE COURSE : " + NamesOfCourseTakenByStudent[i]);
            }
            a += StudentNos;
            Console.WriteLine("THE TOTAL NOS OF STUDENTS IS " + TotalNosOfStudent);
            Console.WriteLine();
        }

        public static void DisplayCourseDetails()
        {
            Console.WriteLine(" COURSE NAME"+"\t\t"+ "COURSE FEE"+"\t\t"+"COURSE DURATION");
            for (int i = 0; i < TotalNosOfCourseAvaiable; i++)
            {
                Console.WriteLine(CourseName[i] + "\t\t\t" + Coursefee[i] + "\t\t\t" + "\t\t\t" + CourseDuration[i]);
            }
        }

        public static void DisplayEnquirerDetails()
        {
            Console.WriteLine(" ENQUIRER NAME"+"\t\t"+ "NOS OF COURSE ENQUIRED" + "\t\t" + "NAMES OF COURSE");
            for (int i = 0; i < TotalNosOfEnquires; i++)
            {
                Console.WriteLine(Enquirername[i] + "\t\t\t" + NosOfCourseEnquiredPerEnquire[i] + "\t\t\t" + NamesOfCourseEnquiredPerEnquire[i]);
            }

            Console.WriteLine("THE TOTAL NOS OF ENQUIRES ARE " + TotalNosOfEnquires);
        }

        public static void DisplayDetailsOfStudentJoined()
        {
            Console.WriteLine("STUDENT NAME"+"\t\t"+ "STUDENT ID" + "\t\t" + "NOS OF COURSED JOINED" + "\t\t" + "NAMES OF COURSES                DUE AMOUNT");
            for (int i = 0; i < TotalNosOfStudent; i++)
            {
                Console.WriteLine(StudentName[i] + "\t\t\t" + StudentId[i] + "\t\t\t" + NosOfCoursePerStudent + "\t\t\t" + NamesOfCourseTakenByStudent[i] + "\t\t\t" + DueAmount[i]);
            }
        }


        public static void WritingPatientDetails()
        {
            Console.WriteLine("ENTER THE NOS OF PATIENT DETAILS YOU WANT TO ENTRY");
            int PatientNos = int.Parse(Console.ReadLine());
            TotalNoOfPatient += PatientNos;
            for (int i = 0; i < PatientNos; i++)
            {
                Console.WriteLine("ENTER THE NAMES OF THE PATIENT ");
                PatientName[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE ID OF THE PATIENT " + PatientName[i]);
                PatientId[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE SYMPTOMS OF THE PATIENT " + PatientName[i]);
                Console.WriteLine("FORMAT ---->> 01_SYMPTOM OR 02_SYMPTOM OR 03_SYMPTOM");
                PatientSymptoms[i] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static void PresentDoctorDetails()
        {
            DoctorName[0] = "litesh";
            DoctorName[1] = "lites";
            DoctorName[2] = "lite";
            DoctorName[3] = "lit";
            DoctorName[4] = "li";

            DoctorId[0] = 091;
            DoctorId[1] = 092;
            DoctorId[2] = 093;
            DoctorId[3] = 094;
            DoctorId[4] = 095;

            DoctorSpeciality[0] = "01_ENT";
            DoctorSpeciality[1] = "02_NUTRITION";
            DoctorSpeciality[2] = "03_DENTIST";
            DoctorSpeciality[3] = "02_NUTRITION";
            DoctorSpeciality[4] = "03_DENTIST";

            Console.WriteLine("DOCTOR NAME"+"\t\t\t"+ "DOCTOR ID" + "\t\t\t" + " DOCTOR SPECIALITY");
            for(int i=0; i< TotalNoOfDoctors; i++)
            {
                Console.WriteLine(DoctorName[i]+"\t\t\t"+ DoctorId[i]+"\t\t\t" +DoctorSpeciality[i]);
            }
        }

        public static void NewlyJoinedDoctorDetails()
        {
            Console.WriteLine("ENTER THE NOS OF DOCTOR DETAILS YOU WANT TO ENTRY");
            int DoctorNos = int.Parse(Console.ReadLine());
            for (int i = 5; i < (DoctorNos + 5); i++)
            {
                Console.WriteLine("ENTER THE NAME OF THE DOCTOR ");
                DoctorName[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE ID OF THE DOCTOR " + DoctorName[i]);
                PatientId[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("ENTER THE SPECIALITY OF THE DOCTOR " + DoctorName[i]);
                DoctorSpeciality[i] = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("ENTER THE AVAILABLITY TIME OF THE DOCTOR " + DoctorName[i]);
                Console.WriteLine();
                Console.WriteLine("FORMAT ---->>> A - AVAILABILITY , NA - NOT AVAILABILITY");
                DoctorAvailablity[i] = char.Parse(Console.ReadLine());
                Console.WriteLine();

            }
        }

        public static void ViewPatientDetails()
        {
            Console.WriteLine("ENTER 1 IF U WANT TO VIEW ONE PATIENT DETAILS");
            Console.WriteLine();
            Console.WriteLine("ENTER 2 IF U WANT TO VIEW ALL PATIENT DETAILS");
            Console.WriteLine();
            int Option = int.Parse(Console.ReadLine());
            AssigningDoctors();
            switch (Option)
            {
                case 1:
                    Console.WriteLine("ENTER THE ID OF THE PATIENT");
                    int Id = int.Parse(Console.ReadLine());
                    for (int i = 0; i < TotalNoOfPatient; i++)
                    {
                        if (Id == PatientId[i])
                        {
                            Console.WriteLine("PATIENT NAME" + "\t\t\t" + "PATIENT ID" + "\t\t\t" + "PATIENT SYMPTOMS" + "\t\t\t" + "ASSIGNED DOCTOR");
                            Console.WriteLine(PatientName[i]+"\t\t\t"+PatientId[i] + "\t\t\t" + PatientSymptoms[i] + "\t\t\t" + AssignedDoctor[i]);
                        }

                    }
                    break;

                case 2:
                    Console.WriteLine("DETAILS OF ALL PATIENT");
                    
                    for (int i = 0; i < TotalNoOfPatient; i++)
                    {
                        Console.WriteLine("PATIENT NAME"+"\t\t\t"+ "PATIENT ID" + "\t\t\t" + "PATIENT SYMPTOMS" + "\t\t\t" + "ASSIGNED DOCTOR");
                        Console.WriteLine(PatientName[i] +"\t\t\t"+ PatientId[i] + "\t\t\t" + PatientSymptoms[i] + "\t\t\t" + AssignedDoctor[i]);
                    }
                    break;
            }
        }

        public static void ViewPatientFinalReport()
        {
            PresentDoctorDetails();
            AssigningDoctors();
            Console.WriteLine("                             FINAL REPORT");
            for (int i = 0; i < TotalNoOfPatient; i++)
            {
                Console.WriteLine("PATIENT NAME" + "\t\t\t" + "PATIENT ID" + "\t\t\t" + "PATIENT SYMPTOMS" + "\t\t\t" +"ASSIGNED DOCTOR");
                Console.WriteLine(PatientName[i] + "\t\t\t" + PatientId[i] + "\t\t\t" + PatientSymptoms[i] + "\t\t\t" + AssignedDoctor[i]);
            }
        }

        public static void AssigningDoctors()
        {
            for (int i = 0; i < TotalNoOfPatient; i++)
            {
                str[i] = PatientSymptoms[i];
                str1[i] = DoctorSpeciality[i];
                if (str[i].Substring(0, 2) == str1[i].Substring(0, 2))
                {
                    AssignedDoctor[i] = DoctorName[i];
                }
            }
        }

        public static void MainFunctionForHospital()
        {
        begin:
            Console.WriteLine("ENTER 1 FOR ENTERING PATIENT DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 2 FOR ENTERING NEWLY JOINED DOCTOR DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 3 TO VIEW PRESENT DOCTOR DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 4 TO VIEW PATIENT DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 5 TO VIEW FINAL REPORT DETAILS");
            Console.WriteLine();

            Console.WriteLine("ENTER 6 TO EXIT");

            Choice = int.Parse(Console.ReadLine());
            while (true)
            {
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("                         ENTER THE PATIENT DETAILS FOR ALL THE BELOW");
                        Console.WriteLine();
                        WritingPatientDetails();
                        goto begin;

                    case 2:
                        Console.WriteLine("                         ENTER THE NEW JOINED DOCTORS DETAILS FOR ALL THE BELOW");
                        Console.WriteLine();
                        NewlyJoinedDoctorDetails();
                        goto begin;
                    case 3:

                        Console.WriteLine("                          PRESENT DOCTOR DETAILS");
                        Console.WriteLine();
                        PresentDoctorDetails();
                        goto begin;

                    case 4:
                        Console.WriteLine("                                       PATIENT DETAILS ");
                        Console.WriteLine();
                        ViewPatientDetails();
                        goto begin;

                    case 5:
                        Console.WriteLine("                                       FINAL REPORT DETAILS");
                        Console.WriteLine();
                        ViewPatientFinalReport();
                        goto begin;
                    case 6:
                        System.Environment.Exit(1);
                        break;
                        

                    default:
                        Console.WriteLine("SELECT FROM GIVEN OPTIONS");
                        goto begin;
                }
            }
        }

    }
}




    
