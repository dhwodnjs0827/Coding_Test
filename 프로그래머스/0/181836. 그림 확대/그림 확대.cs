using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] picture, int k)
    {
        List<string> answer = new List<string>();
        for (int i = 0; i < picture.Length; i++)
        {
            for (int j = 0; j < k; j++)
            {
                string line = String.Empty;
                for (int l = 0; l < picture[i].Length; l++)
                {
                    for (int m = 0; m < k; m++)
                    {
                        line += picture[i][l];
                    }
                }
                answer.Add(line);
            }
        }
        return answer.ToArray();
    }
}