using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    class Student:Person
    {
        int StudentID;
        int NosOfCoursedSelected;

        public void EnterStudentDetails()
        {
            Console.WriteLine("ENTER STUDENT DETAILS");
            EnterPersonDetails();
            CreatePersonID();
            StudentID = PersonID;
            Console.WriteLine("ENTER THE NOS OF COURSE SELECTED");
            NosOfCoursedSelected = int.Parse(Console.ReadLine());
            JoinedCourse[] joinedCourses = new JoinedCourse[NosOfCoursedSelected];
            Course[] courses = new Course[NosOfCoursedSelected];
          
        }
        public void DisplayStudentDetails()
        {

        }
    }
}
