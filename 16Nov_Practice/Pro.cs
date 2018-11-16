using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Nov_Practice
{
    //interface should be public it can't be any modifier except 
    public interface IInterface
    {
        void Hey();
        //even methods should be public
    }

    interface IInter//default it will be internal
    {
        void Hai();
    }

    // class default will be internal
    public class Person
    {
        int NOsOfBackLogs;
        public int Age;
        public string Name;
        internal int Weigth;
        protected String FatherName;
        //internal protected and protected internal are same 
        internal protected string Gender;


        // method
        public virtual void PrintPerson()
        {
        }

    }
    public class Employee : Person, IInterface, IInter
    {
        // overriding method of IInterface
        void Hey()
        {
            Console.WriteLine("Hey");
        }

        // override method of Person
        public override void PrintPerson()
        {
            base.PrintPerson();

            FatherName = "Abc";
            Console.WriteLine(FatherName);
        }

        // override method of ITestImplement
        public void Hai()
        {
            Console.WriteLine("Implementing interface method : TestIt()");
        }

        void IInterface.Hey()
        {
            Console.WriteLine("IInterface.Hey()");
        }
    }

    //internal class : illustrating different access modifiers for its members
    class Details
    {
 
        Person p1 = new Person();

        // variables
        public int Id;
        //double Salary;
        internal string designation;

        //public static void test()
        //{
        //    p1.Age = 21;

        //}
    }

    class Pro
    {
        static void Main(string[] args)
        {
            //public class
            Person p1 = new Person();

            p1.Age = 21;            
            p1.Name = "Somaa";   
            p1.Weigth = 72;         // variable is internal
            //p1.Height = 6;        // as variable is declared private it gives error
            //p1.FatherName = " ";  // as variable is declared protected it gives error
            p1.PrintPerson();
            p1.Gender = "";
            p1.Age = 22;

            //internal class
            Details d1 = new Details();

            d1.designation = "Singer";
            d1.Id = 860;               
            //d1.Salary = 1;     
            //as variable is declared private it gives error
            Employee e1 = new Employee();
            // inherited variables
            e1.Name = "Litesh";         
            e1.Age = 21;                
            e1.Weigth = 65;             
            Console.WriteLine();

        }
    }
}