using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
    //The list of numbers may include duplicates. 
    //Display the unique numbers that the user has entered.
    public class excercise13
    {
        public void func()
        {
            List<int> numbers = new List<int>();
            List<int> uniqueNumbers = new List<int>();

            Console.WriteLine("continuously enter a number or type Quit to exit");
            while (true)
            {
                string input = Console.ReadLine();
              
                if (input == "Quit")
                {
                    break;
                }
                numbers.Add(int.Parse(input));

            }

            
            
            for(int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                for(int j=0; j < numbers.Count; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniqueNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine("Your entered numbers are: ");
            foreach(var x in numbers)
            {
                
                Console.Write(x+" ");
            } 
            
            Console.WriteLine("\nUnique numbers are: ");
            foreach(var x in uniqueNumbers)
            {
                
                Console.Write(x+" ");
            }
        }
    }
}
