using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] ingredient)
    {
        int answer = 0;
        int[] hamburger = [1, 2, 3, 1];
        
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < ingredient.Length; i++)
        {
            stack.Push(ingredient[i]);
            if (stack.Count >= 4)
            {
                int[] temp = new int[4];
                for (int j = 3; j >= 0; j--)
                {
                    temp[j] = stack.Pop();
                }

                if (temp.SequenceEqual(hamburger))
                {
                    answer++;
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        stack.Push(temp[j]);
                    }
                }
            }
        }

        return answer;
    }
}