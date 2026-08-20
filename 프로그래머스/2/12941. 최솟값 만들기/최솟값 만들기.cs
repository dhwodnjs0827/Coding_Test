using System;

public class Solution
{
    public int solution(int[] A, int[] B)
    {
        int result = 0;
        Array.Sort(A);
        Array.Sort(B);
        for (int i = 0; i < A.Length; i++)
        {
            result += A[i] * B[B.Length - 1 - i];
        }
        return result;
    }
}