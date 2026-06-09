using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int a, int b, int c, int d)
    {
        int[] numberCount = new int[7];
        numberCount[a]++;
        numberCount[b]++;
        numberCount[c]++;
        numberCount[d]++;

        if (numberCount.Contains(4))
        {
            return 1111 * a;
        }
        else if (numberCount.Contains(3))
        {
            int p = 0;
            int q = 0;
            for (int i = 0; i < numberCount.Length; i++)
            {
                if (numberCount[i] == 3)
                {
                    p = i;
                }
                else if (numberCount[i] == 1)
                {
                    q = i;
                }
            }

            return (10 * p + q) * (10 * p + q);
        }
        else if (numberCount.Contains(2) && !numberCount.Contains(1))
        {
            int p = 0;
            int q = 0;
            for (int i = 0; i < numberCount.Length; i++)
            {
                if (numberCount[i] == 2)
                {
                    if (p == 0)
                    {
                        p = i;
                    }
                    else
                    {
                        q = i;
                    }
                }
            }

            return (p + q) * Math.Abs(p - q);
        }
        else if (numberCount.Contains(2) && numberCount.Contains(1))
        {
            int p = 0;
            int q = 0;
            int r = 0;
            for (int i = 0; i < numberCount.Length; i++)
            {
                if (numberCount[i] == 2)
                {
                    p = i;
                }
                else if (numberCount[i] == 1)
                {
                    if (q == 0)
                    {
                        q = i;
                    }
                    else
                    {
                        r = i;
                    }
                }
            }

            return q * r;
        }
        else
        {
            int[] newArray = new int[] { a, b, c, d };
            return newArray.Min();
        }
    }
}