public class Solution
{
    public int solution(int[] number)
    {
        int answer = 0;

        DFS(number, 0, 0, 0, ref answer);

        return answer;
    }

    private void DFS(int[] number, int startIndex, int count, int sum, ref int answer)
    {
        if (count == 3)
        {
            if (sum == 0)
            {
                answer++;
            }

            return;
        }

        for (int i = startIndex; i < number.Length; i++)
        {
            DFS(number, i + 1, count + 1, sum + number[i], ref answer);
        }
    }
}