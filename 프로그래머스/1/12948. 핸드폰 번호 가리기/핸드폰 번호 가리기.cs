public class Solution
{
    public string solution(string phone_number)
    {
        int length = phone_number.Length;
        string answer = string.Empty;

        for (int i = 0; i < length; i++)
        {
            if (i >= length - 4 && i <= length - 1)
            {
                answer += phone_number[i];
            }
            else
            {
                answer += "*";
            }
        }
        
        return answer;
    }
}