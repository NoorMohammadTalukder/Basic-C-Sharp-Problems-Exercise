using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter a few numbers separated by a hyphen.
    //    Work out if the numbers are consecutive. 
    //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16",
    //    display a message: "Consecutive"; otherwise, display "Not Consecutive".
    public class excercise15
    {
        public void func()
        {
            Console.WriteLine("enter a few numbers separated by a hyphen. For example 5 - 6 - 7 - 8 - 9");
            var input = Console.ReadLine();
            var splitedInput = input.Split('-');
            var numbers = new List<int>();

            foreach(var i in splitedInput)
            {
                numbers.Add(Convert.ToInt32(i));
            }
            //Console.WriteLine(numbers[1]);

            var consecutiveFlag = true;

            if (numbers[0] > numbers[1])
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers[i + 1] + 1)
                    {
                        consecutiveFlag = false;
                        break;
                    }
                    if (i == numbers.Count - 2)
                    {
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                   
                    if (numbers[i] != numbers[i + 1] - 1)
                    {
                        consecutiveFlag = false;
                        break;
                    }
                    if (i == numbers.Count-2)
                    {
                        break;
                    }
                }
            }
            if (consecutiveFlag == true)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }

        }
    }
}
