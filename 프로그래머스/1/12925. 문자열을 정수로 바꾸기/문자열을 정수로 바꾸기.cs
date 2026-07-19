using System;

public class Solution
        {
            public int solution(string s)
            {
                int answer = 0;

                bool isNegative = s[0] == '-';

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == '-' || s[i] == '+')
                    {
                        break;
                    }

                    answer += int.Parse(s[i].ToString()) * (int)Math.Pow(10, s.Length - i - 1);
                }

                if (isNegative)
                {
                    answer = -answer;
                }

                return answer;
            }
        }