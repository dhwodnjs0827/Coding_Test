using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        List<int> answer = new List<int>();
        List<int> arrList = arr.ToList();

        for (int i = 0; i < query.Length; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j <= query[i]; j++)
                {
                    answer.Add(arrList[j]);
                }
            }
            else
            {
                for (int j = query[i]; j < arrList.Count; j++)
                {
                    answer.Add(arrList[j]);
                }
            }

            int[] tmp = answer.ToArray();
            arrList = tmp.ToList();
            answer.Clear();
        }
        
        return arrList.ToArray();
    }
}