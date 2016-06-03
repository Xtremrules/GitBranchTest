using System;

namespace GitBranchTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to my app");
            Console.WriteLine("Enter a value");
            var name = Console.ReadLine();
            Console.WriteLine($"Value entered is {name}");
            Console.ReadKey();
        }
    }
}