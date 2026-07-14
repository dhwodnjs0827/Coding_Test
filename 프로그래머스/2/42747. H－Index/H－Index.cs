using System;
using System.Linq;

public class Solution
    {
        public int solution(int[] citations)
        {
            int answer = 0;
            
            var total = citations.Length;

            for (var h = 0; h <= total; h++)
            {
                var count = citations.Count(c => c >= h);
                if (count >= h)
                {
                    answer = h;
                }
            }
            
            return answer;
        }
    }