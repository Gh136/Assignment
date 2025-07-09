using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assiginment__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion


            #region 2- Write a program that allows the user to insert an integer the print a multiplication table up to 12.

            //Console.WriteLine("Enter an integer to print its multiplication table: ");
            //int multiplier = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{multiplier} x {i} = {multiplier * i}");
            //}
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("enter a Numer");
            //int number_ = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= number_; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //// Convert the string to a char array, reverse it, and create a new string
            //char[] charArray = input.ToCharArray();

            //Array.Reverse(charArray);
            //string reversed = new string(charArray);

            //Console.WriteLine("Reversed string: " + reversed);
            #endregion


            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.

            Console.WriteLine("enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            n = n * -1;
            Console.WriteLine($"the reversed number : {n}");

            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.Test Data : Input starting number of ranges: 1 Input ending number of range: 50V Expected Output : The prime number between 1 and 50 are:2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //Console.WriteLine("Enter starting number of range: ");
            //int startRange = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter ending number of range: ");
            //int endRange = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Prime numbers between {startRange} and {endRange}:");
            //for (int num = startRange; num <= endRange; num++)
            //{
            //    bool isPrime = true;
            //    if (num < 2) isPrime = false; // 0 and 1 are not prime numbers
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array Test Data :Enter a number to convert: 25 Expected Output : The Binary of 25 is 11001.

            //Console.Write("Enter a number to convert: ");
            //int num_ = Convert.ToInt32(Console.ReadLine());

            //string binary = "";

            //if (num_ == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    while (num_ > 0)
            //    {
            //        int remainder = num_ % 2;
            //        binary = remainder + binary; // prepend the digit
            //        num_ = num_ / 2;
            //    }
            //}

            //Console.WriteLine($"The Binary of {num_} is {binary}.");

            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n_ = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"The {n}x{n} identity matrix is:\n");

            //for (int i = 0; i < n_; i++) // rows
            //{
            //    for (int j = 0; j < n_; j++) // columns
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }

            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); // new line after each row
            //}

            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.WriteLine("enter the size of the array");
            //int size = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the elements of the array");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"element {i + 1}: ");
            //    int element = Convert.ToInt32(Console.ReadLine());
            //    if (i == 0)
            //    {
            //        Console.WriteLine($"The sum of the elements in the array is: {element}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The sum of the elements in the array is: {element + i}");
            //    }
            //}

            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];
            //int[] mergedArray = new int[size * 2];

            //// Input first array
            //Console.WriteLine("Enter elements of the first array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //// Input second array
            //Console.WriteLine("Enter elements of the second array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //// Merge the two arrays
            //for (int i = 0; i < size; i++)
            //{
            //    mergedArray[i] = array1[i];
            //    mergedArray[i + size] = array2[i];
            //}

            //// Sort the merged array in ascending order
            //Array.Sort(mergedArray);

            //// Display the result
            //Console.WriteLine("Merged and sorted array:");
            //foreach (int num in mergedArray)
            //{
            //    Console.Write(num + " ");
            //}
            #endregion
            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int[] freq = new int[n];  // To store frequency
            //int visited = -1;

            //// Input array elements
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Count frequency
            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] == visited)
            //        continue;

            //    int count = 1;
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            freq[j] = visited;
            //        }
            //    }
            //    freq[i] = count;
            //}
            //// Display frequencies
            //Console.WriteLine("\nFrequency of each element:");
            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i] != visited)
            //    {
            //        Console.WriteLine($"{arr[i]} occurs {freq[i]} time(s)");
            //    }
            //}
            #endregion
            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //// Input array elements
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Initialize max and min
            //int max = arr[0];
            //int min = arr[0];

            //// Find max and min
            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //// Display result
            //Console.WriteLine($"\nMaximum element = {max}");
            //Console.WriteLine($"Minimum element = {min}");

            #endregion
            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //Console.Write("Enter the number of elements in the array (minimum 2): ");
            //int n = int.Parse(Console.ReadLine());

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must have at least two elements.");
            //    return;
            //}

            //int[] arr = new int[n];

            //// Input array elements
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //// Find largest and second largest
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = arr[i];
            //    }
            //    else if (arr[i] > secondLargest && arr[i] != largest)
            //    {
            //        secondLargest = arr[i];
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //{
            //    Console.WriteLine("There is no second largest element (all elements may be equal).");
            //}
            //else
            //{
            //    Console.WriteLine($"The second largest element is: {secondLargest}");
            //}
            #endregion
            #region 17-. Consider an Array of Integer values with size N, having values as 

            //Console.Write("Enter number of elements: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //// Step 2: Input array elements
            //Console.WriteLine("Enter the elements:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Step 3: Dictionary to store the first index of each element
            //Dictionary<int, int> firstIndexMap = new Dictionary<int, int>();
            //int maxDistance = -1;
            //int repeatedValue = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int value = arr[i];

            //    if (!firstIndexMap.ContainsKey(value))
            //    {
            //        // Save the first occurrence
            //        firstIndexMap[value] = i;
            //    }
            //    else
            //    {
            //        // Calculate distance between current and first index (excluding both)
            //        int distance = i - firstIndexMap[value] - 1;
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //            repeatedValue = value;
            //        }
            //    }
            //}

            //// Step 4: Print result
            //if (maxDistance >= 0)
            //{
            //    Console.WriteLine($"\nThe longest distance is {maxDistance} cell(s), between two '{repeatedValue}' values.");
            //}
            //else
            //{
            //    Console.WriteLine("No repeated values found.");
            //}
            #endregion
            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            // Input elements into the first array
            Console.WriteLine("\nEnter elements for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element at ({i}, {j}): ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copy first array to second array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            // Print the second array
            Console.WriteLine("\nSecond array after copying:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

        }
    }
}
