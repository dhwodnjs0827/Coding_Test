using System.Collections.Generic;

public class Solution
    {
        public int[] solution(int[] array, int[,] commands)
        {
            var n = commands.GetLength(0);
            var answer = new int[n];
            
            for (var i = 0; i < n; i++)
            {
                List<int> trimArray = new();
                for (var j = commands[i, 0] - 1; j <= commands[i, 1] - 1; j++)
                {
                    trimArray.Add(array[j]);
                }
                trimArray.Sort();
                answer[i] = trimArray[commands[i, 2] - 1];
            }
            
            return answer;
        }
    }