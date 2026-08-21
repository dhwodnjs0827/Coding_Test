public class Solution
{
    public int solution(int[] arr)
    {
        var result = LCM(arr[0], arr[1]);
        
        for (int i = 2; i < arr.Length; i++)
        {
            result = LCM(result, arr[i]);
        }
        
        return result;
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    private int LCM(int a, int b)
    {
        return a / GCD(a, b) * b;
    }
}