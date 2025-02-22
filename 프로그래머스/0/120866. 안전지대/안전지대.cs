using System;

public class Solution {
    public int solution(int[,] board) {
        ArrayHelper.Initialize(board);
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (board[row, col] == 1)
                {
                    // 위 셋
                    if (ArrayHelper.IsValueNotEquals(row - 1, col - 1, 1))
                        board[row - 1, col - 1] = 2;
                    if (ArrayHelper.IsValueNotEquals(row - 1, col, 1))
                        board[row - 1, col] = 2;
                    if (ArrayHelper.IsValueNotEquals(row - 1, col + 1, 1))
                        board[row - 1, col + 1] = 2;
                    
                    // 중간 둘
                    if (ArrayHelper.IsValueNotEquals(row, col - 1, 1))
                        board[row, col - 1] = 2;
                    if (ArrayHelper.IsValueNotEquals(row, col + 1, 1)) 
                        board[row, col + 1] = 2;
                    
                    // 아래 셋
                    if (ArrayHelper.IsValueNotEquals(row + 1, col - 1, 1))
                        board[row + 1, col - 1] = 2;
                    if (ArrayHelper.IsValueNotEquals(row + 1, col, 1))
                        board[row + 1, col] = 2;
                    if (ArrayHelper.IsValueNotEquals(row + 1, col + 1, 1)) 
                        board[row + 1, col + 1] = 2;
                }
            }
        }
        
        
        int answer = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
                answer += board[row, col] == 0 ? 1 : 0;
        }
        
        return answer;
    }
    
    public static class ArrayHelper
    {
        private static int[,] _array;
        private static int _rows;
        private static int _cols;
    
        public static void Initialize(int[,] array)
        {
            _array = array;
            _rows = array.GetLength(0);
            _cols = array.GetLength(1);
        }
    
        public static bool IsValueNotEquals(int row, int col, int value) => IsValidIndex(row, col) && _array[row, col] != value;
        
        public static bool IsValidIndex(int row, int col) => row >= 0 && row < _rows && col >= 0 && col < _cols;
    }
}