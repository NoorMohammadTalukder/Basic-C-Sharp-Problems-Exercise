using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter a number.
    //    Compute the factorial of the number and 
    //    print it on the console.For example, 
    //    if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
    //    and display it as 5! = 120.
    public class excercise7
    {
        public void func()
        {
            int factorial = 1;
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                factorial = factorial * i;
                continue;
            }
            Console.WriteLine(num + "! = " + factorial);


        }
    }
}
