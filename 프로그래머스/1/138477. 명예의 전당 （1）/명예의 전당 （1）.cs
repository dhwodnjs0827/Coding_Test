using System.Collections.Generic;

public class Solution
{
    public int[] solution(int k, int[] score)
    {
        int[] answer = new int[score.Length];
        var priorityQueue = new PriorityQueue<int, int>();

        for (int i = 0; i < score.Length; i++)
        {
            if (priorityQueue.Count < k)
            {
                priorityQueue.Enqueue(score[i], score[i]);
            }
            else if (priorityQueue.Peek() < score[i])
            {
                priorityQueue.Dequeue();
                priorityQueue.Enqueue(score[i], score[i]);
            }
            answer[i] = priorityQueue.Peek();
        }
        return answer;
    }
}