using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int[,] result;
        int rowCount = arr.GetLength(0);
        int colCount = arr.GetLength(1);
        
        bool isNeedMoreColumns = colCount < rowCount;
        if (isNeedMoreColumns)
        {
            result = new int[rowCount, rowCount];
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < rowCount; colIndex++)
                {
                    if (colIndex < colCount)
                        result[rowIndex, colIndex] = arr[rowIndex, colIndex];
                    else
                        result[rowIndex, colIndex] = 0;
                }
            }
        }
        else
        {
            result = new int[colCount, colCount];
            for (int rowIndex = 0; rowIndex < colCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    if (rowIndex < rowCount)
                        result[rowIndex, colIndex] = arr[rowIndex, colIndex];
                    else
                        result[rowIndex, colIndex] = 0;
                }
            }
        }
        
        return result;
    }
}