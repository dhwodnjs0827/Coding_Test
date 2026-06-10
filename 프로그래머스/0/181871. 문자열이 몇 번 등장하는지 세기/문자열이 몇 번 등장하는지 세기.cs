using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        int patLength = pat.Length;
        for (int i = 0; i < myString.Length - patLength + 1; i++)
        {
            string subString = myString.Substring(i, patLength);
            if (subString.Equals(pat))
            {
                answer++;
            }
        }
        return answer;
    }
}