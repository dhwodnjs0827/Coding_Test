using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        var answer = string.Empty;
        foreach (var c in s)
        {
            var toString = c.ToString();
            if (c >= 'a' && c <= 'z')
            {
                toString = toString.ToUpper();
            }
            else if (c >= 'A' && c <= 'Z')
            {
                toString = toString.ToLower();
            }
            answer += toString;
        }

        Console.WriteLine(answer);
    }
}