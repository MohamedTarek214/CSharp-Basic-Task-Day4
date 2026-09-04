namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1 
            //int[] Numbers1 = new int[4]; // 1
            //Numbers1[0] = 1;
            //Numbers1[1] = 2;
            //Numbers1[2] = 3;
            //Numbers1[3] = 4;
            //int[] Numbers2 = new int[4] { 1, 2, 3, 4 }; // 2
            //int[] Numbers3 = { 1, 2, 3, 4 }; // 3
            //Console.WriteLine("first arry");
            //foreach (var item in Numbers1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("second arry");
            //foreach (var item in Numbers2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("third arry");
            //foreach (var item in Numbers3)
            //{
            //    Console.WriteLine(item);
            //}
            //// IndexOutOfRangeException. 
            //int[] Numbers4 = { 1, 2, 3 };
            //Console.WriteLine(Numbers4[3]);

            #endregion

            #region Problem2 
            //shallow copy 
            //int[] arr1 = { 5, 10, 15, 20 };
            //int[] arr2 = { 2, 4, 6, 8 };
            //Console.WriteLine("Before shallow copy");
            //Console.WriteLine(arr1[2]); 
            //Console.WriteLine(arr2[2]);
            //Console.WriteLine("After shallow copy");
            //arr2 = arr1;
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr2[2]);
            //Console.WriteLine("After modifying in arr1");
            //arr1[2] = 100;
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr2[2]);
            //------------------
            //deep copy
            //int[] arr1 = { 5, 10, 15, 20 };
            //int[] arr2 = { 2, 4, 6, 8 };
            //Console.WriteLine("Before deep copy");
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr2[2]);
            //Console.WriteLine("After deep copy");
            //arr2 = (int[])arr1.Clone();
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr2[2]);
            //Console.WriteLine("After modifying in arr1");
            //arr1[2] = 100;
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr2[2]); 
            #endregion

            #region Problem3  
            //int[,] StudentGrades = new int[3, 3];
            //for (int i = 0; i < StudentGrades.GetLength(0); i++)
            //{
            //    for (int j = 0; j < StudentGrades.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter grade for student {i + 1}, subject {j + 1}: ");
            //        StudentGrades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < StudentGrades.GetLength(0); i++)
            //{
            //    Console.Write($"Grades for student {i + 1}: ");
            //    for (int j = 0; j < StudentGrades.GetLength(1); j++)
            //    {
            //        Console.Write(StudentGrades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem4 
            //int[] arr = { 5, 4, 3, 2, 1 };
            //Console.WriteLine("Before Sort");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------");
            //Array.Sort(arr);
            //Console.WriteLine("After Sort");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("Before Reverse");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------");
            //Array.Reverse(arr);
            //Console.WriteLine("After Reverse");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("Before IndexOf");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("--------------------");
            //Console.WriteLine("After IndexOf");
            //int num =  Array.IndexOf(arr, 3);
            //Console.WriteLine(num);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine("Before Clear");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("--------------------");
            //Console.WriteLine("After Clear");
            //Array.Clear(arr);

            #endregion

            #region Problem5
            //string[] Names = { "Ali", "Ahmed", "Mohamed", "Hassan" };
            //Console.WriteLine("print All Elements By for loops ");
            //for (int i = 0; i < Names.Length; i++)
            //{
            //    Console.WriteLine(Names[i]);

            //}
            //Console.WriteLine("======================================");
            //Console.WriteLine("print All Elements By foreach loops ");
            //foreach (var item in Names)
            //{
            //    Console.WriteLine(item);


            //}
            //Console.WriteLine("======================================");
            //Console.WriteLine("print All Elementsin reverse order By while loops ");
            //int index = (Names.Length - 1);
            //while (index >= 0)
            //{
            //    Console.WriteLine(Names[index]);
            //    index--;
            //} 
            #endregion


        }
    }
}
