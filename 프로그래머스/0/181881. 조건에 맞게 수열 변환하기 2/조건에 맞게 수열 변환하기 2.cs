using System;
using System.Linq;

public class Solution
{
    public int solution(int[] arr)
    {
        int answer = 0;
        bool isEqual = false;
        
        while (!isEqual)
        {
            answer++;
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arr1[i] = arr[i] / 2;
                }
                else if (arr[i] < 50 && arr[i] % 2 != 0)
                {
                    arr1[i] = arr[i] * 2 + 1;
                }
                else
                {
                    arr1[i] = arr[i];
                }
            }

            isEqual = arr.SequenceEqual(arr1);
            
            arr = arr1;
        }
        return answer - 1;
    }
}