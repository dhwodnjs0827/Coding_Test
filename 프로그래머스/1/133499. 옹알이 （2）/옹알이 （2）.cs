using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] words = { "aya", "ye", "woo", "ma" };

        foreach (string babble in babbling)
        {
            int pos = 0;
            string matched = string.Empty;
            bool isValid = true;

            while (pos < babble.Length)
            {
                bool found = false;

                foreach (string word in words)
                {
                    if (matched != word &&
                        pos + word.Length <= babble.Length &&
                        babble.Substring(pos, word.Length) == word)
                    {
                        pos += word.Length;
                        matched = word;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                answer++;
            }
        }

        return answer;
    }
}