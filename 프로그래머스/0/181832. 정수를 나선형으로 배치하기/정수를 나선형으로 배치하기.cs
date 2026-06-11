using System;

public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];
        int[] dx = { 0, 1, 0, -1 };
        int[] dy = { 1, 0, -1, 0 };

        int x = 0, y = 0, dir = 0;
        for (int num = 1; num <= n * n; num++)
        {
            answer[x, y] = num;

            int nextX = x + dx[dir];
            int nextY = y + dy[dir];
            
            if (nextX < 0 || nextX >= n || nextY < 0 || nextY >= n || answer[nextX, nextY] != 0)
            {
                dir = (dir + 1) % 4; 
                nextX = x + dx[dir];
                nextY = y + dy[dir];
            }

            x = nextX;
            y = nextY;
        }
        return answer;
    }
}