class Program
{
    static void Main (String[] args)
    {
        string name = "James M Sadhu Sundar";
        string phone_no = "122_344_88999";

        Console.WriteLine(name.ToUpper()); //uppercase
        Console.WriteLine(name.ToLower()); //lowercase

        Console.WriteLine(phone_no.Replace("_","-"));

        Console.WriteLine(name.Insert(0,"Mr."));

        Console.WriteLine(name.Length);     //20
        Console.WriteLine(phone_no.Length); //13

        string first_name,last_name;

        first_name = name.Substring(0,5); 
        last_name = name.Substring(6,14);

        Console.WriteLine(first_name);
        Console.WriteLine(last_name);
    }
}