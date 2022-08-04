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


        static void Main(string[] args)
        {
          
            double[] numbers = { 1.1,3.0,5.2 };
            //double[] numbers = {};
            //double[] numbers = { 1.1, 3.0, -5.2 };


            Print(numbers);

            Console.WriteLine($"THE sum IS : {Sum(numbers)}");

            if (numbers.Length > 0)
            {
                Console.WriteLine($"THE AVG IS : {Avg(numbers)}");
            }
            
            




            Console.WriteLine("Fin");
        }
    }
}