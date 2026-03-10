using MyFirstLibrary1;
using EvaluateNums;
using RandomLibray;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Console.WriteLine("Hello, my name is Sam");
            Console.WriteLine("My age is: 32");
            Console.WriteLine("My favourite film is: Blue Velvet");
            string name = args[0];
            Console.WriteLine("My name is: " + name);
            int age = Int32.Parse(args[1]);
            Console.WriteLine("My age is: " + age);
            string favouriteFilm = args[2];
            Console.WriteLine("My favourite film is: " + favouriteFilm);
            PrintLinesClass.Hello();
            Console.WriteLine("1 + 2 = " + Calculator.SumNums(1, 2));
            RandomClass.WriteSomething();
        }
    }
}
