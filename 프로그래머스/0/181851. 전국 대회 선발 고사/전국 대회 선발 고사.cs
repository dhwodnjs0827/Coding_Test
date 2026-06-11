using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] rank, bool[] attendance)
    {
        int answer = 0;
        Dictionary<int, int> rankDict = new Dictionary<int, int>();
        for (int i = 0; i < rank.Length; i++)
        {
            if (attendance[i])
            {
                rankDict.Add(rank[i], i);
            }
        }
        List<int> rankIndexList = new List<int>();
        var keyValuePairs = rankDict.OrderBy(o => o.Key);
        foreach (var keyValuePair in keyValuePairs)
        {
            rankIndexList.Add(keyValuePair.Value);
        }
        answer = 10000 * rankIndexList[0] + 100 * rankIndexList[1] + rankIndexList[2];
        
        
        return answer;
    }
}