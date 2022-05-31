using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] a = new int[10];
            int i, j, count = 0;
            Console.WriteLine("program to copy one array");
            for(i=0;i<10;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("the first array contains ");
            Console.WriteLine();
            for(i=0;i<10;i++)
            {
                Console.Write("{ 0}", a[i]);
            }
            Console.WriteLine();
            for (i = 0; i < 10; i++)
            {
                for (j =i+1 ; j < 10; j++)
                {
                    if (a[i]==a[j])

                    {
                        count++;
                        break;
                    }

                }
            }

        }
    }
}


