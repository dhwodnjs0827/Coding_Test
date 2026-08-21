using System.Text;

public class Solution
{
    public string solution(string s)
    {
        StringBuilder sb = new StringBuilder();
        string[] words = s.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLower();

            for (int j = 0; j < words[i].Length; j++)
            {
                if (j == 0)
                {
                    sb.Append(words[i][j].ToString().ToUpper());
                }
                else
                {
                    sb.Append(words[i][j]);
                }
            }

            if (i != words.Length - 1)
            {
                sb.Append(' ');
            }
        }
        return sb.ToString();
    }
}