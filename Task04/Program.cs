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

            #region Problem6 
            //int PositiveOddNumber;
            //bool Flage;
            //do
            //{
            //    Console.WriteLine("Enter a positive odd number");
            //    Flage = int.TryParse(Console.ReadLine(), out PositiveOddNumber);

            //}
            //while (PositiveOddNumber <= 0 || PositiveOddNumber % 2 == 0 || !Flage);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            //Console.WriteLine($"positive odd number: {PositiveOddNumber}");
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~"); 
            #endregion

            #region Problem7  
            //int[,] numbers =
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Problem8  
            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //    if (month == 1)
            //        Console.WriteLine("January");
            //    else if (month == 2)
            //        Console.WriteLine("February");
            //    else if (month == 3)
            //        Console.WriteLine("March");
            //    else if (month == 4)
            //        Console.WriteLine("April");
            //    else if (month == 5)
            //        Console.WriteLine("May");
            //    else if (month == 6)
            //        Console.WriteLine("June");
            //    else if (month == 7)
            //        Console.WriteLine("July");
            //    else if (month == 8)
            //        Console.WriteLine("August");
            //    else if (month == 9)
            //        Console.WriteLine("September");
            //    else if (month == 10)
            //        Console.WriteLine("October");
            //    else if (month == 11)
            //        Console.WriteLine("November");
            //    else if (month == 12)
            //        Console.WriteLine("December");
            //    else
            //        Console.WriteLine("Invalid month");
            //Console.WriteLine("***************************************");

            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;

            //    case 2:
            //        Console.WriteLine("February");
            //        break;

            //    case 3:
            //        Console.WriteLine("March");
            //        break;

            //    case 4:
            //        Console.WriteLine("April");
            //        break;

            //    case 5:
            //        Console.WriteLine("May");
            //        break;

            //    case 6:
            //        Console.WriteLine("June");
            //        break;

            //    case 7:
            //        Console.WriteLine("July");
            //        break;

            //    case 8:
            //        Console.WriteLine("August");
            //        break;

            //    case 9:
            //        Console.WriteLine("September");
            //        break;

            //    case 10:
            //        Console.WriteLine("October");
            //        break;

            //    case 11:
            //        Console.WriteLine("November");
            //        break;

            //    case 12:
            //        Console.WriteLine("December");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month");
            //        break;
            //}

            #endregion

            #region Problem9 

            //int[] numbers = { 5, 2, 8, 2, 9, 3, 2 };

            //Array.Sort(numbers);

            //Console.WriteLine("Sorted array:");

            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            //Console.Write("Enter a value to search: ");
            //int value = int.Parse(Console.ReadLine());

            //int firstIndex = Array.IndexOf(numbers, value);
            //int lastIndex = Array.LastIndexOf(numbers, value);

            //Console.WriteLine("First index: " + firstIndex);
            //Console.WriteLine("Last index: " + lastIndex); 
            #endregion

            #region Problem10 
            //int[] numbers = { 10, 20, 30, 40 };

            //int SumFor = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    SumFor += numbers[i];
            //}

            //Console.WriteLine("Sum using for: " + SumFor);


            //int SumForeach = 0;

            //foreach (int number in numbers)
            //{
            //    SumForeach += number;
            //}

            //Console.WriteLine("Sum using foreach: " + SumForeach); 
            #endregion
        }
    }
}
