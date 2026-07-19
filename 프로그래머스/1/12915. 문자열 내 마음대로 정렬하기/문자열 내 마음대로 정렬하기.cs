using System.Linq;

public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                var answer = strings.OrderBy(x => x[n]).ThenBy(x => x).ToArray();
                
                return answer;
            }
        }