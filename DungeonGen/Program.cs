using System;

namespace DungeonGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] directions = new int[][]
            {
                new int[] {-1,  0 },
                new int[] { 1,  0 },
                new int[] { 0, -1 },
                new int[] { 0,  1 }
            };

            int[] dir = new int[] { 0, 0 };
            int[] lastDir = new int[] { 0, 0 };

            Console.WriteLine("Enter number of cells for map:");
            int dimension = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max hallway length:");
            int maxLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max number of hallways:");
            int maxHallways = Convert.ToInt32(Console.ReadLine());

            int[,] map = new int[dimension, dimension];

            var random = new Random();

            int r = random.Next(dimension);
            int c = random.Next(dimension);

            while (maxHallways > 0)
            {
                do
                {
                    dir = directions[random.Next(directions.Length)];
                }
                while (
                    dir[0] == -lastDir[0] && dir[1] == -lastDir[1] ||
                    dir[0] == lastDir[0] && dir[1] == lastDir[1]
                );

                int length = random.Next(maxLength);
                int hallLength = 0;
                while(hallLength < length)
                {
                    if(r == 0 && dir[0] == -1 || c == 0 && dir[1] == -1 ||
                       r == dimension - 1 && dir[0] == 1 || c == dimension - 1 && dir[1] == 1)
                    {
                        break;
                    }
                    else
                    {
                        map[r, c] = 1;
                        r += dir[0];
                        c += dir[1];
                        hallLength++;
                    }
                }
                lastDir = dir;
                maxHallways--;
            }
            writeMap(map);
            Console.ReadLine();
        }

        static void writeMap(int[,] map)
        {
            for(int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if(map[i,j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
