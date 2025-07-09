using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{

    internal class Program
    {
       public double Sum( int[] arr, int lenghth)
        {
            double sum = 0;
            for (lenghth = 0; lenghth < arr.Length; lenghth++)
            {
                sum += arr[lenghth];
            }
            return sum;
        }
        public double Expectedsum(int[] arr, int lenghth)
        {
            double expectedsum = 0;
            for (lenghth = 0; lenghth < arr.Length; lenghth++)
            {
                expectedsum += lenghth;
            }
            return expectedsum;
        }
        public double MissingNumber(int[] arr, int lenghth)
        {
            double expectedSum = Expectedsum(arr, lenghth);
            double actualSum = Sum(arr, lenghth);
            return expectedSum - actualSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size : ");
            int size = Convert.ToInt32(Console.ReadLine());
           int[] elemets = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter the element " + (i + 1) + " : ");
                elemets[i] = Convert.ToInt32(Console.ReadLine());
            }
         double missingNumber = new Program().MissingNumber(elemets, size);
            if (missingNumber == 0)
            {
                Console.WriteLine("There is no missing number in the array");
            }
            else
            {
                Console.WriteLine("The missing number in the array is : " + missingNumber);
            }
        }
    }
}
