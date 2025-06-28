using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that allows the user to enter a number then print it.
            int number;
            Console.WriteLine("Please Enter the Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Number You Entered is : " + number);
            #endregion
            #region Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            int cnvertedNumber;
            Console.WriteLine("Please Enter the String : ");
            cnvertedNumber = Convert.ToInt32(Console.ReadLine()); //System.FormatException: 'Input string was not in a correct format.'
            Console.WriteLine("The Number You Entered is : " + cnvertedNumber);
            #endregion
            #region Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float num1, num2, result;
            Console.WriteLine("Please Enter the First Number : ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number : ");
            num2 = Convert.ToSingle(Console.ReadLine());
            result = num1 + num2; // You can change the operation to -, *, or / as needed
            Console.WriteLine("The Result of the Operation is : " + result);
            // If the user enters a non-numeric value, it will throw a System.FormatException
            #endregion
            #region Write C# program that Extract a substring from a given string.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("Enter the start index: ");
            int startIdx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size to abstract: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (startIdx >= 0 && size >= 0 && startIdx + size <= input.Length)
            {
                string extracted = input.Substring(startIdx, size);
                Console.WriteLine("Extracted substring: " + extracted);
            }
            else
            {
                Console.WriteLine("Invalid start index or size.");
            }
            #endregion
            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int a = 10;
            int b = a; // b is assigned the value of a
            Console.WriteLine("Before modification: a = " + a + ", b = " + b);
            a = 20; // Modifying a does not affect b
            Console.WriteLine("After modification: a = " + a + ", b = " + b);
            // Output will be:
            // Before modification: a = 10, b = 10
            // After modification: a = 20, b = 10
            a = 30;
            Console.WriteLine("After another modification: a = " + a + ", b = " + b);
            // Output will be:
            // After another modification: a = 30, b = 10
            #endregion
            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point p1 = new Point();
            p1.x = 10;
            p1.y = 5;
            Point p2 = p1; // p2 references the same Point object as p1
            Console.WriteLine("Before modification: p1.x = " + p1.x + ", p1.y = " + p1.y + "p2.x = " + p2.x + ", p2.y = " + p2.y);
            p1.x = 20; // Modifying p1 affects p2 since they reference the same object
            Console.WriteLine("After modification: p1.x = " + p1.x + ", p1.y = " + p1.y + "p2.x = " + p2.x + ", p2.y = " + p2.y);
            #endregion
            #region Write C# program that take two string variables and print them as one variable
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            string combined = str1 + str2;

            Console.WriteLine("Combined string: " + combined);
            #endregion
            #region Which of the following statements is correct about the C#.NET code snippet given below?
            int d;
            d = Convert.ToInt32(!(30 < 20));
            // The correct answer is: d = 1; // The expression !(30 < 20) evaluates to true, which is converted to 1.
            Console.WriteLine("The value of d is: " + d);

            #endregion
            #region Which of the following is the correct output for the C# code given below?
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // The correct output is: 6 1
            // Explanation: 13 / 2 performs integer division, resulting in 6, and 13 % 2 gives the remainder, which is 1.
            #endregion
            #region 10-What will be the output of the C# code given below?

            int num = 1, z = 5;
            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            // The output will be: 7 7
            else
                Console.WriteLine(--num + z-- + " " + --z);

            #endregion

        }
    }
}
