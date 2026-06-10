using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string myString)
    {
        List<int> answer = new List<int>();
        string[] letters = myString.Split('x');
        for (int i = 0; i < letters.Length; i++)
        {
            answer.Add(letters[i].Length);
        }
        return answer.ToArray();
    }
}