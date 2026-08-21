using System;
using System.Collections.Generic;

public class Solution
{
    private List<List<int>> moves = new();

    public int[,] solution(int n)
    {
        Hanoi(n, 1, 3, 2);
        int length = moves.Count;
        int length2 = moves[0].Count;
        int[,] answer = new int[length, length2];
        for (int i = 0; i < moves.Count; i++)
        {
            for (int j = 0; j < moves[i].Count; j++)
            {
                answer[i, j] = moves[i][j];
            }
        }
        return answer;
    }

    private void Hanoi(int n, int from, int to, int aux)
    {
        if (n == 0)
        {
            return;
        }

        Hanoi(n - 1, from, aux, to);
        moves.Add([from, to]);
        Hanoi(n - 1, aux, to, from);
    }
}