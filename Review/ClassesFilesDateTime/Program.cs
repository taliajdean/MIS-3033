﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace ClassesFilesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            Console.WriteLine($"The area of rect1 is {rect1.area()}");
            rect1.height = 10;
            rect1.width = 20;

            Rectangle rect2 = new Rectangle(5, 2);

           // Console.WriteLine($"The area of rect1 is {rect1.area()}");
            //Console.WriteLine($"The area of rect1 is {rect2.area()}");

            List<Rectangle> rectangles = new List<Rectangle>();
            //Add existing rectangles to the List
            rectangles.Add(rect1);
            rectangles.Add(rect2);

            //Add a rectangle that is not yet created yet
            rectangles.Add(new Rectangle(7, 7));

            foreach (var rect in rectangles)
            {
                Console.Write(rect);
                Console.WriteLine($"The area of the rectangle is {rect.area()}");
            }
        }
    }
}
