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
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                var x =  random.Next(1, 20);
                sn.Add(x);
            }
        }


        static void Test01(SortedNumbers sn)
        {
            //var snl = new SortedNumbersList();
            Console.WriteLine("-----------test 01--------------");
            sn.Add(4);

            sn.Add(6);
            sn.Add(5);
            sn.Add(8);
            sn.Add(10);
            sn.Add(20);

            Print(sn);
        }
        static void Test02(SortedNumbers sn)
        {
            Console.WriteLine("-----------test 02--------------");
            //var snl = new SortedNumbersList();
            sn.Add(20);

            sn.Add(10);
            sn.Add(8);
            sn.Add(5);
            sn.Add(6);
            sn.Add(4);
            Print(sn);
        }
        static void Main(string[] args)
        {



            Console.WriteLine("__list______________________");

            var snl = new SortedNumbersList(true);
            Test01(snl);
            snl = new SortedNumbersList(false);
            Test02(snl);
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
            var sna = new SortedNumbersArray(10,true);
            Test01(sna);
            sna = new SortedNumbersArray(10,true) ;
            Test02(sna);

            Console.WriteLine("______remove______________");
            sna.Remove(8);
            Print(sna);
            Console.WriteLine("____fill______________");
            sna = new SortedNumbersArray(10, true);
            Fill(sna, 10);
            Print(sna);
        }
    }
}