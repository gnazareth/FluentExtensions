using System;
using FluentExtensions.String;

namespace FluentExtensions.Demos.String.Left
{
    class Program
    {
        static void Main()
        {
            const string str = "foo bar";
            Console.WriteLine(str.Left(3));

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
