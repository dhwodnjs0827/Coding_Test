using System;

public class Solution
{
    public int[,] solution(int[,] arr)
    {
        int[,] answer = new int[,] { { } };
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        if (rows > cols)
        {
            answer = new int[rows, rows];
        }
        else if (cols > rows)
        {
            answer = new int[cols, cols];
        }
        else
        {
            answer = new int[rows, cols];
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                answer[i, j] = arr[i, j];
            }
        }
        return answer;
    }
}