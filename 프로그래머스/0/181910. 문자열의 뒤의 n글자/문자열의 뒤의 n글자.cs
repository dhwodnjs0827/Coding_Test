using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        string answer = "";
        int startIndex = my_string.Length - n;
        return my_string.Substring(startIndex, n);
    }
}