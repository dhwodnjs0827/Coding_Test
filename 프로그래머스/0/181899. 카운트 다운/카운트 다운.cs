using System;

public class Solution
{
    public int[] solution(int start_num, int end_num)
    {
        int length = start_num - end_num + 1;
        int[] answer = new int[length];
        for (var i = start_num; i >= end_num; i--)
        {
            answer[start_num - i] = i;
        }
        return answer;
    }
}