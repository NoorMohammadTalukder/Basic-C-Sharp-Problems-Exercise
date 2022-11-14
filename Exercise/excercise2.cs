using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program which takes two numbers from the console and
    //    displays the maximum of the two.
    public class excercise2
    {
        public void func()
        {
            Console.WriteLine("Enter two number");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine(a + " is Maximum");
            }
            else
            {
                Console.WriteLine(b + " is Maximum");
            }
        }
    }
}
