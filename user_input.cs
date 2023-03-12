using System;

namespace user_input
{
    class Program
    {
        static void Main (String[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("your name is "+name);

            Console.WriteLine();

            //*************************************************

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you are "+age+" years old.");
        }
    }
}