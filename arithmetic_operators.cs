using System;

namespace arithmatic_operators
{
    class Program
    {
         static void Main (String[] args)
        {
            double sum,sub,product,div,mod;
            sum = sub = product = div = mod = 10;

            sum = sum + 5;
            Console.WriteLine("sum = "+sum); //15

            sum += 5;
            Console.WriteLine("sum = "+sum); //20

            //*************************************

            sub = sub - 5;
            Console.WriteLine("sub = "+sub); //5

            sub -= 5;
            Console.WriteLine("sub = "+sub); //0

            //*************************************

            product = product * 5;
            Console.WriteLine("product = "+product); //50

            product *= 5;
            Console.WriteLine("product = "+product); //250

            //*************************************

            div = div / 5;
            Console.WriteLine("div = "+div); //2

            div /= 5;
            Console.WriteLine("div = "+div); //0.4

            //*************************************

            mod = mod % 5;
            Console.WriteLine("mod = "+mod); //0

            mod %= 5;
            Console.WriteLine("mod = "+mod); //0
        }   
    }
}