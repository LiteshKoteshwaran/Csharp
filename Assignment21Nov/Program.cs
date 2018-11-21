using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21Nov
{
    class Program
    {
        int EmpID, EmpSalary;
        string EmpName;
        float SalaryAfterHike;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Dispaly();
        }
        void Entries()
        {
            SalaryAfterHike = 0;
            Console.WriteLine("Enter the Employee ID");
            EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Emp Nmae");
            EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Employee salary");
            EmpSalary = int.Parse(Console.ReadLine());
        }
        void Dispaly()
        {
            Entries();
            SalesMan salesMan = new SalesMan(EmpID, EmpName, EmpSalary);
            salesMan.Display();
            SalaryAfterHike = salesMan.HikeCalForSalesMan();
            Console.WriteLine("salary after hike :"+SalaryAfterHike);

            Entries();
            Manger manger = new Manger(EmpID, EmpName, EmpSalary);
            manger.Display();
            SalaryAfterHike = manger.HikeCalForManger();
            Console.WriteLine("salary after hike :" + SalaryAfterHike);
        }

    }
    class Employee
    {
        internal int _EmpID;
        internal int _EmpSalary;
        internal string _EmpName;
        
        int EmpID { get { return _EmpID; } }
        int EmpSalary { set { EmpSalary = value; }get { return EmpSalary; } }
        string EmpName { get { return _EmpName; } }

        public Employee() { }
        public Employee(int Empid,string EmpName,int EmpSalary)
        {
            _EmpID = Empid;
            _EmpName = EmpName;
            _EmpSalary = EmpSalary;
        }
        public void Display()
        {
            Console.WriteLine("Emp Name :"+ _EmpName+"Emp ID :"+_EmpID+"Emp Salary :"+_EmpSalary);
        }
            
    }

    class SalesMan : Employee
    {
        float hike =0;
        int SalesManSalary;
        
        public SalesMan(int Empid, string EmpName, int Empsalary): base(Empid, EmpName, Empsalary)
        { SalesManSalary = Empsalary; }

        public float HikeCalForSalesMan()
        {
            hike = SalesManSalary + 1000;
            return hike = (float)(hike * 10);
        }
    }

    class Manger : Employee
    {
        public float hike;
        public int MangerSalary;

        public Manger(int Empid, string EmpName, int Empsalary) : base(Empid, EmpName, Empsalary)
        { MangerSalary = Empsalary; }

        public float HikeCalForManger()
        {
            hike = MangerSalary + 1000;
            return hike = (float)(hike * 20);
        }
    }
}
