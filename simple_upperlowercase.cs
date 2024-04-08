using System;
public class Program
{
    public static void Main()
    {
        string str, str1;
        Console.WriteLine("Enter the String in Uppercase :");
        str = Console.ReadLine();
        Console.WriteLine("String in LowerCase : {0}", str.ToLower());
        Console.ReadLine();

        Console.WriteLine("Enter the String in Lowercase :");
        str1 = Console.ReadLine();
        Console.WriteLine("String in UpperCase : {0}", str1.ToUpper());
        Console.ReadLine();


    }
}
