using System;
using static System.Console;

namespace capegemini.Csharp.Day2
{
    internal class StringMethod
    {
        static void Main1(string[] args)
        {
            string str = "Capgemini";
            WriteLine($"Lengthn :{str.Length}");
            string s = str.Clone() as string;
            WriteLine($"Clone :{s}");
            WriteLine($"Remove Left Space :{str.TrimStart()}");
            string str1 = "Good Morning Everyone";
            string[] test = str1.Split(' ');
            //foreach (string x in test)

               // WriteLine($)
           
            WriteLine($"Join String Using Comma :{string.Join(',', test)}");
            string pid = "p00001";
            int id =int.Parse(pid.Substring(1,5));
            id++;

            WriteLine($"New ID :{"P0000" + id}");
            WriteLine(id);
            WriteLine(pid + 1);

        }
    }
} 
