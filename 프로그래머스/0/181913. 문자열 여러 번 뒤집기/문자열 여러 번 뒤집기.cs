using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        char[] charArray = my_string.ToCharArray();
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int startIndex = queries[i, 0];
            int endIndex = queries[i, 1];

            while (startIndex < endIndex)
            {
                char tmp = charArray[startIndex];
                charArray[startIndex] = charArray[endIndex];
                charArray[endIndex] = tmp;
                startIndex++;
                endIndex--;
            }
        }
        
        return new string(charArray);
    }
}