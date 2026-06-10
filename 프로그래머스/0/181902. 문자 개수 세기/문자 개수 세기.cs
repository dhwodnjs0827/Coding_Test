using System;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];

        for (int i = 0; i < my_string.Length; i++)
        {
            char c = my_string[i];
            if (c >= 'A' && c <= 'Z')
            {
                answer[c - 'A']++;
            }
            else
            {
                answer[c - 'a' + 'Z' - 'A' + 1]++;
            }
        }
        return answer;
    }
}