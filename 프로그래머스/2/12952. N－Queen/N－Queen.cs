using System;

public class Solution
{
    private int[] placed;
    private int count = 0;
    private int length = 0;
    
    public int solution(int n)
    {
        length = n;
        placed = new int[n];
        Backtracking(0);
        return count;
    }

    private void Backtracking(int row)
    {
        if (row == length)
        {
            count++;
            return;
        }

        for (int col = 0; col < length; col++)
        {
            if (IsValid(row, col))
            {
                placed[row] = col;
                Backtracking(row + 1);
            }
        }
    }

    private bool IsValid(int row, int col)
    {
        for (int r = 0; r < row; r++)
        {
            int c = placed[r];
            if (c == col || Math.Abs(row - r) == Math.Abs(col - c))
            {
                return false;
            }
        }

        return true;
    }
}