using System;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        string front = my_string.Substring(0, s);
        string middle = my_string.Substring(s, e - s + 1);
        string back = my_string.Substring(e + 1);

        char[] reversed = middle.ToCharArray();
        Array.Reverse(reversed);
    
        return front + new string(reversed) + back;
    }
}