using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(@"C:\Users\utesh\Desktop\PP2\week2\input1"); // opens stream for reading in a file input1   
            StreamWriter output = new StreamWriter(@"C:\Users\utesh\Desktop\PP2\week2\output1"); // opens stream for writing in a file output

            string s; // created a string

            while ((s = input.ReadLine()) != null)
            { // reading an string from all lines, while the line is not empty
                output.WriteLine(s + " " + (palindrome(s) ? "YES" : "NO")); // printint the string and result of palindrome test
            }
            input.Close(); // close input stream
            output.Close(); // close ouput stream
        }
        static bool palindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++) // iterating through the chars of the first half of the string
                if (s[i] != s[s.Length - 1 - i]) // if the opposite chars doesn't match
                    return false; // then, it's not a palindrome
            return true; // haven't found any mismatches, it's a palindrome
        }
    }
}