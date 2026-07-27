using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        if (arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }

        int minIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[minIndex] > arr[i])
            {
                minIndex = i;
            }
        }

        var list = arr.ToList();
        list.RemoveAt(minIndex);
        
        return list.ToArray();
    }
}