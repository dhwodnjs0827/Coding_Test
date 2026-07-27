public class Solution
{
    public int solution(int num)
    {
        long n = num;
        int count = 0;
        while (n != 1)
        {
            n = Collatz(n);
            count++;
            if (count == 500)
            {
                return -1;
            }
        }
        
        return count;
    }

    private long Collatz(long n)
    {
        if (n % 2 == 0)
        {
            return n / 2;
        }
        else
        {
            return n * 3 + 1;
        }
    }
}