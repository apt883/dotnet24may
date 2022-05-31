using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class5
    {
        //value type and reference type

        static void Main5(string[] args)
        {
            int x = 5;
            int y = 6;
            Console.WriteLine("Before swaping \n a=" + x + "  b=" + y);
            Swap(ref x, ref y);
            Console.WriteLine("After swaping \n a=" + x + "  b=" + y);
            int result;
            sample(10, out result);
            Console.WriteLine("out value \n s="+result);
             var p = 1;
            dynamic p1 = 5;
            p1 = "avinash";
                 Console.WriteLine(p1);
                 Console.WriteLine(p);
        }
        static void Swap(ref int a,ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a=" + a + "  b=" + b);
            Console.ReadLine();

        }
        static void sample(int z,out int s)
        {
            s = z + 1;
        }
    }
}
