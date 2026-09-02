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



        }
    }
}
