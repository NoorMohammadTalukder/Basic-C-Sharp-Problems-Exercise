using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program that reads a text file and displays the number of words.
    public class excercise20
    {
        public void func()
        {
            var path = @"D:\C# Excercise\Exercise\file_1.txt";
            var count = 0;
            if (File.Exists(path))
            {
                var fileData = File.ReadAllText(path);
                foreach(var item in fileData)
                {
                    if(item.ToString()==" ")
                    {
                        count++;
                    }
                }

                Console.WriteLine("File Data: "+fileData +"\nTotal Words: "+(count + 1));
            }
            else
            {
                Console.WriteLine("No File exists");
            }  
        }
    }
}
