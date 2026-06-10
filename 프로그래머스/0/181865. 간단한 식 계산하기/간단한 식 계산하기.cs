using System;

public class Solution
{
    public int solution(string binomial)
    {
        int answer = 0;
        string[] nominals = binomial.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int num1 = int.Parse(nominals[0]);
        int num2 = int.Parse(nominals[2]);
        char op = char.Parse(nominals[1]);
        switch (op)
        {
            case '+':
                answer = num1 + num2;
                break;
            case '-':
                answer = num1 - num2;
                break;
            case '*':
                answer = num1 * num2;
                break;
        }
        return answer;
    }
}