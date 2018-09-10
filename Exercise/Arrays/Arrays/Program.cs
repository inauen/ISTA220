using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            start();
        }

        public static void start()
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };            int[] arrayB = { 1, 3, 5, 7, 9 };            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };            int[] newArray = new int[0];                        Console.WriteLine("Which array would you like to use:");            Console.WriteLine("1 - Array A");            Console.WriteLine("2 - Array B");            Console.WriteLine("3 - Array C");            int ArraySelected = Convert.ToInt32(Console.ReadLine());            Console.WriteLine("What would you like to do with an array:");            Console.WriteLine("1 - Find the Mean, Sum, and amount of elements in the array");            Console.WriteLine("2 - Reverse the array");            Console.WriteLine("3 - Rotate array");            Console.WriteLine("4 - Sort array");            int modifyInput = Convert.ToInt32(Console.ReadLine());            Console.WriteLine("");
            switch (modifyInput)
            {
                case 1:
                    if (ArraySelected == 1) calculations(arrayA);
                    else if (ArraySelected == 2) calculations(arrayB);
                    else if (ArraySelected == 3) calculations(arrayC);
                    break;
                case 2:
                    if (ArraySelected == 1) reverse(arrayA);
                    else if (ArraySelected == 2) reverse(arrayB);
                    else if (ArraySelected == 3) reverse(arrayC);
                    break;
                case 3:
                    Console.WriteLine("Do you want to move right or left:");
                    string direction = Console.ReadLine();
                    Console.WriteLine("\n How many spaces?");
                    int spaces = Convert.ToInt32(Console.ReadLine());
                    if (ArraySelected == 1) rotate(spaces,direction,arrayA);
                    else if (ArraySelected == 2) rotate(spaces,direction,arrayB);
                    else if (ArraySelected == 3) rotate(spaces,direction,arrayC);

                    start();
                    break;
                case 4:
                    if (ArraySelected == 1) newArray = sort(arrayA);
                    else if (ArraySelected == 2) newArray = sort(arrayB);
                    else if (ArraySelected == 3) newArray = sort(arrayC);
                    Console.WriteLine();
                    Console.Write("The new array looks like ");
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        Console.Write($" {Convert.ToString(newArray[i])} ");
                    }

                    Console.WriteLine("\n");
                    start();
                    break;
                default:
                    break;
            }
        }

        private static int[] sort(int[] newArray)
        {

            for (int i = 0; i < newArray.Length - 1; i++)
            {
                if (newArray[i] > newArray[i + 1])
                {
                    int temp = newArray[i];
                    int temp2 = newArray[i + 1];

                    newArray[i] = temp2;
                    newArray[i + 1] = temp;
                    sort(newArray);
                }


            }

           

            return newArray;
        }

        private static void rotate(int spaces, string direction, int[] newArray)

        {
            Console.WriteLine("");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{Convert.ToString(newArray[i])} ");
            }
            Console.WriteLine("");
            if (direction == "left")
            {
                int[] rightArray = new int[newArray.Length - spaces];
                for (int i = spaces, j = 0; i < newArray.Length; i++, j++)
                {
                    rightArray[j] = newArray[i];
                    Console.Write($"{Convert.ToString(rightArray[j])} ");
                }
                for (int i = spaces, j = 0; i < newArray.Length; i++, j++)
                {
                    newArray[i] = newArray[j];
                }
                for (int i = 0; i < rightArray.Length; i++)
                {
                    newArray[i] = rightArray[i];
                }

                
            }

            if (direction == "right")
            {
                int[] temp = new int[newArray.Length];

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = newArray[i];
                }

                for (int i = 0, j = temp.Length - spaces; j < temp.Length; i++, j++)
                {
                    newArray[i] = temp[j];
                }

                for (int i = spaces, j = 0; i < newArray.Length; i++, j++)
                {
                    newArray[i] = temp[j];
                }

                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.Write($"{Convert.ToString(newArray[i])} ");
                }
                Console.WriteLine("");


            }


        }

        private static void reverse(int[] choosenArray)
        {
            int[] newArray = new int[choosenArray.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = choosenArray[i];
                Console.Write($"{Convert.ToString(choosenArray[i])} ");
            }

            for (int i = 0, j = newArray.Length - 1; i < j; i++, j--)
            {
                int spare = newArray[i];
                int spare2 = newArray[j];

                newArray[i] = spare2;
                newArray[j] = spare;


            }
            Console.WriteLine();
            Console.Write("The new array looks like ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($" {Convert.ToString(newArray[i])} ");
            }
            Console.WriteLine("\n");
            
            start();

        }

        private static void calculations(int[] choosenArray)
        {
            int sum = 0;
            double mean = 0.0;
            
            Console.WriteLine($"There are {choosenArray.Length} elements in the array");

            for (int i = 0; i < choosenArray.Length; i++)
            {  
                Console.Write($"{Convert.ToString(choosenArray[i])}, ");
                sum = choosenArray[i] + sum;
            }
            Console.WriteLine();
            Console.WriteLine($"The Sum of the array is {sum}");
            mean = Convert.ToDouble(sum) / choosenArray.Length;
            Console.WriteLine($"The averge/mean of the array is {mean: 0.##}");

            start();

        }


    }
}
