using System;
using System.Reflection.Metadata;

namespace Assignment
{
    internal class Program
    {

        #region Functions Methods

        #region Q1

        //public static void swap(int x , int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;

        //}


        //public static void swap(ref int x,ref int y)
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;

        //}





        #endregion

        #region Q2

        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}

        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //        Sum += Arr[i];
        //    return Sum;
        //}

        #endregion


        #region Q3

        //public static void Calculate(int a, int b, int c, int d, out int sum, out int sub)
        //{
        //    sum = a + b;
        //    sub = c - d;
        //}

        #endregion

        #region Q4

       //public static int SumOfDigits(int number)
       // {
       //     int sum = 0;
       //     while (number != 0)
       //     {
       //         sum += number % 10;   
       //         number /= 10;         
       //     }
       //     return sum;
       // }

        #endregion


        #endregion

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

            #region Functions

            #region Q1

            //[Value type parameter]
            //1) passing by value:

            //-- You create a copy of instance  in a stack .
            //-- When you modify an instance, You modify the copy instance you created not the instance value itself .

            //int x = 10, y = 20 ;
            //Console.WriteLine("Before Modifying : ");

            //Console.WriteLine($" x = {x} , y = {y}");

            //swap(x, y);

            //Console.WriteLine("After Modifying : ");
            //Console.WriteLine($" x = {x} , y = {y}");





            //1) passing by Reference:

            //-- You don't create  a copy of instance  in a stack but, You refer to the same data itself.
            //-- When you modify an instance, You modify the instance value itself .

            //int x = 10, y = 20;
            //Console.WriteLine("Before Modifying : ");

            //Console.WriteLine($" x = {x} , y = {y}");

            //swap(ref x,ref y);

            //Console.WriteLine("After Modifying : ");
            //Console.WriteLine($" x = {x} , y = {y}");





            #endregion

            #region Q2

            //  Reference Type

            // 1) Passing By Value

            // -- You create copy of the original data but , refer to the same location in the heap.
            // -- Your modification will affect the same data .

            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);


            // 2) Passing by Reference 

            // -- You don't create a copy , but refer to the same data itself in stack and same location in heap .
            // -- You will affect the same data itself when modifying .



            //int[] numbers = { 1, 2, 3 };
            //int result = SumArray(ref numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(numbers[0]);



            #endregion


            #region Q3

            // I use parse instead of tryparse for simplicity checks, but I know I should use it for safety .  

            //int sum, difference;

            //Console.Write("Enter number a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter number b: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Enter number c: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("Enter number d: ");
            //int d = int.Parse(Console.ReadLine());

            //Calculate(a, b, c, d, out  sum, out  difference);

            //Console.WriteLine($"Sum of a + b = {sum}");
            //Console.WriteLine($"Subtraction of c - d = {difference}");


            #endregion

            #region Q4  

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //int result = SumOfDigits(num);

            //Console.WriteLine($"The sum of the digits of the number {num} is: {result}");


            #endregion




            #endregion






        }
    }
}
