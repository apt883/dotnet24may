using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{   
    abstract class BasicCalci
    {
        public int AddTwoNumbers(int num1, int num2)
        {
            return num1+num2;
        }
        public abstract int MultiplyTwoNumbers(int num1, int num2);
    }
    class Derived:BasicCalci
    {
        public override int MultiplyTwoNumbers(int num1,int num2)
        {
            return num1 * num2;
        }
    }
    class Class4
    {
        static void Main4(string[] args)
        {
            Derived d = new Derived();
            Console.WriteLine("Addition : {0}\nMultiplication :{1}", d.AddTwoNumbers(4, 6), d.MultiplyTwoNumbers(6, 4));
            Console.ReadLine();
        }
    }
}
