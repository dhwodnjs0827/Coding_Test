public class Solution
{
    public int[] solution(int n, int m)
    {
        int[] arr = new int[2];
        arr[0] = GCD(n, m);
        arr[1] = LCM(n, m);
        return arr;
    }

    private int GCD(int n, int m)
    {
        while (m != 0)
        {
            int tmp = m;
            m = n % m;
            n = tmp;
        }

        return n;
    }

    private int LCM(int n, int m)
    {
        return (n / GCD(n, m)) * m;
    }
}