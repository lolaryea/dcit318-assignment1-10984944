﻿using System;
//Laryea Leslie Otoo 10984944
namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 70 && grade <= 89)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 50 && grade <= 59)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
