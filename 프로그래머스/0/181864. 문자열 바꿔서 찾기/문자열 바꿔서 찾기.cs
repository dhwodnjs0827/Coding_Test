using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0;
        string newStr = string.Empty;
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'A')
            {
                newStr += 'B';
            }
            else
            {
                newStr += 'A';
            }
        }

        answer = newStr.Contains(pat) ? 1 : 0;
        return answer;
    }
}