using System;

public class Solution
        {
            public string solution(int a, int b)
            {
                DateTime date = new DateTime(2016, a, b);
                return date.DayOfWeek.ToString().Substring(0, 3).ToUpper();
            }
        }