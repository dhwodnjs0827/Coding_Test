using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int rows = queries.GetLength(0);

        for (int i = 0; i < rows; i++)
        {
            int tmp = arr[queries[i, 0]];
            arr[queries[i, 0]] = arr[queries[i, 1]];
            arr[queries[i, 1]] = tmp;
        }

        return arr;
    }
}