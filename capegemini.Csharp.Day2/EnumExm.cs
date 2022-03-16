using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capegemini.Csharp.Day2
{
    internal class EnumExm
    {
        enum Fruits
        {
            Apple = 123,
            Banana = 789,
            Pears,
            Orange,
            Grapes = 888
        }
        static void Main(string[] args)
        {
            foreach (var f1 in Enum.GetNames(typeof(Fruits)))
            {
                Console.WriteLine(f1);
            }
            foreach (var f2 in Enum.GetValues(typeof(Fruits)))
            {
                Console.WriteLine(f2);
            }
        }
    }
}
