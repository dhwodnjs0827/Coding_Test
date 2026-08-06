using System;

public class Solution
{
    public int solution(string s)
    {
        int divisionCount = 0;
        string newString = s;
        while (newString.Length > 0)
        {
            char x = newString[0];
            int equalCount = 0;
            int diffCount = 0;
            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i] != x)
                {
                    diffCount++;
                }
                else
                {
                    equalCount++;
                }

                if (equalCount == diffCount)
                {
                    divisionCount++;
                    newString = newString.Remove(0, i + 1);
                    break;
                }
                
                if(i == newString.Length - 1)
                {
                    divisionCount++;
                    newString = string.Empty;
                }
            }
        }
        
        return divisionCount;
    }
}