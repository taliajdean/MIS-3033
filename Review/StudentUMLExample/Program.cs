﻿using System;

namespace StudentUMLExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.FirstName = "Talia";
            myStudent.LastName = "Dean";
            myStudent.IsOnProbation = false;
            myStudent.SoonerID = 5;

            Console.WriteLine(myStudent);

            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);
            myStudent.MakePayment(50);
            Console.WriteLine();
            Console.WriteLine(myStudent);
            myStudent.MakePayment(500);
            Console.WriteLine();
            Console.WriteLine(myStudent);
        }
    }
}
