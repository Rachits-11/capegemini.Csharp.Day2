using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capegemini.Csharp.Day2
{
    internal class ConstructorEx
    {
        //Member Variables or Instance Variable

        public int Id, Age;

        public string Name;

        //Constant Variable cannot be changed / modified, accessed by class name

        public const float PI = 3.14f;

        public const float Salary = 45000.78f;

        //Readonly Variable - accessed by class object, can be modified inside constructor

        public readonly double Price = 15000;

        //Static Varaible

        public static string City = "NA";

        //Explicit Default Constructor

        public ConstructorEx()

        {

            Id = 1001;

            Age = 40;

            Name = "Test";

            Price = 78000;

        }

        ~ConstructorEx()

        {

            Console.WriteLine("Destructor Called");

        }

        public void Print()

        {

            //int pid = 10001;//method level variable

            Console.WriteLine($"Id :{Id}\tName :{Name}\tAge :{Age}");

        }

        static void Main(string[] args)
        {
            //ClassName objectName = new DefaultConstructor(); //new - used to allocate new memory

            ConstructorEx c1 = new ConstructorEx();

            c1.Id = 1002;

            // c1.Print();

            ConstructorEx c2 = new ConstructorEx();

            c2.Id = 1006;

            //c2.Print();

            //Static Variable

            Console.WriteLine($"Static Variable :{ConstructorEx.City}");

            ConstructorEx.City = "Mumbai";

            Console.WriteLine($"Static Variable :{ConstructorEx.City}");

            TestClass t1 = new TestClass();

            t1.TestMethod();

            //Constant Varaiable

            //Salary = 789000.0f;

            Console.WriteLine($"Constant Variable :{ConstructorEx.Salary}");

            //Readonly Varaibles

            //c1.Price = 60000;

            Console.WriteLine($"Readonly Variable :{c1.Price}");

            Console.WriteLine($"Readonly Variable :{c2.Price}");
        }
    }
    class TestClass

    {

        public void TestMethod()

        {

            ConstructorEx c1 = new ConstructorEx();

            c1.Print();

            Console.WriteLine($"Static Variable in TestClass :{ConstructorEx.City}");

        }

    }

}

