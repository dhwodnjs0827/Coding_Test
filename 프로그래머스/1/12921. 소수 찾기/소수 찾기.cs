using System;

public class Solution
        {
            public int solution(int n)
            {
                bool[] isNotPrime = new bool[n + 1];
                int count = 0;
                
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (!isNotPrime[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            isNotPrime[j] = true;
                        }
                    }
                }
                
                for (int i = 2; i <= n; i++)
                {
                    if (!isNotPrime[i])
                    {
                        count++;
                    }
                }

                return count;
            }
        }