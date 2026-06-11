using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < num_list.Length - 1; i++)
        {
            for (int j = i + 1; j < num_list.Length; j++)
            {
                if (num_list[i] > num_list[j])
                {
                    int tmp = num_list[i];
                    num_list[i] = num_list[j];
                    num_list[j] = tmp;
                }
            }
        }

        for (int i = 5; i < num_list.Length; i++)
        {
            answer.Add(num_list[i]);
        }
        
        return answer.ToArray();
    }
}