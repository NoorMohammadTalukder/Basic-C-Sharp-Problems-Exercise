using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program and ask the user to enter the width and height of an image.
    //    Then tell if the image is landscape or portrait.
    public class excercise3
    {
        public void func()
        {
            Console.WriteLine("enter the width and height of the image");

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("portrait image");
            }
            else
            {
                Console.WriteLine("landscape image");
            }

        }
    }
}
