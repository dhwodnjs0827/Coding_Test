using System;
using System.Linq;
using System.Text;

public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";
        
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < food.Length; i++)
        {
            int n = food[i] / 2;
            for (int j = 0; j < n; j++)
            {
                sb.Append(i.ToString());
            }
        }
        string front = sb.ToString();
        sb.Clear();
        var reverse = front.Reverse();
        foreach (var item in reverse)
        {
            sb.Append(item);
        }
        string back = sb.ToString();
        sb.Clear();
        sb.Append(front);
        sb.Append("0");
        sb.Append(back);
        answer = sb.ToString();
        
        return answer;
    }
}