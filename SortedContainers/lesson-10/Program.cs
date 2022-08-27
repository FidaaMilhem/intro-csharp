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
            for (int i = 0; i < n; i++)
            {
                var x = random.Next(1, 20);
                sn.Add(x);
            }            
        }



        static void Main(string[] args)
        {

            

            Console.WriteLine("__list______________________");

            var snl = new SortedNumbersList();
            snl.Add(4);
            snl.Add(8);
            snl.Add(10);
            snl.Add(2);
            snl.Add(6);
            snl.Add(5);
            snl.Add(9);
            Print(snl);
            Console.WriteLine("__remove________________");
            snl.Remove(4);
            Print(snl);
            Console.WriteLine("___fill_______________");
            Fill(snl, 10);
            Print(snl);
            Console.WriteLine("___fill_______________");
            Fill(snl, 10);
            Print(snl);

            Console.WriteLine("\n\n_array_________________");
            int l = 10;
            var sna = new SortedNumbersArray(10);
            sna.Add(8);
            sna.Add(10);
            sna.Add(2);
            sna.Add(5);
            Print(sna);

            Console.WriteLine("______remove______________");
            sna.Remove(8);
            Print(sna);
            Console.WriteLine("____fill______________");
            Fill(sna, 10);
            Print(sna);
        }
    }
}