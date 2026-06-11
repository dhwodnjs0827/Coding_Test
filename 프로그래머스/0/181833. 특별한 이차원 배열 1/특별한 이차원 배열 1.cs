using System;

public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];
        for (int i = 0; i < answer.GetLength(0); i++)
        {
            answer[i, i] = 1;
        }
        return answer;
    }
}