public class Solution
        {
            public string solution(string s)
            {
                int length = s.Length;
                int center = length / 2;
                return length % 2 == 0 ? s.Substring(center - 1, 2) : s.Substring(center, 1);
            }
        }