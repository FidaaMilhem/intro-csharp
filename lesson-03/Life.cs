using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_03
{
    internal class Life
    {
        private int rows;
        private int columns;
        private cellstate[ , ]  matrix_2;
        public cellstate[ , ] matrix;


        public  Life(int rows, int columns)
        {
            this.rows = rows + 2;
            this.columns = columns + 2;
            Console.WriteLine();
            matrix = new cellstate[this.rows, this.columns];
            matrix_2 = new cellstate[this.rows, this.columns];
          

        }

        
        public void turnon(int i, int j)
        {
            this.matrix[i, j] = cellstate.IsAlive;
        }

        public void turnoff(int i, int j)
        {
            this.matrix[i, j] = cellstate.IsDead;
        }

        public bool livecell(int i, int j)
        {
            return this.matrix[i, j] == cellstate.IsAlive;
        }
        public bool deadcell(int i, int j)
        {
            return this.matrix[i, j] == cellstate.IsDead;
        }
        public void print()
        {
            char live = '#';
            char dead = '-';

            for (int i = 1; i < this.rows -1 ; i++)
            {
                for (int j = 1; j < this.columns -1  ; j++)
                {
                    if (this.livecell(i,j))
                    {
                        Console.Write(live);
                    }
                    else
                    {
                        Console.Write(dead);
                    }

                }
                Console.WriteLine();
            }

        }
        private int countlive(int i, int j)
        {
            int count = 0;
            for (int m = -1; m < 2; m++)
            {
                for (int s = -1; s < 2; s++)
                {
                    count = count + (int)this.matrix[i + m, j + s];
                }
            }
            return count;
        }

        private void copy_matrix()
        {

            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns - 1; j++)
                {
                    matrix[i, j] = matrix_2[i, j];
                }
            }
        }
        public void next_generation()
        {

            for (int i = 1; i < this.rows - 1; i++)
            {
                for (int j = 1; j < this.columns - 1; j++)
                {
                    int c = this.countlive( i, j);
                    if (this.livecell(i,j))
                    {

                        if ((c == 3) || (c == 4))
                        {
                            this.matrix_2[i, j] = cellstate.IsAlive;  
                        }
                        else
                        {
                            this.matrix_2[i, j] = cellstate.IsDead;
                        }
                    }
                    else if (c == 3)
                    {
                        this.matrix_2[i, j] = cellstate.IsAlive;
                    }
                    else
                    {
                        this.matrix_2[i, j] = cellstate.IsDead;
                    }
                }
            }
         this.copy_matrix();
        }

    }

}
