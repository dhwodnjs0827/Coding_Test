using System;
using System.Collections.Generic;

public class Solution
    {
        public int solution(int[,] rectangle, int characterX, int characterY, int itemX, int itemY)
        {
            bool[,] filled = new bool[51, 51];

            for (int i = 0; i < rectangle.GetLength(0); i++)
            {
                for (int x = rectangle[i, 0]; x < rectangle[i, 2]; x++)
                {
                    for (int y = rectangle[i, 1]; y < rectangle[i, 3]; y++)
                    {
                        filled[x, y] = true;
                    }
                }
            }

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            int[,] distance = new int[51, 51];
            for (int i = 0; i < distance.GetLength(0); i++)
            {
                for (int j = 0; j < distance.GetLength(1); j++)
                {
                    distance[i, j] = -1;
                }
            }

            Queue<(int charX, int charY)> queue = new();
            queue.Enqueue((characterX, characterY));
            distance[characterX, characterY] = 0;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                for (int dir = 0; dir < 4; dir++)
                {
                    int nx = current.charX + dx[dir];
                    int ny = current.charY + dy[dir];

                    // 이동 방향(dir)에 따라, 그 선분을 사이에 두고 마주보는 두 "칸"을 비교
                    // 점 (px,py) 기준으로, 왼쪽 위 칸은 filled[px-1, py], 오른쪽 위는 filled[px, py],
                    // 왼쪽 아래는 filled[px-1, py-1], 오른쪽 아래는 filled[px, py-1]
                    bool cellA, cellB;
                    switch (dir)
                    {
                        case 0: // 왼쪽으로 이동 -> 왼쪽 선분의 위/아래 칸 비교
                            cellA = IsFilled(current.charX - 1, current.charY, filled);
                            cellB = IsFilled(current.charX - 1, current.charY - 1, filled);
                            break;
                        case 1: // 오른쪽으로 이동 -> 오른쪽 선분의 위/아래 칸 비교
                            cellA = IsFilled(current.charX, current.charY, filled);
                            cellB = IsFilled(current.charX, current.charY - 1, filled);
                            break;
                        case 2: // 아래로 이동 -> 아래 선분의 좌/우 칸 비교
                            cellA = IsFilled(current.charX - 1, current.charY - 1, filled);
                            cellB = IsFilled(current.charX, current.charY - 1, filled);
                            break;
                        default: // 3: 위로 이동 -> 위 선분의 좌/우 칸 비교
                            cellA = IsFilled(current.charX - 1, current.charY, filled);
                            cellB = IsFilled(current.charX, current.charY, filled);
                            break;
                    }

                    if (cellA == cellB)
                    {
                        
                        continue; // 둘 다 내부거나 둘 다 외부 -> 테두리 아님, 못 감
                    }
                    if (distance[nx, ny] != -1)
                    {
                        
                        continue; // 이미 방문함
                    }

                    distance[nx, ny] = distance[current.charX, current.charY] + 1;
                    queue.Enqueue((nx, ny));
                }
            }

            return distance[itemX, itemY];
        }

        private bool IsFilled(int x, int y, bool[,] filled)
        {
            if (x < 0 || x > 50 || y < 0 || y > 50)
            {
                return false;
            }

            return filled[x, y];
        }
    }