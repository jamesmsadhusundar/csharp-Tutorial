class if_condition
{
    static void Main (String[] args)
    {
        int age;

        Console.WriteLine("enter your age.");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("you are "+age+" years old");

        if (age<18)
        {
            Console.WriteLine("you are under 18.");
        }

        else if (age==18)
        {
            Console.WriteLine("you are 18.");
        }

        else 
        {
            Console.WriteLine("you are above 18.");
        }
    }
}