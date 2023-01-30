using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //program to print maximum number in array of first 10 digits
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            int maxNumber = numbers[0];
            for(int i =0; i < numbers.Length; i++)
            {
                if(numbers[i] > maxNumber)
                {
                    maxNumber=numbers[i];
                }
            }
            Console.WriteLine("The maximum number is "+ maxNumber);

            //program to print an alternate number from an array
            int[] altnumber = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            Console.WriteLine("The alternate number in given array :");
            for(int i = 0; i < numbers.Length; i += 2)
            {
                Console.WriteLine(altnumber[i]);
            }
            //program to reverse an array of 5 numbers
            int[] reversenum = { 10, 20, 30, 40, 50 };
            int left = 0;
            int right = reversenum.Length - 1;
            while (left < right)
            {
                int temp = reversenum[left];
                reversenum[left] = reversenum[right];
                reversenum[right] = temp;
                left++;
                right--;
            }

            Console.WriteLine("Reversed array:");
            foreach (int num in reversenum)
            {
                Console.WriteLine(num);
            }
            //remove given element from array, mark that element as zero
            int[] allnum = { 1, 2, 3, 4, 5};
            int removenum = 4;
            for(int i=0;i<= allnum.Length; i++)
            {
               if(allnum[i] == removenum)
                {
                    allnum[i] = 0;
                    break;
                }

            }
            Console.WriteLine("Array after removing number :" + removenum);
            foreach(int num1 in allnum)
            {
                Console.WriteLine(num1);
            }
            //check if given number is armstrong or not
            int number = 153;
            int originalNumber = number;
            int result = 0;
            int n = 0;

            while (originalNumber != 0)
            {
                originalNumber /= 10;
                n++;
            }

            originalNumber = number;

            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                result += (int)Math.Pow(remainder, n);
                originalNumber /= 10;
            }

            if (result == number)
            {
                Console.WriteLine(number + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong number");
            }
            //program to generate fibonacci series 0,1,1,2,3,5,8,..k, where k <n entered by the user
            Console.WriteLine("Enter the number to generate fibonacci series");
            int x = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            Console.WriteLine("The Fiboancci series upto " + x + " is:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < x; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                if (c >= x)
                {
                    break;
                }
            }
            //program to accept a and b and find ab
            Console.WriteLine("Enter the first number: ");
            int u = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int v = Convert.ToInt32(Console.ReadLine());

            int result1 = u * v;
            Console.WriteLine("The value of a * b is: " + result1);
            //program to calculate factorial of a number
            Console.WriteLine("Enter a number to calculate its factorial: ");
            int factorialnum = Convert.ToInt32(Console.ReadLine());

            int result2 = 1;
            for (int i = 1; i <= factorialnum; i++)
            {
                result2 = result2 * i;
            }

            Console.WriteLine("The factorial of " + factorialnum + " is " + result2);
            //creating array of 10 integers accept the value from user and find the count of entered num in an array
            int[] arr = new int[] { 1, 2, 3, 4, 1, 2, 4, 5, 6, 1 };
            Console.WriteLine("Enter a number to find its count in the array: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == userNumber)
                {
                    count++;
                }
            }

            Console.WriteLine("The number " + userNumber + " appears " + count + " times in the array.");
            //sort array of 5 integers
            int[] no = new int[5] { 9, 5, 2, 7, 1 };
            Console.WriteLine("Before sorting: ");
            foreach (int num4 in no)
            {
                Console.Write(num4 + " ");
            }
            Console.WriteLine();

            Array.Sort(no);

            Console.WriteLine("After sorting: ");
            foreach (int num5 in no)
            {
                Console.Write(num5 + " ");
            }
            Console.WriteLine();
        }
    }
}
