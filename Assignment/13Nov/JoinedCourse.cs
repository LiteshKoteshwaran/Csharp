using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    class JoinedCourse:Course
    {
        DateTime JoinedDate;
        public void EntryCourseDetails()
        {
            CourseDetails();
            Console.WriteLine("ENTER THE JOINED DATED FOR THE COURSE : "+Name);
            Console.WriteLine("FORMAT -->> ");
            JoinedDate = DateTime.Parse(Console.ReadLine());
        }
            
    }
}
