using static System.Console;

namespace GitBranchTest {
    class Program {
        static void Main(string[] args) {
            WriteLine("Welcome to my app");
            WriteLine("Enter a value");
            var name = ReadLine();
            WriteLine($"Value entered is {name}");
            ReadKey();
        }
    }
}