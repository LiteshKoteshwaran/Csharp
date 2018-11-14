using System;

namespace _14Nov_Practice
{
    class Person
    {
        public int Age;
        public String Name;

        public virtual void EnterPersonDetails()
        {
            Console.WriteLine("what is your name");
            Name = Console.ReadLine();
            Console.WriteLine("what is your age");
            Age = int.Parse(Console.ReadLine());
        }  //to over ride this methods in its child's class i have to use Virtual keyword 
    }


    class Parent : Person
    {
        public String Game;
        public char ChildGender;
        public override void EnterPersonDetails() //over ridden method, have to use Override keyword 
        {
            Console.WriteLine("what is your name");
            Name = Console.ReadLine();
            Console.WriteLine("what game do u play");
            Sport();
        }
        public void Sport()
        {
            Console.WriteLine("hey i am parent and i play cricket");
        }

        public virtual void AskForGender()
        {
            Console.WriteLine("what gender is your child");
            ChildGender=char.Parse(Console.ReadLine());
        }

    }

    class Child : Parent
    {
        public void ChildDetails()
        {
            EnterPersonDetails();
            Console.WriteLine("do u have a child, say 1 for yes or 0 for no");
            int Input = int.Parse(Console.ReadLine());
            if (Input == 1)
                AskForGender();
            else
                Console.WriteLine("ok");
        }
        public new void AskForGender()//new method, which means this AskForGender() method is opposing inheritance   
        {
            Console.WriteLine("what gender is your child");
            ChildGender = char.Parse(Console.ReadLine());
        }
    }

    class Mmain
    {
        public static void Main()
        {
            Person person = new Person();
            Parent parent = new Parent();
            Child child = new Child();

            Person p = new Parent();//In this line and  
            Person p1 = new Child();//this line, i have created object for Parent and child using its BASE class(Person)
            //----->> Child child = new Parent(); 
            //Compile time error
            //coz variable child should be base class type 
            begin:
            Console.WriteLine("enter what you are, if parent press 1 if child print 2");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                person = new Parent();
                //----->> person.ParentDetails(); 
                //compile time error 
                //cant give Person referance coz Person class dont have ParentDetails method 
                parent.Age = 20;
            }
            if(input == 2)
            {
                child = new Child();
                child.ChildDetails();
                child.Age=20;//child class is not inheriting Person Class but it is able to acess Age which is in Person class
                //coz child is inheriting Parent and Parent is Inheriting Person

                Parent p123 = new Child();
                p123.AskForGender();/// here Parent's class AskForGender() is being called
            }
            goto begin;
        }
    }
}
namespace newOne
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:
            Person Person;
            Console.WriteLine("Enter 1 for user input");
            Console.WriteLine("Enter 2 to view designer given details");
            Console.WriteLine("Enter 3 exit");
            int Input = int.Parse(Console.ReadLine());
            if (Input == 1)
            {
                Person = new Person();
                Person.EnterPersonDetails();
                Person.CreatePersonID();
                Person.DisplayPersonDetails();
            }
            else if (Input == 2)
            {
                Person = new Person("Litesh", 096, "9036213630");
                Person.DisplayPersonDetails();
            }
            else if (Input == 4)
            {
                Person = new Person("Litesh");
                Person.DisplayPersonDetails();
            }
            if (Input == 3)
            {
                Environment.Exit(0);
            }
            Console.ReadLine();

            goto begin;
        }
    }

    class Person
    {
        string PersonName, PersonContactNo;
        int PersonID;

        public Person(string Name, int ID, string ContactNo)
        {
            PersonName = Name;
            PersonID = ID;
            PersonContactNo = ContactNo;
        }
        public Person(string Name)
        {
            PersonName = Name;
        }
        public Person() { }

        public string Name { get { return this.Name; } }

        public int ID { get { return this.ID; } }

        public void EnterPersonDetails()
        {
            Console.WriteLine("ENTER THE PERSON NAME");
            PersonName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("ENTER THE PERSON CONTACT NUMBER");
            PersonContactNo = Console.ReadLine();
            Console.WriteLine();
        }

        public void CreatePersonID()
        {
            PersonID = int.Parse(PersonContactNo.Substring(0, 2));
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("THE NAME IS " + PersonName);
            Console.WriteLine("THE CONTACT NO IS " + PersonContactNo);
            Console.WriteLine("THE ID IS " + PersonID);
        }
    }
}