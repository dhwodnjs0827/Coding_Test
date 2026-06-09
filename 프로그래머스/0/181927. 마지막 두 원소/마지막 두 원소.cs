using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int arrLength = num_list.Length;
        int lastValue;
        if (num_list[arrLength - 1] > num_list[arrLength - 2])
        {
            lastValue = num_list[arrLength - 1] - num_list[arrLength - 2];
        }
        else
        {
            lastValue = num_list[arrLength - 1] * 2;
        }

        int[] answer = new int[num_list.Length + 1];

        for (int i = 0; i < answer.Length; i++)
        {
            if (i == answer.Length - 1)
            {
                answer[i] = lastValue;
            }
            else
            {
                answer[i] = num_list[i];
            }
        }

        return answer;
    }
}