using System;
using System.Text;

public class Solution
{
    public string solution(string X, string Y)
    {
        int[] numX = new int[10];
        int[] numY = new int[10];

        foreach (var x in X)
        {
            numX[x - '0']++;
        }
        
        foreach (var y in Y)
        {
            numY[y - '0']++;
        }

        StringBuilder sb = new();

        for (int i = 9; i >= 0; i--)
        {
            int num = Math.Min(numX[i], numY[i]);
            for (int j = 0; j < num; j++)
            {
                sb.Append(i);
            }
        }

        if (sb.Length == 0)
        {
            return "-1";
        }

        if (sb[0] == '0')
        {
            return "0";
        }
        
        return sb.ToString();
    }
}