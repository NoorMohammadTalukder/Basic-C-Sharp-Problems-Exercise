using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program that picks a random number between 1 and 10. 
    //    Give the user 4 chances to guess the number.
    //    If the user guesses the number, display “You won"; 
    //    otherwise, display “You lost". 
    //    (To make sure the program is behaving correctly, you 
    //    can display the secret number on the console first.)
    public class excercise8
    {
        public void func()
        {
            bool winningFlag=false;

            Random rnd = new Random();
            int num = rnd.Next(1,10);
            Console.WriteLine(num);

            Console.WriteLine("Guess the number between 1 and 10 \nYou have 4 chances");

            for(int i = 0; i <= 3; i++)
            {
                Console.Write("Guess "+(i+1)+":");
                int input=int.Parse(Console.ReadLine());

                if (input == num)
                {
                    Console.WriteLine("You win");
                    winningFlag=true;
                    break;
                }
                
            }

            if (winningFlag == false)
            {
                Console.WriteLine("You lost");
                
            }
        }
    }
}
