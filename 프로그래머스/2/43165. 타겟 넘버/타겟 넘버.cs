using System;

public class Solution
    {
        public int solution(int[] numbers, int target)
        {
            int answer = 0;
            
            answer = DFS(numbers, target, 0, 0);
            
            return answer;
        }

        private int DFS(int[] number, int target, int index, int sum)
        {
            if (index == number.Length)
            {
                return sum == target ? 1 : 0;
            }

            int plus = DFS(number, target, index + 1, sum + number[index]);
            int minus = DFS(number, target, index + 1, sum - number[index]);
            
            return plus + minus;
        }
    }