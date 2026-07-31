using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        DFS(nums, 0, 0, 0, ref answer);
        
        return answer;
    }

    private void DFS(int[] nums, int start, int count, int sum, ref int answer)
    {
        if (count == 3)
        {
            if (IsPrime(sum))
            {
                answer++;
            }

            return;
        }

        for (int i = start; i < nums.Length; i++)
        {
            DFS(nums, i + 1, count + 1, sum + nums[i], ref answer);
        }
    }

    private bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}