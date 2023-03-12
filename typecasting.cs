using System;

namespace typecasting //is nothing but converting datatype from one to another
{
    class Program
    {
        static void Main (String[] args)
        {
            int a = 19;
            double b = Convert.ToDouble(a) + 0.25;

            Console.WriteLine(b);
            Console.WriteLine(b.GetType()); //defines datatype of b

            Console.WriteLine();

            //*****************************************************************
            
            double c = 185.25;
            int d = Convert.ToInt32(c); 

            Console.WriteLine(d);
            Console.WriteLine(d.GetType()); //defines datatype of d

            Console.WriteLine();

            //*****************************************************************

            String e = "#";
            char f = Convert.ToChar(e);

            Console.WriteLine(f);
            Console.WriteLine(f.GetType()); //defines datatype of f
        }
    }
}