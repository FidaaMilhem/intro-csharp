namespace lesson_01
{
    internal class Program
    {


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
        static void Print_2(int[] list)
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
            Print_2(number2);

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




            Console.WriteLine("Fin");
        }
    }
}