using System;
using System.Collections.Generic;

class Solution
    {
        public int solution(int[,] maps)
        {
            int n = maps.GetLength(0); // 행
            int m = maps.GetLength(1); // 열
            
            var distances = new int[n, m];

            // 해당 칸의 미방문 -1로 표시
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    distances[i, j] = -1;
                }
            }
            
            int[] dx = { -1, 1, 0, 0 }; // x 이동량
            int[] dy = { 0, 0, -1, 1 }; // y 이동량

            Queue<(int x, int y)> queue = new();
            queue.Enqueue((0, 0));
            distances[0, 0] = 1;

            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = x + dx[dir];
                    int ny = y + dy[dir];

                    if (nx < 0 || nx >= n || ny < 0 || ny >= m)
                    {
                        continue;
                    }

                    if (maps[nx, ny] == 0)
                    {
                        continue;
                    }

                    if (distances[nx, ny] != -1)
                    {
                        continue;
                    }

                    distances[nx, ny] = distances[x, y] + 1;
                    queue.Enqueue((nx, ny));
                }
            }

            return distances[n - 1, m - 1];
        }
    }