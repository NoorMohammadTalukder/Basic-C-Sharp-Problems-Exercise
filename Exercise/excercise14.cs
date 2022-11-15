using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to supply 
    //    a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
    //    If the list is empty or includes less than 5 numbers, 
    //    display "Invalid List" and ask the user to re-try; 
    //    otherwise, display the 3 smallest numbers in the list.
    public class excercise14
    {
        public void func()
        {
            char[] delimiterChars = { ' ', ','};
            string[] separatingStrings = { ", " };

            Console.WriteLine("enter a list of comma separated numbers(e.g 5, 1, 9, 2, 10)");
            string input=Console.ReadLine();

            //string[] seperatedInput = input.Split(separatingStrings);
            string[] seperatedInput = input.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            if (seperatedInput.Length < 5)
            {
                Console.WriteLine("Invalid List \nre-try");

            }
            else
            {
                Array.Sort(seperatedInput);
                int count = 0;
                foreach (var i in seperatedInput)
                {
                    Console.Write(i+" ");
                    count++;
                    if (count >= 3)
                    {
                        break;
                    }
                }
            }
            
        }
    }
}
