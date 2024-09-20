using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] maps)
    {
        return FindPath(maps);
    }

    private int FindPath(int[,] maps)
    {
        int endPointX = maps.GetLength(1);
        int endPointY = maps.GetLength(0);

        (int dx, int dy)[] directions = {
            (1, 0),
            (0, 1),
            (-1, 0),
            (0, -1),
        };

        Queue<(int x, int y, int step)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((0, 0, 1));

        bool[,] visited = new bool[endPointY, endPointX];
        visited[0, 0] = true;

        while (queue.Count > 0)
        {
            var (x, y, step) = queue.Dequeue();

            if (x == endPointX - 1 && y == endPointY - 1)
                return step;

            foreach ((int dx, int dy) direction in directions)
            {
                int nextX = x + direction.dx;
                int nextY = y + direction.dy;

                if (nextX < 0 || nextX >= endPointX || nextY < 0 || nextY >= endPointY)
                    continue;
                if (maps[nextY, nextX] == 1 && !visited[nextY, nextX])
                {
                    visited[nextY, nextX] = true;
                    queue.Enqueue((nextX, nextY, step + 1));
                }
            }
        }

        return -1;
    }
}
