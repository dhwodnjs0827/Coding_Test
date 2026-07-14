using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string begin, string target, string[] words)
        {
            HashSet<string> visited = new();
            Queue<(string word, int count)> queue = new();
            queue.Enqueue((begin, 0));

            while (queue.Count > 0)
            {
                (string word, int count) current = queue.Dequeue();

                if (current.word == target)
                {
                    return current.count;
                }
                
                for (int i = 0; i < words.Length; i++)
                {
                    int diffCount = 0;
                    for (int j = 0; j < current.word.Length; j++)
                    {
                        if (current.word[j] != words[i][j])
                        {
                            diffCount++;
                        }
                    }
                    
                    if (diffCount == 1 && visited.Add(words[i]))
                    {
                        queue.Enqueue((words[i], current.count + 1));
                    }
                }
            }
            
            return 0;
        }
}