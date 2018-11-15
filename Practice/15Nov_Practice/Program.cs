using System;

namespace _15Nov_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class Person
    {

        int Age;
        String Name, ContactNo;

        public abstract int age { get; }
        public abstract string name { get; }
        public abstract string contactno { get; }

    }
    class Parent : Person
    {

        /*public int age = 20;*/
        public override int age => 22;

        public override string name => "litesh";

        public override string contactno => "9036213630";


    }



}
namespace Option
{
    class Person
    {
        int Age;
        string Name;

        public virtual void EnterPersonDetails()
        {
            Console.WriteLine("Person class : Name and age");
        }
    }

    abstract class Parent : Person
    {
        string ContactNO;

        public override void EnterPersonDetails()
        {
            base.EnterPersonDetails();// base KEY WORD is used so that there wont be any ambiguity between base method and overridden method

            Console.WriteLine("Parent class : contact no. ");
        }

        public abstract void CanBeDoctor();
        public abstract void CanBeEngineer();
    }

    abstract class Child : Parent
    {
        public override void EnterPersonDetails()
        {
            Console.WriteLine("child class : some more info ");
            base.EnterPersonDetails();
        }
        //public abstract void CanBeDoctor();
        public override void CanBeEngineer()
        {
            Console.WriteLine("i am child one and i am an Engineer");
        }
    }

    class MainClass:Child
    {
        public static void Main()
        {

            MainClass mainClass = new MainClass();
            mainClass.EnterPersonDetails();
            Console.ReadLine();
        }

        public override void CanBeDoctor()
        {
            throw new NotImplementedException();
        }
    }
}



