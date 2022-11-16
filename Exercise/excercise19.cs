using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter an English word.
    //Count the number of vowels (a, e, o, u, i) in the word.
    //So, if the user enters "inadequate", the program should display 6 on the console.
    public class excercise19
    {
        public void func()
        {
            Console.WriteLine("Enter a word");
            var input=Console.ReadLine();

            int count = 0;
            foreach(var x in input)
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
