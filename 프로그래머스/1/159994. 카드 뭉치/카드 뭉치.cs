using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string[] cards1, string[] cards2, string[] goal)
    {
        Queue<string> q1 = new Queue<string>(cards1);
        Queue<string> q2 = new Queue<string>(cards2);

        for (int i = 0; i < goal.Length; i++)
        {
            if (q1.TryPeek(out string card))
            {
                if (card == goal[i])
                {
                    q1.Dequeue();
                    continue;
                }
            }

            if (q2.TryPeek(out card))
            {
                if (card == goal[i])
                {
                    q2.Dequeue();
                    continue;
                }
            }

            return "No";
        }

        return "Yes";
    }
}