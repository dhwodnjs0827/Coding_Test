using System;
using System.Linq;

public class Solution
{
    public int solution(int n, int m, int[] section)
    {
        int paintCount = 0;

        bool[] isPainted = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (section.Contains(i + 1))
            {
                isPainted[i] = false;
            }
            else
            {
                isPainted[i] = true;
            }
        }

        while (isPainted.Contains(false))
        {
            var targetIndex = Array.IndexOf(isPainted, false);
            for (int i = targetIndex; i < m + targetIndex && i < isPainted.Length; i++)
            {
                isPainted[i] = true;
            }
            paintCount++;
        }
        return paintCount;
    }
}