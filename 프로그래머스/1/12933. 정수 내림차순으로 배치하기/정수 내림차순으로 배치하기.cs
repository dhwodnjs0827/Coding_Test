using System.Linq;

public class Solution
{
    public long solution(long n)
    {
        return long.Parse(new string(n.ToString().OrderByDescending(x => x).ToArray()));
    }
}