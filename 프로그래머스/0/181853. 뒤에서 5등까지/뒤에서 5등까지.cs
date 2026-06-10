using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[5];
        for (int i = 0; i < num_list.Length - 1; i++)
        {
            for (int j = i + 1; j < num_list.Length; j++)
            {
                if (num_list[i] > num_list[j])
                {
                    int temp = num_list[i];
                    num_list[i] = num_list[j];
                    num_list[j] = temp;
                }
            }
        }

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = num_list[i];
        }

        return answer;
    }
}