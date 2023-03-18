using System;

namespace hypotenuse_of_triangle
{
    class Program
    {
        static void Main (String[] args)
        {
            double a,b,c;

            Console.WriteLine("value of a : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("value of b : ");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));

            Console.WriteLine("hypotenuse : "+c);
        }
    }
}