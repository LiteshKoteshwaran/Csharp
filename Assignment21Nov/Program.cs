using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21Nov
{
    class Program
    {
        

        static void Main(string[] args)
        {
            SalesMan salesMan = new SalesMan();
            Manger manger = new Manger();


            salesMan.ForSalesMan();
            salesMan.Display();
            Console.WriteLine("the salary after hike is :" + salesMan.hike);
            manger.ForManger();
            manger.Display();
            Console.WriteLine("the salary after hike is :" + manger.hike);

            Console.ReadLine();
        }

    }
    class Employee
    {
        int _EmpID;
        public int EmpSalary;
        string _EmpName;
        
        int EmpID { get { return _EmpID; } }
        string EmpName { get { return _EmpName; } }

        public Employee() { }
        public Employee(int Empid,string EmpName,int Empsalary)
        {
            _EmpID = Empid;
            _EmpName = EmpName;
            this.EmpSalary = Empsalary;
        }
        public void Enterdetails()
        {
            Console.WriteLine("Enter the Employee ID");
            int Empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Emp Nmae");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Employee salary");
            int Empsalary = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("name :"+ _EmpName + "id :"+ _EmpID +"salary :"+ EmpSalary);
        }
            
    }

    class SalesMan : Employee
    {
        public double hike;
        public int SalesManSalary;
        
        public void EnterSalesManDetails()
        {
            Enterdetails();
            SalesManSalary = EmpSalary;
        }
        public SalesMan(int Empid, string EmpName, int Empsalary): base(Empid, EmpName, Empsalary)
        { }
        public SalesMan() { }
        public void ForSalesMan()
        {
            Console.WriteLine("Enter the Details of Employee");
            EnterSalesManDetails();
            hike = SalesManSalary + 1000;
            hike = hike * .1;

        }
    }

    class Manger : Employee
    {
        public double hike;
        public int MangerSalary;

        public void EnterMangerDetails()
        {
            Enterdetails();
            MangerSalary = EmpSalary;
        }
        public Manger(int Empid, string EmpName, int Empsalary) : base(Empid, EmpName,Empsalary)
        { }
        public Manger() { }
        public void ForManger()
        {
            Console.WriteLine("Enter the Details of Employee");
            EnterMangerDetails();
            hike = MangerSalary + 1000;
            hike = hike * .2;
        }
    }
}
