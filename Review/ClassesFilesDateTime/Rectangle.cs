using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesFilesDateTime
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }

        public DateTime creationDate { get; set; }
        

        /// <summary>
        /// This is a default/empty constructor
        /// </summary>
        public Rectangle()
        {
            width = 0;
            height = 0;
            creationDate = DateTime.Now; 
        }

        /// <summary>
        /// Overloaded Constructor for the Rectangle Class
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Rectangle(int width, int height) : this()
        {
            this.width = width;
            this.height = height;
            creationDate = DateTime.Now;

        }
       
        /// <summary>
        /// Calculate the area of the Rectangle
        /// </summary>
        /// <returns></returns>
        public double area()
        {
            return width * height;
        }
        public override string ToString()
        {
            var diff = DateTime.Now - creationDate;
            string output = $"The rectangle was created {diff.TotalSeconds} ago & has a width of {width} and height of {height}" +
                $"\n\tThe area of the rectangle is {area()}";
            
            return output;
        }
    }
}
