namespace lesson_10
{
    internal class Program
    {


        static void Print(SortedNumbers sn)
        {
            for (int i = 0; i < sn.Count(); i++)    
            {
                Console.WriteLine($"SortedNumbers({i} = {sn.Get(i)}");
            }
        }

        static void Fill(SortedNumbers sn, int n)
        {
            Random random = new Random();
            int x;
            for (x = 0; x < n-1 ; x++)
            {
                x= random.Next(1,9);
                sn.Add(x);
            }
            Print(sn);
        }



        static void Main(string[] args)
        {

            Console.WriteLine("_array_________________");
            var sna = new SortedNumbersArray();
            sna.Add(8);
            sna.Add(10);
            sna.Add(2);
            Print(sna);
            Console.WriteLine("______remove______________");
            sna.Remove(8);
            Print(sna);
            Console.WriteLine("____fill______________");
            Fill(sna, 10);

            Console.WriteLine("__list______________________");

            var snl = new SortedNumbersList();
            snl.Add(4);
            snl.Add(8);
            snl.Add(10);
            snl.Add(2);
            Print(snl);
            Console.WriteLine("__remove________________");
            snl.Remove(4);
            Print(snl);
            Console.WriteLine("___fill_______________");
            Fill(snl, 10);




            Console.WriteLine("Hello, World!");
        }
    }
}