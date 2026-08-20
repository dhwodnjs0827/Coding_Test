using System;

class Solution 
{
    public int solution(int n)
    {
        long c = n & (-n);
        long r = n + c;
        long result = r | (((n ^ r) / c) >> 2);
        return (int)result;
    }
}