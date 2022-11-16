using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter a time value
    //in the 24-hour time format(e.g. 19:00).
    //A valid time should be between 00:00 and 23:59.
    //If the time is valid, display "Ok"; otherwise, display "Invalid Time".
    //If the user doesn't provide any values, consider it as invalid time.
    public class excercise17
    {
       public void func()
       {
            var validStausFlag = true;

            Console.WriteLine("enter a time value n the 24-hour time format(e.g. 19:00)");
            var input=Console.ReadLine();

            if (input =="")
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Int32.Parse(input[0].ToString() + input[1].ToString());
            var minute = Int32.Parse(input[3].ToString() + input[4].ToString());

            if(hour < 0 || hour > 23)
            {
                validStausFlag = false;
            }
            else if(minute<0 || minute > 59)
            {
                validStausFlag = false;
            }
            else if (input[2].ToString() !=":")
            {
                validStausFlag = false;
            }
                
            Console.WriteLine(validStausFlag? "Ok" : "Invalid Time");

       }
    }
}
