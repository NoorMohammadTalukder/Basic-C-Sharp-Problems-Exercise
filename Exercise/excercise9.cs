using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter a series of numbers separated by comma.
    //    Find the maximum of the numbers and display it on the console.
    //    For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    public class excercise9
    {
        int[] numbers;
       

        public void func()
        {
            Console.WriteLine("a series of numbers separated by comma");
            //string c = "1,9,3,6,5";
            string c=Console.ReadLine();
           
            numbers = new int[c.Length];

            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] != ',')
                {
                    numbers[i] = c[i];
                    //Console.WriteLine((char)c[i]);
                }
            }

            int max = numbers[0];

            for(int j=0;j<numbers.Length; j++)
            {
                if(numbers[j] > max)
                {
                    max = numbers[j];
                    continue;
                }
            }

            Console.WriteLine((char)max);
           

            
        }
    }
}
