using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Test VS 2019");
            Class1 test1 = new Class1("Gleb");
            Console.WriteLine(test1.Name);
        }
    }
}