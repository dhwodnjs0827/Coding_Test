using System;

public class Solution
{
    public string solution(string myString)
    {
        string answer = "";
        for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'a')
            {
                answer += 'A';
            }
            else if (myString[i] != 'A')
            {
                answer += myString[i].ToString().ToLower();
            }
            else
            {
                answer += myString[i];
            }
        }
        return answer;
    }
}