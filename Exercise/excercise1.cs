using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class excercise1
    {
        //Write a program and ask the user to enter a number.
        //The number should be between 1 to 10. If the user enters a valid number, 
        //display "Valid" on the console.
        //Otherwise, display "Invalid".
        //(This logic is used a lot in applications where values 
        //entered into input boxes need to be validated.)
        public void func()
        {
            Console.WriteLine("Enter a number between 1 to 10");
            float num = float.Parse(Console.ReadLine());

            if ((num.GetType() == typeof(float) || num.GetType() == typeof(int)) && (num >= 1 && num <= 10))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
          
        }
    }
}
