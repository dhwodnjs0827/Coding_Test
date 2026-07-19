public class Solution
        {
            public string solution(int n)
            {
                string answer = "";

                if (n % 2 == 0)
                {
                    for (int i = 1; i <= n / 2; i++)
                    {
                        answer += "수박";
                    }
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 2 != 0)
                        {
                            answer += "수";
                        }
                        else
                        {
                            answer += "박";
                        }
                    }
                }
                
                return answer;
            }
        }