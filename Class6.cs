using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee
    {
        public string Name;
        public int Id;
        public string Company;
        private string school;

        public Employee()
        {
           string school = "rgms";
        }
        public void GetData()
            
        {
            Console.WriteLine("please enter employee details");
            Console.WriteLine("please enter employee Name");
           Name= Console.ReadLine();
            Console.WriteLine("please enter employee id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter employee company");
            Company = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine("Employee details are");
            Console.WriteLine(Name);
            Console.WriteLine(Id);
            Console.WriteLine(Company);
            Console.WriteLine(school); ;

        }
    }
    
    
    class Class6
    {
        static void Main6(string[] args)
        {
            Employee e1 = new Employee();
            //e1.Name = "avinash";
            //e1.Id = 100;
            //e1.Company = "jbl";
            //Console.WriteLine("Employee details are");
            //Console.WriteLine(e1.Name);
            //Console.WriteLine(e1.Id);
            //Console.WriteLine(e1.Company);
            //Console.ReadLine();
            //e1.GetData();
            //e1.PrintData();
            //Array of objects
            Employee[] Emplist = new Employee[3];
            for(int i =0;i<Emplist.Length;i++)
            {
                Employee s = new Employee();
                s.GetData();
                Emplist[i] = s;
            }
            for (int i = 0; i < Emplist.Length; i++)
            {
               
                Emplist[i].PrintData();
                Console.ReadLine();
            }

        }
    
            
    }
}
