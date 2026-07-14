using System;

public class Solution
    {
        public int solution(int n, int[,] computers)
        {
            bool[] visited = new bool[n];
            int networkCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (!visited[i])
                {
                    DFS(i, n, computers, visited);
                    networkCount++;
                }
            }
            
            return networkCount;
        }

        private void DFS(int current, int n, int[,] computers, bool[] visited)
        {
            visited[current] = true;

            for (int next = 0; next < n; next++)
            {
                if (computers[current, next] == 1 && !visited[next])
                {
                    DFS(next, n, computers, visited);
                }
            }
        }
    }