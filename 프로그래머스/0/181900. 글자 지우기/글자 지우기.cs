using System;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        string answer = "";
        int tmp;
        for (int i = 0; i < indices.Length; i++)
        {
            for (int j = 0; j < indices.Length; j++)
            {
                if (indices[i] < indices[j])
                {
                    tmp = indices[i];
                    indices[i] = indices[j];
                    indices[j] = tmp;
                }
            }
        }
        for (int i = 0; i < my_string.Length; i++)
        {
            bool isAnswer = true;
            for (int j = 0; j < indices.Length; j++)
            {
                if (i == indices[j])
                {
                    isAnswer = false;
                    break;
                }
            }

            if (isAnswer)
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}