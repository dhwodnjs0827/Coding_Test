using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string str1 = a.ToString() + b.ToString();
        string str2 = (2 * a * b).ToString();
        
        int num1 = Convert.ToInt32(str1);
        int num2 = Convert.ToInt32(str2);

        if (num1 >= num2)
        {
            answer = num1;
        }
        else
        {
            answer = num2;
        }
        
        return answer;
    }
}