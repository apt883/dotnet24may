using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class3
    {
        static void Main3(string[] args)
        {
            Class3.EvenNumber(30);
        }
        public static void EvenNumber(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
        
    }
          
    
}
