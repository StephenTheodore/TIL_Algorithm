using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[,] arr)
    {
        var answer = new int[2];
        var uniqueValues = arr.Cast<int>().Distinct();
        
        answer[0] = uniqueValues.Count(val => val == 0);
        answer[1] = uniqueValues.Count(val => val == 1);
        
        if (uniqueValues.Count() > 1)
        {   
            var rootNode = new QuadNode(arr);
        
            answer[0] = rootNode.ContainNumberCount(0);
            answer[1] = rootNode.ContainNumberCount(1);
        }
        
        return answer;
    }
    
    private class QuadNode
    {
        private bool isLeaf = false;
        private int[,] Data {get;set;} = null;
        
        public QuadNode NW = null;
        public QuadNode NE = null;
        public QuadNode SW = null;
        public QuadNode SE = null;
        
        public QuadNode(int[,] data)
        {
            Data = data;
            
            if (Data.Length > 1)
            {
                int rows = Data.GetLength(0);
                int cols = Data.GetLength(1);
                int midRow = rows / 2;
                int midCol = cols / 2;
                
                int[,] dataNW = new int[midRow, midCol];
                int[,] dataNE = new int[midRow, midCol];
                int[,] dataSW = new int[midRow, midCol];
                int[,] dataSE = new int[midRow, midCol];
            
                for(int row = 0; row < midRow; row++)
                {
                    for(int col = 0; col < midCol; col++)
                    {
                        dataNW[row, col] = Data[row, col];
                        dataNE[row, col] = Data[row, col + midCol];
                        dataSW[row, col] = Data[row + midRow, col];
                        dataSE[row, col] = Data[row + midRow, col + midCol];
                    }
                }
            
                NW = new QuadNode(dataNW.Cast<int>().Distinct().Count() > 1 ? dataNW : new int[,]{{dataNW[0,0]}});
                NE = new QuadNode(dataNE.Cast<int>().Distinct().Count() > 1 ? dataNE : new int[,]{{dataNE[0,0]}});
                SW = new QuadNode(dataSW.Cast<int>().Distinct().Count() > 1 ? dataSW : new int[,]{{dataSW[0,0]}});
                SE = new QuadNode(dataSE.Cast<int>().Distinct().Count() > 1 ? dataSE : new int[,]{{dataSE[0,0]}});
            }
            else
                isLeaf = true;
        }
        
        public int ContainNumberCount(int number)
        {
            int sum = 0;
            if (isLeaf)
                sum += Data.Cast<int>().Count(element => element == number);
                
            sum += NW?.ContainNumberCount(number) ?? 0;
            sum += NE?.ContainNumberCount(number) ?? 0;
            sum += SW?.ContainNumberCount(number) ?? 0;
            sum += SE?.ContainNumberCount(number) ?? 0;
            return sum;
        }
    }
}