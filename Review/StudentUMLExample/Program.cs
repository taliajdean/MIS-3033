using System;

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
            Console.WriteLine();
            myStudent.MakePayment(500);
            Console.WriteLine(myStudent);
            myStudent.MakePayment(50);
            Console.WriteLine();
            Console.WriteLine(myStudent);
            
            try
            {
                myStudent.MakePayment(-500);
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID PAYMENT");
            }

            Console.WriteLine();

            Console.WriteLine(myStudent);
        }
    }
}
