using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter a few words separated by a space.
    //Use the words to create a variable name with PascalCase.For example,
    //if the user types: "number of students", display "NumberOfStudents".
    //Make sure that the program is not dependent on the input.So,
    //if the user types "NUMBER OF STUDENTS", the program should
    //still display "NumberOfStudents".
    public class excercise18
    {
        public void func()
        {
            
            Console.WriteLine("Enter few words");
            var input=Console.ReadLine();
            var allInput=input.ToLower();
            string newWord = "";
        
            for(var i=0; i< allInput.Length; i++)
            {
                if (i == 0)
                {
                    var toUpper = (allInput[0].ToString()).ToUpper();
                    newWord =toUpper;
                }
                else
                {
                    if (allInput[i].ToString() != " ")
                    {
                        newWord = (newWord + allInput[i]).ToString();
                    }
                    else
                    {
                        var toUpper = (allInput[i+1].ToString()).ToUpper();
                        newWord = newWord + toUpper;
                        i = i + 1;
                    }
                }
                
                
                
            }

            foreach(var word in newWord)
            {
                Console.Write(word);
            }
        }
    }
}
