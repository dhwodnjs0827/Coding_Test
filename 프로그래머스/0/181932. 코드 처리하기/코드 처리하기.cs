using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        
        bool mode = false;
        string ret = "";
        
        for (int idx = 0; idx < code.Length; idx++)
        {
            if (mode == false)
            {
                if (code[idx] != '1')
                {
                    if (idx % 2 == 0)
                    {
                        ret += code[idx];
                    }
                }
                else
                {
                    mode = !mode;
                }
            }
            else
            {
                if (code[idx] != '1')
                {
                    if (idx % 2 == 1)
                    {
                        ret += code[idx];
                    }
                }
                else
                {
                    mode = !mode;
                }
            }
        }

        if (ret == "")
        {
            ret = "EMPTY";
        }
        answer = ret;
        
        return answer;
    }
}