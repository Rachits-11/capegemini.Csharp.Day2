using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capegemini.Csharp.Day2
{
    internal class StructExample
    {
        int Id;
        string Name;
        double Salary;

        public void store()
        {
            Id = 1001;
            Name = "kumar";
            Salary = 4555.66;
        }
        public static void Main3(string [] argd)
        {
            StructExample obj = new StructExample();
            obj.store();
            Console.WriteLine($"Id :{obj.Id}\tName :{obj.Name}\tSalary :{obj.Salary}");

        }
    }
}
