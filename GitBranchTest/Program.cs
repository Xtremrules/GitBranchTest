using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to my app");
            var name = Console.ReadLine();
            Console.WriteLine($"Value entered is {name}");
            Console.ReadKey();
        }
    }
}