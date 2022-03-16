using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capegemini.Csharp.Day2
{
    internal class EqualsExample
    {
        static void Main(String[] args)
        {
            string str = "hello";
            string str2 = "hello";
            Console.WriteLine($"Equals :{str.Equals(str2)}");
            Console.WriteLine($"== :{str == str2}");
        }
    }
}
