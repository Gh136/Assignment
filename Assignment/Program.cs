using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region 2.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive

            //Console.WriteLine("Please enter an integer:");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}

            #endregion

            #region 3. Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.WriteLine("please enter the first number");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the second number");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the third number");
            //int number3 = Convert.ToInt32(Console.ReadLine());

            //// Finding the maximum and minimum numbers
            //int maxNum = Math.Max(number1, Math.Max(number2, number3));
            //int minNum = Math.Min(number1, Math.Min(number2, number3));

            //// Printing the results
            //Console.WriteLine($"The maximum value is: {maxNum}");
            //Console.WriteLine($"The minimum value is: {minNum}");
            #endregion

            #region 4. Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Please enter an integer:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            #endregion
            #region  5.Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.WriteLine("please enter a char");
            //char character = Convert.ToChar(Console.ReadLine());
            //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ||
            //    character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion
            #region 10 - Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("please enter the first number");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the second number");
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the third number");
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the 4th number");
            //int number4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the 5th number");
            //int number5 = Convert.ToInt32(Console.ReadLine());

            //int sum = number1 + number2 + number3 + number4 + number5;
            //Console.WriteLine("Total: " + sum);
            //double average = sum / 5.0;
            //Console.WriteLine("Average: " + average);

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.

            //int month;

            //// Asking user for the month number
            //Console.Write("Enter the month number (1-12): ");
            //month = Convert.ToInt32(Console.ReadLine());

            //// Determining the number of days in the month
            //switch (month)
            //{
            //    case 1: // January
            //    case 3: // March
            //    case 5: // May
            //    case 7: // July
            //    case 8: // August
            //    case 10: // October
            //    case 12: // December
            //        Console.WriteLine("31 days");
            //        break;
            //    case 4: // April
            //    case 6: // June
            //    case 9: // September
            //    case 11: // November
            //        Console.WriteLine("30 days");
            //        break;
            //    case 2: // February
            //        Console.WriteLine("February has 28 or 29 days depending on the year.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number! Please enter a number between 1 and 12.");
            //        break;
            //}
            #endregion

            #region 12- Write a program to create a Simple Calculator.

            double result;
            // Taking first number as input
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Taking second number as input
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Asking the user to select an operation
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add (+)");
            Console.WriteLine("2. Subtract (-)");
            Console.WriteLine("3. Multiply (*)");
            Console.WriteLine("4. Divide (/)");
            Console.Write("Enter operation (e.g., +, -, *, /): ");
            string operation = Console.ReadLine();

            // Perform the calculation based on the operation chosen
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose a valid operation.");
                    break;
            }

            #endregion
        }
    }
}
