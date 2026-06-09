using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        foreach (var word in s)
        {
            Console.WriteLine(word);
        }
    }
}