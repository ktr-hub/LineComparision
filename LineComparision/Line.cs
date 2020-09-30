using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparision
{
    class Line
    {
        int[] x = new int[2];
        int[] y = new int[2];
        Double length;

        public void userInput()
        {
            Console.WriteLine("Enter end point coordinates as x1, y1, x2 and y2");
            for (int i = 0; i < 4; i++)
            {
                string[] input = new string[4];
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
        }
        public Double getLength()
        {
            length = Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0]));
            return length;
        }

        public void compareToFunction(Double length1,Double length2)
        {
            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("Both lines are equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 2 is greater than Line 1");
            }
        }

    }
}
