using System;

public class Solution
{
    public int[] solution(string[] park, string[] routes)
    {
        int width = park[0].Length;
        int height = park.Length;
        (int, int) startPoint = (0, 0);
        for (int i = 0; i < park.Length; i++)
        {
            for (int j = 0; j < park[i].Length; j++)
            {
                if (park[i][j] == 'S')
                {
                    startPoint = (i, j);
                }
            }
        }

        for (int i = 0; i < routes.Length; i++)
        {
            (int, int) dir = (0, 0);
            (int, int) result = (startPoint.Item1, startPoint.Item2);
            bool isSkip = false;

            var delta = int.Parse(routes[i][2].ToString());
            switch (routes[i][0])
            {
                case 'N':
                    dir = (-1, 0);
                    break;
                case 'S':
                    dir = (1, 0);
                    break;
                case 'E':
                    dir = (0, 1);
                    break;
                case 'W':
                    dir = (0, -1);
                    break;
            }

            for (int y = 0; y < delta; y++)
            {
                var temp = result.Item1 + dir.Item1;
                if (temp < 0 || temp >= height || park[temp][result.Item2] == 'X')
                {
                    isSkip = true;
                    break;
                }
                result.Item1 = temp;
            }
            
            for (int x = 0; x < delta; x++)
            {
                var temp = result.Item2 + dir.Item2;
                if (temp < 0 || temp >= width || park[result.Item1][temp] == 'X')
                {
                    isSkip = true;
                    break;
                }
                result.Item2 = temp;
            }

            if (!isSkip)
            {
                startPoint = result;
            }
        }
        
        int[] answer = new int[2];
        answer[0] = startPoint.Item1;
        answer[1] = startPoint.Item2;
        return answer;
    }
}