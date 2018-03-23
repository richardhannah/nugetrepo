using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            Console.WriteLine(testClass.HelloWorld());
            Console.ReadLine();
        }
    }
}
