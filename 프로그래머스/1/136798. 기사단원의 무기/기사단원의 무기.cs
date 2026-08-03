using System;

public class Solution
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            int att = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    att++;
                }
            }

            if (att > limit)
            {
                att = power;
            }
            
            answer += att;
        }
        
        return answer;
    }
}