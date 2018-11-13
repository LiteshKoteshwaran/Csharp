using System;

namespace _13NOV2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }




    class Enquirer
    {
        string[] EnquirerName, EnquirerContactNo;
        int[] NosOfCoursesIntrested;
        string[] NamesOfCoursesIntrested;

        public void EntryEnquirerDetails(int NosOfStudentJoined)
        {
            for(int i=0; i< NosOfStudentJoined; i++)
            {
                Console.WriteLine("ENTER THE NAME ");
                EnquirerName[i] = Console.ReadLine();

                Console.WriteLine("ENTER THE CONTACT NUMBER ");
                EnquirerContactNo[i] = Console.ReadLine();

                Console.WriteLine("ENTER THE NOS OF COURSES INTRESTED");
                NosOfCoursesIntrested[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("ENTER THE NAME OF THE COURSES ENQUIRED");
                NamesOfCoursesIntrested[i] = Console.ReadLine();
            }
        }
        public void DispalyEnquirerDetails()
        {
            for()
        }

    }

    class Student:Enquirer
    {
        int NosOfStudentJoined;
        int[] StudentID;

        public void EntryStudentDetails()
        {
            Console.WriteLine("ENTER THE NOS OF STUDENT JOINED INSTITUTION");
            NosOfStudentJoined = int.Parse(Console.ReadLine());
            for(int i=0; i< NosOfStudentJoined; i++)
            {
                EntryEnquirerDetails(NosOfStudentJoined);
            }
        }

        public void DispalyJoinedStudentDetails()
        {

        }
    }

    class Institute
    {
        
    }


    class Person
    {
        public string PersonName, PersonContactNo;

        public void EnterPersonDetails()
        {
            Console.WriteLine("ENTER THE PERSON DETAILS");

        }
    }

    class Patient:Person
    {
        string PatientName,PatientContactNo, PatientProfession, DoctorAssigned;
        int PatientID;
        string[] PatientSymtomps;

        public void EntryPatientDetails()
        {
            EnterPersonDetails();
        }
    }

    class Doctor : Person
    {
        string DoctorName, DoctorContactNo;
        int PatientID;
        string[] PatientSymtomps;

        public void EntryPatientDetails()
        {

        }
    }
}
