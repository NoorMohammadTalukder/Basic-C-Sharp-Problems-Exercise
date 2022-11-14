using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and continuously ask the user 
    //    to enter a number or "ok" to exit.Calculate the sum 
    //    of all the previously entered numbers and display it on the console.
    public class excercise6
    {
        public void func()
        {
            float sum = 0;
            while (true)
            {
                Console.WriteLine("Enter number or type ok to exit");
                string getInput=Console.ReadLine();

                if (getInput=="ok")
                {
                    break;
                }
                else
                {
                    float num=float.Parse(getInput);
                    sum+=num;
                    continue;
                }
            }
            Console.WriteLine("Summation: "+sum);
        }
    }
}
