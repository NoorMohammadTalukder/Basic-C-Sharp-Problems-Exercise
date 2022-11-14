using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    //Your job is to write a program for a speed camera.
    //    For simplicity, ignore the details such as camera, sensors, etc 
    //    and focus purely on the logic.
    //    Write a program that asks the user to enter the speed limit.
    //    Once set, the program asks for the speed of a car.
    //    If the user enters a value less than the speed limit,
    //    program should display Ok on the console.
    //    If the value is above the speed limit,
    //    the program should calculate the number of demerit points.
    //    For every 5km/hr above the speed limit, 
    //    1 demerit points should be incurred and displayed on the console.
    //    If the number of demerit points is above 12, 
    //    the program should display License Suspended.
    public class excercise4
    {
        public void func()
        {
            Console.WriteLine("enter the speed limit");
            float speedLimit=float.Parse(Console.ReadLine());

            Console.WriteLine("enter the speed of a car");
            float carSpeed=float.Parse(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                float demeritPoint = carSpeed / 5;
                Console.WriteLine(demeritPoint + " demerit point");

                if(demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }

        }
    }
}
