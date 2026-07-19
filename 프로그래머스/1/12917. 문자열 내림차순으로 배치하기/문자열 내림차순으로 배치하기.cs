using System.Linq;

public class Solution
        {
            public string solution(string s)
            {
                string answer = string.Empty;
                var tmp = s.OrderByDescending(x => (int)x);
                foreach (var x in tmp)
                {
                    answer += x;
                }
                return answer;
            }
        }