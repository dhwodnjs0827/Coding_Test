using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        char[] charArray = s.ToCharArray();
        int length = charArray.Length;
        char[] newCharArray = new char[length];
        for (int i = 0; i < length; i++)
        {
            char newChar = charArray[i];
            for (int j = 0; j < index; j++)
            {
                newChar += (char)1;
                if (newChar > 'z')
                {
                    newChar = 'a';
                }
                while (skip.Contains(newChar))
                {
                    newChar += (char)1;
                    if (newChar > 'z')
                    {
                        newChar = 'a';
                    }
                }
            }
            newCharArray[i] = newChar;
        }
        return new string(newCharArray);
    }
}