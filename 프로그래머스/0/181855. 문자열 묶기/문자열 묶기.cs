using System;

public class Solution
{
    public int solution(string[] strArr)
    {
        int answer = -1;
        int[] arr = new int[30];
        for (int i = 0; i < strArr.Length; i++)
        {
            arr[strArr[i].Length - 1]++;
        }
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (answer < arr[i])
            {
                answer = arr[i];
            }
        }
        return answer;
    }
}