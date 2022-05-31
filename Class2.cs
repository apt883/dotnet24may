using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class2
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int n = Convert.ToInt32(Console.ReadLine());
            //public int factorial(int)
            int fact = n;
            for (int i = 1; i < n; i++)
            {
                 fact=fact*(n-i);
            }
            Console.WriteLine("factorial of given number is " + fact);
            Console.ReadLine();
        }
    }
     
    
    
}


