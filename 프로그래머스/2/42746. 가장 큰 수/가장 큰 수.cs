using System;

public class Solution
    {
        public string solution(int[] numbers)
        {
            string answer = "";

            string[] strArr = Array.ConvertAll(numbers, x => x.ToString());
            
            Array.Sort(strArr, (x, y) => String.CompareOrdinal(y + x, x + y));
            
            answer = string.Join("", strArr);

            if (answer[0] == '0')
            {
                return "0";
            }
            
            return answer;
        }
    }