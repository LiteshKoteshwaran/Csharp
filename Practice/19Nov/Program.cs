using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Nov
{
    class Program
    {
        int age; string name, Contactno;
        Doctor[] doctor = new Doctor[10];
        static int NosOfEntries;

        static void Main(string[] args)
        {
            int i=0;
            Program program = new Program();
            Console.WriteLine("Enter the no of entries");
            NosOfEntries = int.Parse(Console.ReadLine());
            program.Entries();
            program.doctor[i].DisplayDoctorDetails();i++;
            Console.ReadLine();
        }

        public void Entries()
        {
            for (int j = 0; j < NosOfEntries; j++)
            {
                try
                {
                    Console.WriteLine("Enter the name");
                    string name_ = Console.ReadLine();
                    if (name_ == null)
                    {
                        throw new MyException("name should not be null");
                    }
                    else name = name_;
                    Console.WriteLine("Enter the Age");
                    int age_ = int.Parse(Console.ReadLine());
                    if (age_ <= 23)
                    {
                        throw new MyException("Age should be greater than 23");
                    } else age = age_;
                    Console.WriteLine("Enter the Contact number");
                    string Contactno_ = Console.ReadLine();
                    if (Contactno_ == null)
                    {
                        throw new MyException("contact number should not be null");
                    }
                    else Contactno = Contactno_;
                }

                catch(MyException e)
                {
                    Console.WriteLine("From custom Excepition");
                    Console.WriteLine(e.Message);
                    string path = @"D:\log\MyFirstExceptionLOgFile.txt";
                    using (StreamWriter sw = System.IO.File.AppendText(path))
                    {
                        sw.WriteLine("From custom Excepition ,"+e.Message,e.StackTrace,e.TargetSite);
                    }
                }
            
                catch(Exception e) 
                {
                    Console.WriteLine("From system Excepition");
                    Console.WriteLine(e.Message);
                    string path = @"D:\log\MyFirstExceptionLOgFile.txt";
                    using (StreamWriter sw = System.IO.File.AppendText(path))
                    {
                        sw.WriteLine("From custom Excepition ," + e.Message, e.StackTrace, e.TargetSite);
                    }
                }
                doctor[j] = new Doctor(age, name, Contactno);
            }
        }


    }
    public class Person
    {
        int _Age;
        string _Name, _ContactNo;

        public int Age { get { return this._Age; } }
        public string Name { get { return this._Name; } }
        public string ContactNo { get { return this._ContactNo; } }

        public Person() { }
        public Person(int age, string name, string contactno)
        {
                _Age = age;
                _Name = name;
                _ContactNo = contactno;
        }

        public void DisplayEntries()
        {
            Console.WriteLine(_Name+"\t\t\t\t"+_Age+"\t\t\t\t"+_ContactNo);
        }

    }

    public class Doctor : Person
    {
        int DoctorID;
        public void CreateID()
        {
            string DoctorContactNo = ContactNo;
            DoctorID = int.Parse(DoctorContactNo.Substring(0, (DoctorContactNo.Length - 3)));
        }

        public Doctor(int age, string name, string contactno) : base(age, name, contactno)
        {
        }

        public void DisplayDoctorDetails()
        {
            DisplayEntries();
        }
    }


    [Serializable]
    public class MyException : Exception
    {
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }


    }
}
