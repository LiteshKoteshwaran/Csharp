using System;
using System.Collections.Generic;
using System.Text;

namespace _13Nov
{
    class Course
    {
        public string Name, Duration;
        public int Fee;

        public void CourseDetails()
        {
            Console.WriteLine("ENTER THE COURSE NAME");
            Name = Console.ReadLine();
            Console.WriteLine("ENTER THE COURSE DURATION");
            Duration = Console.ReadLine();
            Console.WriteLine("ENTER THE FEE AMOUNT");
            Fee = int.Parse(Console.ReadLine());
        }
    }
}
