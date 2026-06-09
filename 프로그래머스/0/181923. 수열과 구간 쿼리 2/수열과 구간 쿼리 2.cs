using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int result = -1;
            for (int arrIdx = queries[i, 0]; arrIdx <= queries[i, 1]; arrIdx++)
            {
                if (arr[arrIdx] > queries[i, 2])
                {
                    int tmp = arr[arrIdx];
                    if (result == -1)
                    {
                        result = tmp;
                    }
                    else if(tmp < result)
                    {
                        result = tmp;
                    }
                }
                answer[i] = result;
            }
        }

        return answer;
    }
}