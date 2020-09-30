using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line();
            line1.userInput();
            Double length1 = line1.getLength();
            Console.WriteLine("Length of line 1 is : "+length1);

            Line line2 = new Line();
            line2.userInput();
            Double length2 = line2.getLength();
            Console.WriteLine("Length of line 2 is : " + length2);

            line1.compareToFunction(length1, length2);
        }
    }
}