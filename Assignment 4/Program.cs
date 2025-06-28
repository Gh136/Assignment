using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Point
{
    public double X;
    public double Y;

}

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //    Point point1 = new Point();
            //    Point point2 = new Point();
            //    Point point3 = new Point();
            //    Console.WriteLine("Enter coordinates of three points:");


            //    Console.Write("x1: ");
            //    point1.X = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y1: ");
            //    point1.Y = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("x2: ");
            //    point2.X = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y2: ");
            //    point2.Y = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("x3: ");
            //    point3.X = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("y3: ");
            //    point3.Y = Convert.ToDouble(Console.ReadLine());

            //    if ((point2.Y - point1.Y) * (point3.X - point2.X) == (point3.Y - point2.Y) * (point2.X - point1.X))
            //    {
            //        Console.WriteLine("The points lie on the same straight line.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The points do NOT lie on the same straight line.");
            //    }
            //}


            #endregion

            #region  Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined

            Console.WriteLine("enter the duration required to complete the task");
            double duration = Convert.ToDouble(Console.ReadLine());
            if (duration < 3)
            {
                Console.WriteLine("The worker is efficient.");
            }
            else if (duration >= 3 && duration <= 4)
            {
                Console.WriteLine("the worker instructed to increase his speed.");
            }
            else if (duration > 4 && duration <= 5)
            {
                Console.WriteLine("The worker is  provided with training to enhance his speed..");
            }
            else
            {
                Console.WriteLine("the worker must leave the company.");
            }
            #endregion

      

        }

    }
}