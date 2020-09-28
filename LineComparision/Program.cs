using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            string []input = new string[4];
            int[] x = new int[2];
            int[] y = new int[2];
            Console.WriteLine("Enter x1,y1,x2 and y2");
            for(int i = 0; i < 4; i++)
            {
                input[i] = Console.ReadLine();
                if (i % 2 == 0)
                {
                    x[i / 2] = Convert.ToInt32(input[i]);
                }
                else
                {
                    y[i / 2] = Convert.ToInt32(input[i]);
                }
            }
            Console.WriteLine("Length of the first line is : ");
            int length = (int)Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0]));
            Console.WriteLine(length);

            string[] input2 = new string[4];
            int[] xx = new int[2];
            int[] yy = new int[2];
            Console.WriteLine("Enter xx1,yy1,xx2 and yy2");
            for (int i = 0; i < 4; i++)
            {
                input2[i] = Console.ReadLine();
                if (i % 2 == 0)
                {
                    xx[i / 2] = Convert.ToInt32(input2[i]);
                }
                else
                {
                    yy[i / 2] = Convert.ToInt32(input2[i]);
                }
            }
            Console.WriteLine("Length of the second line is : ");
            int length2 = (int)Math.Sqrt((xx[1] - xx[0]) * (xx[1] - xx[0]) + (yy[1] - yy[0]) * (yy[1] - yy[0]));
            Console.WriteLine(length2);

            if (length.Equals(length2))
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equal");
            }

        }
    }
}