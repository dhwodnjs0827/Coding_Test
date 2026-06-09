using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        List<string> answer = new List<string>();
        for (int i = 0; i < my_string.Length; i++)
        {
            answer.Add(my_string.Substring(i, my_string.Length - i));
        }

        for (int i = 1; i < answer.Count; i++)
        {
            string key = answer[i];
            int j = i - 1;
            while (j >= 0 && string.Compare(answer[j], key) > 0)
            {
                answer[j + 1] = answer[j];
                j--;
            }
            answer[j + 1] = key;
        }
        return answer.ToArray();
    }
}