using System;
using System.Linq;

public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int answer = 0;
        if (arr1.Length != arr2.Length)
        {
            answer = arr1.Length > arr2.Length ? 1 : -1;
        }
        else
        {
            int sum1 = arr1.Sum();
            int sum2 = arr2.Sum();

            if (sum1 == sum2)
            {
                answer = 0;
            }
            else
            {
                answer = sum1 > sum2 ? 1 : -1;
            }
        }
        return answer;
    }
}