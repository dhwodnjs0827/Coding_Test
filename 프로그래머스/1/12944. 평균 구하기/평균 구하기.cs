using System.Linq;

public class Solution
{
    public double solution(int[] arr)
    {
        double sum = arr.Sum();
        return sum / arr.Length;
    }
}