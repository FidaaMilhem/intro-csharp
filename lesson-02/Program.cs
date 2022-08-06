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
        
        static int countlive(int[,] board, int i,int j)
        {
            int count=0;
            for (int m = -1; m < 2; m++)
            {
                for (int s = -1; s < 2; s++)
                {
                    count = count + board[i + m , j + s];
                }
                
            }
            return count;   
        }
      
        static bool livecell(int[,] border, int i, int j)
        {
            return border[i, j] == 1;
        }

       
        static int [,] new_generation(int[,] board)
        {
            int h = board.GetLength(0); // hight
            int w = board.GetLength(1); // weight
            int[,] b =  new int[h, w];

            for (int i = 1; i < h - 1; i++)
            {
                for (int j = 1; j < w - 1; j++)
                {
                    int c = countlive(board, i, j);
                    if (livecell(board, i, j))
                    {

                        if ((c == 3) || (c == 4))
                        {
                            b[i, j] = 1;
                        }
                        else
                        {
                            b[i, j] = 0;            
                        }
                    }
                    else if (c == 3)
                    {
                        b[i, j] = 1;
                    }
                    else
                    {
                        b[i, j] = 0;
                    }
                }
            }
            return b;    
        }
        
        static void Main(string[] args)
        {
            int[,] board = {
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 1, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 0, 1, 0, 0, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 1, 0},
                {0, 0, 1, 0, 0, 1, 0, 0, 0},
                {0, 0, 0, 0, 1, 0, 0, 0, 0},
                {0, 1, 0, 1, 0, 0, 1, 0, 0},
                {0, 1, 0, 0, 1, 0, 0, 0, 0},
                {0, 0, 1, 1, 1, 0, 0, 1, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},

            };

                

            for (int e = 0; e < 10; e++)
            {
                Print(board);
                Console.WriteLine(" \n");
                board = new_generation(board);
            }
        }
        
    }
}