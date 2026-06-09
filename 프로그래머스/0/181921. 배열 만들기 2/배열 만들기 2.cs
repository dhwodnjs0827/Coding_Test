using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> numList = new List<int>();
        for (int x = l; x <= r; x++)
        {
            bool isFiveOrZeroContain = true;
            string numStr = x.ToString();
            foreach (var num in numStr)
            {
                if (num != '5' && num != '0')
                {
                    isFiveOrZeroContain = false;
                    break;
                }
            }

            if (isFiveOrZeroContain)
            {
                numList.Add(x);
            }
        }
        
        if (numList.Count == 0)
        {
            numList.Add(-1);
        }
        
        return numList.ToArray();
    }
}