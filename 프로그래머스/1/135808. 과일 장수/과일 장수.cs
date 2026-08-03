using System.Linq;

public class Solution
{
    public int solution(int k, int m, int[] score)
    {
        int answer = 0;

        int[] sortedScore = score.Order().ToArray();
        int scoreLength = sortedScore.Length;
        int remain = scoreLength % m;
        for (int i = remain; i < scoreLength; i = i + m)
        {
            answer += sortedScore[i] * m;
        }
        
        return answer;
    }
}