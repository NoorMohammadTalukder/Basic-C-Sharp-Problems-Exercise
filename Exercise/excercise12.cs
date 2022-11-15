using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter 5 numbers.
    //If a number has been previously entered, display an error message
    //and ask the user to re-try. Once the user successfully enters 5 unique numbers,
    //sort them and display the result on the consol
    public class excercise12
    {
        public void func()
        {
            int[] numbers = new int[5];
            bool uniqueStatusFlag = true;

            Console.WriteLine("Enter 5 numbers");
            //numbers[0] = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < numbers.Length; i++)
            {
                int number=int.Parse(Console.ReadLine());
                

                for(int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[j] == number)
                    {
                        Console.WriteLine("re-try");
                        uniqueStatusFlag = false;
                        break;
                    }
                }
                numbers[i] = number;

                if (uniqueStatusFlag==false)
                {
                    break;
                }



            }

            if (uniqueStatusFlag == true)
            {
                foreach(var x in numbers)
                {
                    Console.Write(x+" ");
                }
            }
        }
    }
}
