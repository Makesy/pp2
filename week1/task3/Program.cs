using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // reading the array size
            int[] a = new int[n + 1]; // creted a 1-indexed array, uses only a+1..a+n+1
            for (int i = 1; i <= n; i++)
            {   // reading the array integers
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(a[i].ToString() + " " + a[i].ToString() + " "); // convert a[i] to string and print them twice with spaces separated between
            }
        }

    }
}