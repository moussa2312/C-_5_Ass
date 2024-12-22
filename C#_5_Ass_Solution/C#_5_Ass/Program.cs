using System.Net.Http.Json;
using System.Xml.Linq;

namespace C__5_Ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.WriteLine("Enter Num Of Matrix: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[,] matrix = new int[n, n];
            //Console.WriteLine("Enter The Elements: ");
            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < n; j++)
            //        int.TryParse(Console.ReadLine(), out matrix[i, j]); 

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //        Console.Write($"{matrix[i, j]}  ");
            //        Console.WriteLine();
            //}

            #endregion

            #region 2- Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr = new int[n];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);

            #endregion

            #region 3- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int.TryParse(Console.ReadLine(), out int n);
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] merge = new int[arr1.Length + arr2.Length];

            //Console.WriteLine("Enter The Elements Array 1: ");

            //for (int i = 0; i < n; i++)           
            //    int.TryParse(Console.ReadLine(), out arr1[i]);

            //Console.WriteLine("Enter The Elements Array 2: ");

            //for (int i = 0; i < n; i++)
            //    int.TryParse(Console.ReadLine(), out arr2[i]); 

            //for (int i = 0; i < n; i++)
            //    merge[i] = arr1[i];

            //int x = arr1.Length;

            //for (int i = 0; i < n; i++)
            //{
            //    merge[x] = arr2[i];
            //    x++;
            //}

            ////Array.Copy(arr1, 0, merge, 0, arr1.Length);
            ////Array.Copy(arr2, 0, merge, arr1.Length, arr2.Length);

            //Array.Sort(merge);

            //Console.Write($"Array 1:  ");
            //for (int i = 0; i < arr2.Length; i++)
            //    Console.Write($"{arr1[i]} ");
            //    Console.WriteLine();

            //Console.Write($"Array 2:  ");
            //for (int i = 0; i < arr2.Length; i++)
            //    Console.Write($"{arr2[i]} ");
            //    Console.WriteLine();

            //Console.Write($"Merge :  ");
            //for (int i = 0; i < merge.Length; i++)
            //    Console.Write( $"{merge[i]} ");

            #endregion

            #region 4- Write a program in C# Sharp to count the frequency of each element of an array.

            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //int cnt = 0;

            //Console.WriteLine("Enter The Elements: ");

            //for (int i = 0; i < size; i++) 
            //    int.TryParse(Console.ReadLine(),out arr[i]);

            //Array.Sort(arr);

            //for(int i = 0; i < arr.Length - 1 ;i++) 
            //    if (arr[i] == arr[i + 1] )
            //        cnt++;

            //Console.WriteLine($"Number of Elements repeated: {cnt}");



            #endregion

            #region 5- Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Enter The Elements: ");

            //for (int i = 0; i < size; i++)
            //    int.TryParse(Console.ReadLine(), out arr[i]);

            //Console.WriteLine($"Min Num Of Array: {arr.Min()}");
            //Console.WriteLine($"Min Num Of Array: {arr.Max()}");

            ////Array.Sort(arr);
            ////Console.WriteLine($"Min Num Of Array: {arr[0]}");
            ////Console.WriteLine($"Max Num Of Array: {arr[arr.Length - 1]}");

            #endregion

            #region 6- Write a program in C# Sharp to find the second largest element in an array.

            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Enter The Elements: ");

            //for (int i = 0; i < size; i++)
            //    int.TryParse(Console.ReadLine(), out arr[i]);

            //Array.Sort(arr);
            //int cnt = 0;

            //for (int i = 0; i < arr.Length - 1; i++)
            //    if (arr[i] == arr[i + 1])
            //        cnt++;

            //if (cnt == arr.Length - 1)
            //    Console.WriteLine($"all elements is same = {arr[1]}");
            //else
            //    Console.WriteLine($"Second Largest Num Of Array: {arr.Length - 2}");

            #endregion

            #region 7- Consider an Array of Integer values with size N, having values as in this Example
            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //int[] largestdistance = new int[size];

            //Console.WriteLine("Enter The Elements: ");
            //for (int i = 0; i < size; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int maxDistance = 0; 
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            maxDistance = Math.Max(maxDistance, j - i); 
            //        }
            //    }
            //    largestdistance[i] = maxDistance; 
            //}

            //Console.WriteLine($"Largest distance = {largestdistance.Max() - 1}");
            #endregion

            #region 9 - Given a list of space separated words, reverse the order of the words.

            string words;
            words = Console.ReadLine();
            string[] arr = words.Split(' ');
            Array.Reverse(arr);
            words = string.Join(" ", arr);
            Console.WriteLine(words);

            #endregion

            #region 10-	Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //Console.WriteLine("enter num of row and col:");
            //int.TryParse(Console.ReadLine(), out int Row);
            //int.TryParse(Console.ReadLine(), out int Col);

            //int[,] firstArray = new int[Row, Col];
            //int[,] secondArray = new int[Row, Col];

            //Console.WriteLine("enter elements of array:");

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}
            //Console.WriteLine("first array:");

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        Console.Write(firstArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Second array:");

            //for (int i = 0; i < Row; i++)
            //{
            //    for (int j = 0; j < Col; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 11-	Write a Program to Print One Dimensional Array in Reverse Order
            //Console.WriteLine("Enter Size Of Array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Enter The Elements: ");

            //for (int i = 0; i < size; i++)
            //    int.TryParse(Console.ReadLine(), out arr[i]);

            //Console.Write($"Array in Reverse: ");
            ////Array.Reverse(arr);
            ////for (int i = 0; i < arr.Length ; i++)
            ////    Console.Write($"{arr[i]} ");

            //for (int i = arr.Length - 1; i >= 0; i--)
            //    Console.Write($"{arr[i]} ");


            #endregion

        }
    }
}
