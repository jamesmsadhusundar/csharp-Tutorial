using System;

namespace random_number
{
    class Program
    {
        static void Main (String[] args)
        {
            Random random = new Random();

            int num1;
            double num2;

            num1 = random.Next(1,7);    //random numbers from 1 to 6
            num2 = random.NextDouble(); //random floating numbers

            Console.WriteLine("dice 1 = "+num1);
            Console.WriteLine("dice 2 = "+num2);
        }
    }
}