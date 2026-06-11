using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[] delete_list)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            bool isAdd = true;
            for (int j = 0; j < delete_list.Length; j++)
            {
                if (arr[i] == delete_list[j])
                {
                    isAdd = false;
                    break;
                }
            }

            if (isAdd)
            {
                answer.Add(arr[i]);
            }
        }

        return answer.ToArray();
    }
}