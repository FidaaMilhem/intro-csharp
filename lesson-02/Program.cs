namespace lesson_02
{
    internal class Program
    {
            static void Print(int[,] board)
            {
            char live = '#';
            char dead = '-';

            for (int i = 1; i < board.GetLength(0) - 1; i++)
                {
                    for (int j = 1; j < board.GetLength(1) - 1; j++)
                    {
                    if (board[i, j] == 1)
                    {
                        Console.Write($"{live}");
                    }
                    else
                    {
                        Console.Write($"{dead}");
                    }

                }
                Console.WriteLine();
                }
            }
        static int[,] deadBoard(int h, int w)
        {
            int[,] B = new int[h, w];
            for (int i = 1; i < h - 2; i++)
            {
                for (int j = 1; j < w - 2; j++)
                {
                    B[i, j] = 0;
                }
            }
            return B;
        }

        static void Main(string[] args)
            {
                //bool endgame = false;
            //    string[,] board =
            //    {
            //    {"-","-","-","-","-","-","-"},
            //    {"-","-","+","+","-","-","+"},
            //    {"-","+","-","-","+","-","-"},
            //    {"+","-","+","+","-","-","+"},
            //    {"-","-","-","+","-","-","-"},
            //    {"-","-","-","+","-","-","-"},
            //    {"-","-","+","-","+","-","-"},
            //    {"+","+","-","-","+","-","+"},
            //    {"-","-","-","-","-","-","-"},
            //    {"-","-","+","-","-","-","-"},
            //    {"-","-","-","+","-","-","-"},
            //    {"-","-","-","-","-","+","-"},
            //};

            int[,] board =
                {
                {0, 1, 0, 0, 0, 1, 0, 0, 0},
                {0, 0, 1, 1, 0, 0, 0, 0, 0},
                {0, 0, 1, 1, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 1, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 1, 1, 0, 1, 0, 0, 1},
                {0, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 1, 1, 0, 0},
                {0, 0, 1, 0, 1, 0, 0, 1, 1},
                {0, 0, 1, 0, 1, 0, 1, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 0},
            };


            int h = board.GetLength(0); // hight
            int w = board.GetLength(1); // weight
            Console.WriteLine($"{h},{w}");
            int[,] newboards = deadBoard(h, w);
            Print(board);
            Print(newboards);









            }
        
    }
}