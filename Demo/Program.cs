namespace Demo
{
    // 1- Class
    // 2- Struct
    // 3- Interface 
    // 4- Enum

    internal class Program
    {
        //1- Methods
        //1A) Class member methods (Static Methods)
        //1B) Object member methods (Non static methods)

        #region Methods
        
        

        //public static void PrintShape(string pattern,int count)
        // {
        //     for (int i = 0; i < count; i++)
        //     {
        //         Console.WriteLine(pattern);
        //     }

        // }

        //public static void Swap(int x,int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //public static void Swap(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;


        //}





        #endregion



        static void Main(string[] args)
        {
            #region Arrays

            #region 1D Array Ways

            //int[] numbers01;
            //numbers01 = new int[5];

            //int [] numbers02 = new int[5] {1,2,3,4,5};

            //int[] numbers03 = {1,2,3,4,5};

            //int[] numbers04 = [1,2,4,5];


            #endregion

            #region 1D Array

            //int[] numbers = [1, 2, 3];

            //numbers[0] = 1;
            //numbers[1] = 2; 
            //numbers[2] = 3; 

            //Console.WriteLine(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Console.WriteLine(numbers.Length); // length of array
            //Console.WriteLine(numbers.Rank); // number of dimensions through array


            #endregion

            #region 2D Array
            //int[,] marks = new int[2,5];

            //Console.WriteLine("Please Enter Values of an Array .");

            //        for (int i = 0; i <marks.GetLength(0); i++)
            //        {
            //            Console.WriteLine($"marks of student number{1+i} .");
            //            for (int j = 0; j <marks.GetLength(1);)
            //            {
            //                Console.Write($"Subject of number [{j + 1}] : "); 
            //               bool isParsed = int.TryParse(Console.ReadLine(), out marks[i,j]);
            //                if (isParsed )
            //                {
            //                    j++;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Please enter number in valid format");
            //                }


            //            }
            //            Console.WriteLine("=====================");

            //        }

            //        Console.Clear();

            //        for (int i = 0; i < marks.GetLength(0); i++)
            //        {
            //            Console.WriteLine($"Marks of student number {i+1}");

            //            for (int j = 0; j < marks.GetLength(1); j++)
            //            {
            //                Console.WriteLine($"subject number{j+1} >= {marks[i,j]} ");

            //            }
            //            Console.WriteLine("=====================");
            //        }




            #endregion

            #region 2D Array One For Loop

            //int[,] marks = new int [2, 4];

            //for (int i = 0; i < marks.Length; )
            //{
            //  bool isParsed = int.TryParse(Console.ReadLine(), out int StudentGrade);


            //    if (isParsed)
            //    {
            //        i++;
            //        marks[i / marks.GetLength(1), i % marks.GetLength(1)] = StudentGrade;
            //    }

            //    else
            //        Console.WriteLine("Please enter number in valid format");

            //}

            //Console.Clear();

            //Console.WriteLine("Marks Values");

            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.Write(marks[i / marks.GetLength(1), i % marks.GetLength(1)] + " ");
            //}



            #endregion

            #region Jagged Array

            //int[][] JaggedArray = new int[3][];
            //JaggedArray[0] = new int[4]; //Default value 0,0,0,0
            //JaggedArray[1] = new int[] {10,2,0,3};
            //JaggedArray[2] = [100, 200, 300];



            #endregion

            #region Array Methods

            #region Class Member Mthods

            //int[] numbers = { 5, 3, 4, 1, 2, 4 };

            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //Array.Clear(numbers);
            //Array.Clear(numbers, 2, 3);
            //Console.WriteLine(Array.IndexOf(numbers, 4));
            //Console.WriteLine(Array.LastIndexOf(numbers, 5));
            //Array.Resize(ref numbers, 10);

            //int[] arr01 = {1,2,3,4,5};
            //int[] arr02 = new int[4];
            //Array.Copy(arr01, arr02, 3);
            //Console.WriteLine(arr02[0]);

            //Array.ConstrainedCopy(arr01, 1, arr02, 0, 3);
            //Console.WriteLine(arr02[0]);

            #endregion

            #region Object Member Mthods

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.GetLongLength(0));
            //numbers.SetValue(2003, 0);

            #endregion

            #endregion













            #endregion


            #region Functions



            #region  Method ProtoType
            //PrintShape("*", 5);
            #endregion

            #region Function Parameters [Value Type]


            #region Passing By Value

            //int x = 5, y = 10;
            //Console.WriteLine("Before Swapping Process");
            //Console.WriteLine(x + " " + y);

            //Swap(x, y); //Passing By Value

            //Console.WriteLine("After Swapping Process");
            //Console.WriteLine(x + " " + y);

            #endregion

            #region Passing By Ref

            //int x = 5, y = 10;
            //Console.WriteLine("Before Swapping Process");
            //Console.WriteLine(x + " " + y);

            //Swap(ref x,ref  y); //Passing By ref

            //Console.WriteLine("After Swapping Process");
            //Console.WriteLine(x + " " + y);

            #endregion


            #endregion










            #endregion







        }
    }
}
