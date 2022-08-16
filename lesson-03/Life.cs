using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    public class GameOfLife
    {       
        private const char LIVE_CHAR = '#';
        private const char DEAD_CAHR = '-';

        private CellState[,] _matrix;
       
        public  GameOfLife(int rows, int columns)
        {
            rows += 2;
            columns += 2;
            _matrix = new CellState[rows, columns];            
        }

        
        public void TurnOn(int i, int j)
        {
            _matrix[i, j] = CellState.IsAlive;
        }

        public void TurnOff(int i, int j) => _matrix[i, j] = CellState.IsDead;
        
        public bool IsAlive(int i, int j) => _matrix[i, j] == CellState.IsAlive;        

        public bool IsDead(int i, int j) =>  !IsAlive(i, j);

        
        public override string ToString()
        {            
            int rows = _matrix.GetLength(0);
            int columns = _matrix.GetLength(1);

            
            var sb = new StringBuilder();            
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns - 1; j++)
                {
                    if (IsAlive(i, j))
                    {
                        sb.Append(LIVE_CHAR);
                    }
                    else
                    {
                        sb.Append(DEAD_CAHR);
                    }
                }
                sb.AppendLine();
            }
            
            return sb.ToString();
        }
       
        private int aliveNeighbours(int i, int j)
        {
            int count = 0;
            for (int m = -1; m < 2; m++)
            {
                for (int s = -1; s < 2; s++)
                {
                    count += (int)_matrix[i + m, j + s];
                }
            }

            return count; // - (int)matrix[i, j];
        }
      
        public void ComputeNextGeneration()
        {
            int rows = _matrix.GetLength(0);
            int columns = _matrix.GetLength(1);
            var next_gen = new CellState[rows, columns];  
            
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < columns - 1; j++)
                {
                    int c = aliveNeighbours( i, j);
                    if (IsAlive(i,j))
                    {
                        if ((c == 3) || (c == 4))
                        {
                            next_gen[i, j] = CellState.IsAlive;  
                        }
                        else
                        {
                            next_gen[i, j] = CellState.IsDead;
                        }
                    }
                    else if (c == 3)
                    {
                        next_gen[i, j] = CellState.IsAlive;
                    }
                    else
                    {
                        next_gen[i, j] = CellState.IsDead;
                    }
                }
            }        
        
            _matrix = next_gen;
        }
    }

}
