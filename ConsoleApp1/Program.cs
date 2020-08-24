using System;
using System.Security.Cryptography.X509Certificates;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string userName = Console.ReadLine();
            
            Console.WriteLine("How old are you?");
            var userAge = Console.ReadLine();

            Console.WriteLine("Where do you live?");
            string residence = Console.ReadLine();

            Console.WriteLine($"My name is {userName}. I am {userAge} and I live in {residence}");

            Console.WriteLine("How many apples did you buy?");
            int apples = int.Parse(Console.ReadLine());

            Console.WriteLine("How many pears did you buy?");
            int pears = int.Parse(Console.ReadLine());

            var fruits = Sum(apples, pears);

            Console.WriteLine($"You bought {fruits} fruits");
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
}
