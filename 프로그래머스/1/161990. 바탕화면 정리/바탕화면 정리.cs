using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int minX = 0;
        int minY = 0;
        int maxX = 0;
        int maxY = 0;

        bool isFirstFind = false;
        
        for (int i = 0; i < wallpaper.Length; i++)
        {
            for (int j = 0; j < wallpaper[i].Length; j++)
            {
                if (wallpaper[i][j] == '#')
                {
                    if (!isFirstFind)
                    {
                        minX = i;
                        maxX = i;
                        minY = j;
                        maxY = j;
                        isFirstFind = true;
                    }
                    
                    if (minX >= i)
                    {
                        minX = i;
                    }

                    if (minY >= j)
                    {
                        minY = j;
                    }

                    if (maxX < i)
                    {
                        maxX = i;
                    }

                    if (maxY < j)
                    {
                        maxY = j;
                    }
                }
            }
        }

        return [minX, minY, maxX + 1, maxY + 1];
    }
}