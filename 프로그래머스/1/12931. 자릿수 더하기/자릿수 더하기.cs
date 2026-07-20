public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                string s = n.ToString();
                foreach (char c in s)
                {
                    answer += int.Parse(c.ToString());
                }
                return answer;
            }
        }