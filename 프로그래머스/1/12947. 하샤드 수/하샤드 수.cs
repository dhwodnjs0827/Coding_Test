public class Solution
{
    public bool solution(int x)
    {
        string num = x.ToString();
        int sum = 0;
        
        foreach (char c in num)
        {
            sum += int.Parse(c.ToString());
        }

        if (x % sum == 0)
        {
            return true;
        }

        return false;
    }
}