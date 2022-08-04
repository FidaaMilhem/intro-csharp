namespace lesson_01
{
    internal class Program
    {


        static void print(double[] list)
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
        static double sum(double[] lst)
        {
            double s = 0.0;
            for (int i = 0; i < lst.Length; i++)
            {
                s += lst[i];
            }

            return s;
        }

        static void Main(string[] args)
        {
          
            double[] numbers = { 1.1,3.0,5.2 };
            

            print(numbers);

            Console.WriteLine(sum(numbers));




            Console.WriteLine("Fin");
        }
    }
}