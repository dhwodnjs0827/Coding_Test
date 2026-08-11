using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];

        Dictionary<char, int> keyCostDict = new();
        for (int i = 0; i < keymap.Length; i++)
        {
            for (int j = 0; j < keymap[i].Length; j++)
            {
                if (keyCostDict.ContainsKey(keymap[i][j]))
                {
                    if (keyCostDict[keymap[i][j]] > j + 1)
                    {
                        keyCostDict[keymap[i][j]] = j + 1;
                    }
                }
                else
                {
                    keyCostDict.Add(keymap[i][j], j + 1);
                }
            }
        }

        for (int i = 0; i < targets.Length; i++)
        {
            int cost = 0;
            for (int j = 0; j < targets[i].Length; j++)
            {
                if (!keyCostDict.ContainsKey(targets[i][j]))
                {
                    cost = -1;
                    break;
                }
                cost += keyCostDict[targets[i][j]];
            }
            answer[i] = cost;
        }
        return answer;
    }
}