using System;
using System.Collections.Generic;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        List<string> answer = new List<string>();
        int index = -1;
        bool isL = true;
        for (int i = 0; i < str_list.Length; i++)
        {
            if (str_list[i].Equals("l"))
            {
                index = i;
                isL = true;
                break;
            }
            else if (str_list[i].Equals("r"))
            {
                index = i;
                isL = false;
                break;
            }
        }

        if (index == -1)
        {
            return answer.ToArray();
        }
        else
        {
            if (isL)
            {
                for (int i = 0; i < index; i++)
                {
                    answer.Add(str_list[i]);
                }
            }
            else
            {
                for (int i = index + 1; i < str_list.Length; i++)
                {
                    answer.Add(str_list[i]);
                }
            }
        }
        return answer.ToArray();
    }
}