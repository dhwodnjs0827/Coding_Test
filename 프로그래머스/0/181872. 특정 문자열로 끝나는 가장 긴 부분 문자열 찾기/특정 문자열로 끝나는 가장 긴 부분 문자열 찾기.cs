using System;

public class Solution
{
    public string solution(string myString, string pat)
    {
        string answer = "";
        int patLength = pat.Length;
        int lastIndex = -1;
        for (int i = 0; i < myString.Length - patLength + 1; i++)
        {
            string subString = myString.Substring(i, patLength);
            if (subString.Equals(pat))
            {
                lastIndex = i;
            }
        }

        if (lastIndex != -1)
        {
            answer = myString.Substring(0, lastIndex + patLength);
        }
        
        return answer;
    }
}