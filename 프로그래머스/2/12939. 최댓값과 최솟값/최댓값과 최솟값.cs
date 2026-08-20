using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        List<int> list = new();
        string[] nums = s.Split(' ');
        for (int i = 0; i < nums.Length; i++)
        {
            list.Add(int.Parse(nums[i]));
        }

        list.Sort();
        return $"{list[0]} {list[^1]}";
    }
}