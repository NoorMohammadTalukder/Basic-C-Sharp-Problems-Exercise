using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Write a program that reads a text file and displays the longest word in the file.
    public class excercise21
    {
        public void func()
        {
            var path = @"D:\C# Excercise\Exercise\file_1.txt";
            var maxWord="";
            var maxLength = 0;
            var count = 0;
            if (File.Exists(path))
            {
                var word="";
                var fileData = File.ReadAllText(path);
                for (int i=0;i<fileData.Length; i++)
                {
                    if (fileData[i].ToString() != " " )
                    {
                        word = word+ fileData[i].ToString();
                        count++;
                        maxLength = count;
                        maxWord = word;
                    }
                    else if(fileData[i].ToString() == " ")
                    {
                        word = "";
                        count = 0;
                    }
                }
                Console.WriteLine("File Data: " + fileData );
                Console.WriteLine("Longest Word: "+ maxWord+"\nLength: "+maxLength);
            }
            else
            {
                Console.WriteLine("No File exists");
            }
        }
    }
}
