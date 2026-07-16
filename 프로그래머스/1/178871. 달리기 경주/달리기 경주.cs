using System;
using System.Collections.Generic;

public class Solution
    {
        public string[] solution(string[] players, string[] callings)
        {
            Dictionary<string, int> playerRanks = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++)
            {
                playerRanks.Add(players[i], i);
            }
            
            foreach (var calling in callings)
            {
                int idx = playerRanks[calling];
                int prevIdx = idx - 1;

                (players[idx], players[prevIdx]) = (players[prevIdx], players[idx]);
                
                playerRanks[players[idx]] = idx;
                playerRanks[players[prevIdx]] = prevIdx;
            }

            return players;
        }
    }