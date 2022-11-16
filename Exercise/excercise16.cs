using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter a few numbers separated by a hyphen.
    //If the user simply presses Enter, without supplying an input, exit immediately; 
    //otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.
    public class excercise16
    {
        public void func()
        {
            var numbers= new List<int>();
            var dubplicateStatusFlag = false;

            Console.WriteLine("enter a few numbers separated by a hyphen (ex:1-2-3-4)");
            var input=Console.ReadLine();
            if(input=="")
            {
                return;
            }

            var spiltedInput=input.Split('-');

            foreach(var i in spiltedInput)
            {
                numbers.Add(int.Parse(i));
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                int count = 0;

                for(int j = 0; j < numbers.Count; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        count++;
                    }

                    if (count > 1)
                    {
                       
                        dubplicateStatusFlag=true;
                        break;
                    }
                    
                }

                if (dubplicateStatusFlag == true)
                {
                    break;
                }
            }

            Console.WriteLine(dubplicateStatusFlag==true? "Duplicate": "Not Duplicate");
            
        }
    }
}
