using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program to count how many numbers between 1 and 100 
    //    are divisible by 3 with no remainder.Display the count on the console.


    public class excercise5
    {
        public void func()
        {
            int count = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                    continue;
                }
              
               
            }
            Console.WriteLine(count);
        }
    }
}
