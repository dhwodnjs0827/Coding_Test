public class Solution
        {
            public int[] solution(long n)
            {
                
                string s = n.ToString();
                int[] answer = new int[s.Length];
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    answer[s.Length - i - 1] = int.Parse(s[i].ToString());
                }
                
                return answer;
            }
        }