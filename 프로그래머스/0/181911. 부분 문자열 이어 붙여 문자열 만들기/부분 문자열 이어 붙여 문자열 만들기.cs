using System;

public class Solution
{
    public string solution(string[] my_strings, int[,] parts)
    {
        string answer = "";
        for (int i = 0; i < my_strings.Length; i++)
        {
            my_strings[i] = my_strings[i].Substring(parts[i, 0], parts[i, 1] - parts[i, 0] + 1);
            answer += my_strings[i];
        }
        return answer;
    }
}