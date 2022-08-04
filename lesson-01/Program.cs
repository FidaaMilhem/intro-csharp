namespace lesson_01
{
    internal class Program
    {
        static void pprint(int[][] matrix)
        {
            foreach(var row in matrix)
            {
                Print(row);
            }
        }
        static void pprint(int[,] matrix)
        {   
            Console.WriteLine("{");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix.GetLength(1) > 0)
                {
                    Console.Write($" [ {matrix[i, 0]}");
                }
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    Console.Write($", {matrix[i, j]}");
                }
                Console.WriteLine(" ]");
            }
            Console.WriteLine("}");
        }


        //static int diagonals(int[,] matrix)


        //    for (int i = 0; i<n; i++)
        //    {
        //        sumd1 += matrix[i, i];
        //        dumd2 += matrix[i, n - 1 - i];
        //    }

    static bool ismagicsuare(int [ , ] matrix )
        {
            int n = matrix.GetLength(0);

            //int[] diags = diagonals(...);
            //if (duag[0] == diags[1])
            int sumd1 = 0, dumd2 = 0;    // sum of diagonal 

            for (int i = 0; i < n; i++)
            {
                sumd1 += matrix[i, i];
                dumd2 += matrix[i, n - 1 - i];
            }

            if (sumd1 != dumd2)
                {
                    return false; 
        }
                   

             
            
            for (int i = 0; i < n; i++)
            {
                int rowsum = 0, colsum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowsum += matrix[i, j];
                    colsum += matrix[j, i];
                }
                if (rowsum != colsum || colsum != sumd1)
                {
                    return false;
                }
                   

            }
            return true;           
        }
        



        static void Print(double[] list)
        {
            if (list is null)
            {
                Console.WriteLine("Nothing");
                return;
            }

            Console.Write("[ ");

            if (list.Length > 0)
            {
                Console.Write($"{list[0]}");
            }

            for (int i = 1; i < list.Length; i++)
            {
                Console.Write($", {list[i]}");
            }
            Console.WriteLine(" ]");
        }
        static void Print(int[] list)
        {
            if (list is null)
            {
                Console.WriteLine("Nothing");
                return;
            }

            Console.Write("[ ");

            if (list.Length > 0)
            {
                Console.Write($"{list[0]}");
            }

            for (int i = 1; i < list.Length; i++)
            {
                Console.Write($", {list[i]}");
            }
            Console.WriteLine(" ]");
        }
        static double Sum(double[] lst)
        {
            double s = 0.0;
            for (int i = 0; i < lst.Length; i++)
            {
                s += lst[i];
            }

            return s;
        }
        static double Avg(double[] list)
        {  
            return Sum(list) / list.Length ;
        }


        static double Discriminant(int a, int b, int c)
        {
            return (b * b )- (4 * a * c);
        }


        static void Solve_quadratic(int a, int b, int c, double delta)
        {
           
            
            if (delta == 0)
            {
                double root = -b / 2 * a;
                Console.WriteLine($"has one solution: {root}");
            }
            else 
            {
                double d_square_root = Math.Sqrt(delta);
                double root_1 = (-b + d_square_root) / (2 * a);
                double root_2 = (-b - d_square_root) / (2 * a);
                Console.WriteLine($"has two solution: {root_1}, {root_2}");

            }
          



        }


        static void Main(string[] args)
        {
          
            double[] numbers = { 1.1,3.0,5.2 };
            //double[] numbers = {};
            int[] number2 = { 1,2,3,4 };


            Print(numbers);
            Print(number2);

            Console.WriteLine($"THE sum IS : {Sum(numbers)}");

            if (numbers.Length > 0)
            {
                Console.WriteLine($"THE AVG IS : {Avg(numbers)}");
            }

            int a = 1;
            int b = 6;
            int c = 9;
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
            
            double delta = Discriminant(a, b, c);
            if (delta >= 0 )
            {
                Solve_quadratic(a, b, c,delta);
                
            }
            else
            {
                Console.WriteLine("has no real solutions");
            }

            
            //(3, 2, 1)
            //(1, -4, -2)
            //(1, 6, 9)

            int[,] matrix = new int[ , ]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8 ,9 }
            };

            int[,] matrix2 = new int[,]
            {
                { 2, 7, 6 },
                { 9, 5, 1 },
                { 4, 3 ,8 }
            };

            
            
            if (ismagicsuare(matrix))
            {
               Console.WriteLine("magic square");
            }
            else
            {
                Console.WriteLine("not a magic square");
            }

            if (ismagicsuare(matrix2))
            {
                Console.WriteLine("magic square");
            }
            else
            {
                Console.WriteLine("not a magic square");
            }



            Console.WriteLine("Fin");
        }
    }
}