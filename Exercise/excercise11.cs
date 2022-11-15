using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter their name.
    //    Use an array to reverse the name and then store the result in a new string. 
    //    Display the reversed name on the console.
    public class excercise11
    {
        public void func()
        {
            Console.WriteLine("Enter Your name");
            string name=Console.ReadLine();

            char[] NameArray = new char[name.Length];
            int j = 0;
            for (int i = (name.Length - 1); i >= 0; i--)
            {
                NameArray[j] =name[i];
                j++;
            }
            foreach(var x in NameArray)
            {
                Console.Write(x);
            }


        }
    }
}
