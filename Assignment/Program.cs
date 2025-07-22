using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Arrays

            #region Q1

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];

            //}

            //Console.WriteLine(sum);

            #endregion

            #region Q2

            //const int size = 3; // for simplicity but we can take all information from user

            //int[] arr01 =  [3,1,2];  

            //int[] arr02 = [6, 4, 5];

            //int[] MergedArray = new int [2 * size] ;
            //for (int i = 0; i < size; i++)
            //{
            //    MergedArray[i] = arr01[i];
            //    MergedArray[i + size] = arr02[i];
            //}

            //Array.Sort(MergedArray);

            //for (int i = 0; i < 2*size; i++)
            //{

            //    Console.Write(MergedArray[i] + " ");

            //}

            //Console.WriteLine();


            #endregion

            #region Q3
            // Assume numbers from 0 to 5 for simplicity

            //int[] numbers = {0, 1, 1, 3, 4, 3,5,2,2,3,5,4,5 };
            //int[] frequency = new int [5+1] ;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    frequency[numbers[i]]++;
            //}

            //for (int i = 0; i < frequency.Length; i++)
            //{
            //    Console.WriteLine($"Number {i} occurs {frequency[i]} times.");
            //}

            #endregion


            #region Q4
            //int[] numbers = [1, 2, 5, 4, 3, 0, 6];

            //int min = numbers[0];
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > max)
            //        max = numbers[i];

            //    if (numbers[i] < min)
            //        min = numbers[i];
            //}

            //Console.WriteLine("Minimum element: " + min);
            //Console.WriteLine("Maximum element: " + max);


            #endregion


            #region Q5


            //int[] numbers = [2, 5, 6, 4, 1, 3];

            //int max1 = int.MinValue;
            //int max2 = int.MinValue;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] >= max1)
            //    {
            //        max2 = max1;
            //        max1 = numbers[i];
            //    }
            //    else if (numbers[i] > max2 )
            //    {
            //        max2 = numbers[i];
            //    }


            //}

            //Console.WriteLine($"The Second largest numbers is {max2}");


            #endregion


            #region Q6,Q7

            //Console.Write("Enter number of elements: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n < 2) //for distance>0
            //{
            //    Console.Write("Enter a valid number (>= 2): ");
            //}

            //int[] arr = new int[n];


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.Write("Invalid input. Enter an integer: ");
            //    }
            //}

            //int maxDistance = 1;


            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = n - 1; j > i; j--)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; 
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //            break; 
            //        }
            //    }
            //}

            //Console.WriteLine("Longest distance between two equal elements: " + maxDistance);

            #endregion



            #region Q8

            //Console.Write("Enter a sentence: ");
            //string? input = Console.ReadLine();

            //Console.WriteLine(string.Join(" ", input?.Split(' ').Reverse()));

            #endregion


            #region Q9
            //int rows, cols;


            //Console.Write("Enter number of rows: ");
            //while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
            //{
            //    Console.Write("Enter a valid positive number for rows: ");
            //}

            //Console.Write("Enter number of columns: ");
            //while (!int.TryParse(Console.ReadLine(), out cols) || cols <= 0)
            //{
            //    Console.Write("Enter a valid positive number for columns: ");
            //}

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];


            //Console.WriteLine("Enter values for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i+1},{j+1}]: ");
            //        while (!int.TryParse(Console.ReadLine(), out firstArray[i, j]))
            //        {
            //            Console.Write("Invalid input. Enter an integer: ");
            //        }
            //    }
            //}


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}


            //Console.WriteLine("\nSecond array ");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + "    ");
            //    }
            //    Console.WriteLine();
            //}
            //// rather than using a loop to copy the array, we can use Array.Copy method

            #endregion


            #region Q10

           //const int n = 5;
           // int[]arr = new int[n] {1,2,3,4,5};

           // Console.WriteLine("\nArray in reverse order:");
           // for (int i = n - 1; i >= 0; i--)
           // {
           //     Console.Write(arr[i] + " ");
           // }
           // Console.WriteLine();
           
            #endregion


            #endregion








        }
    }
}
