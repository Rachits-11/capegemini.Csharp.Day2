using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capegemini.Csharp.Day2
{
    internal class SringBuilderExample
    {
        static void Main4(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string msg;
            do
            {
                Console.WriteLine("enter ur message");
                msg = Console.ReadLine();
                sb.AppendLine(msg);
            } while (msg.ToLower() ! == "no");
            Console.WriteLine(sb.ToString());
        }
    }
}
