using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1- Explain the difference between passing (Value type  parameters) by value and by reference then write a suitable c#  example

            #endregion
            #region 2- Explain the difference between passing (Reference type  parameters) by value and by reference then write a suitable c#  example. egion

            #endregion

            #region 3- Write a c# Function that accept 4 parameters from user and  return result of summation and subtracting of two numbers 

            void SumFourElement()
            {


                Console.WriteLine("Enter the first number:");
                int x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the third number:");
                int x3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the fourth number:");
                int x4 = Convert.ToInt32(Console.ReadLine());

                int sum = x1 + x2;
                int subtract = x3 - x4;

                Console.WriteLine($"Sum of first two numbers: {sum}");
                Console.WriteLine($"Subtraction of last two numbers: {subtract}");
            }

            SumFourElement();

            #endregion

            #region 4- Write a program in C# Sharp to create a function to calculate the sum of  the individual digits of a given number.Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7
            void sumOfDigits(int num)
            {
                int sum = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num /= 10;
                }
                Console.WriteLine($"The sum of the digits is: {sum}");

            }
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            sumOfDigits(number);

            #endregion

            #region 5- Create a function named "IsPrime", which receives an integer number  and retuns true if it is prime, or false if it is not:
            bool IsPrime(int num)
            {
                bool isPrime = true;
                if (num <= 1)
                {
                    return false; // 0 and 1 are not prime numbers
                }
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;

            }
            Console.WriteLine("Enter a number to check if it's prime:");
            int primeNumber = Convert.ToInt32(Console.ReadLine());
            bool result = IsPrime(primeNumber);
            Console.WriteLine(result ? "The number is prime." : "The number is not prime.");
            #endregion


            #region 6- Create a function named MinMaxArray, to return the minimum and  maximum values stored in an array, using reference parameters 
            void MinMaxArray(int[] arr, ref int min1, ref int max1)
            {
                if (arr.Length == 0)
                {
                    Console.WriteLine("Array is empty!");
                    return;
                }

                min1 = arr[0];
                max1 = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min1)
                        min1 = arr[i];
                    if (arr[i] > max1)
                        max1 = arr[i];
                }
            }
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = 0;
            int max = 0;

            MinMaxArray(numbers, ref min, ref max);

            Console.WriteLine($"\nMinimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            #endregion


            #region 7- Create an iterative (non-recursive) function to calculate the factorial  of the number specified as parameter 
            long Factorial(int number_)
            {
                long result_ = 1;

                for (int i = 2; i <= number_; i++)
                {
                    result_ *= i;
                }

                return result_;
            }


            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = Factorial(input);
                Console.WriteLine($"The factorial of {input} is: {factorial}");
            }

            #endregion

            #region 8- Create a function named "ChangeChar" to modify a letter in a certain  position (0 based) of a string, replacing it with a different letter
             string ChangeChar(string input1, int position1, char newChar1)
            {
                if (position1 < 0 || position1 >= input1.Length)
                {
                    Console.WriteLine("Invalid position.");
                    return input1;
                }

                char[] chars = input1.ToCharArray();
                chars[position1] = newChar1;
                return new string(chars);
            }

            
                Console.Write("Enter a string: ");
                string input_ = Console.ReadLine();

                Console.Write("Enter the position of the character to replace (0-based): ");
                int position = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the new character: ");
                char newChar = Convert.ToChar(Console.ReadLine());

                string _result = ChangeChar(input_, position, newChar);

                Console.WriteLine($"Modified string: {_result}");
            
            #endregion


        }
    }
}
