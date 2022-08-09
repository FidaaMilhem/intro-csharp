namespace lesson_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Life game = new Life(10, 20);

            game.turnon(3, 3);
            game.turnon(3, 4);
            game.turnon(3, 5);
            game.turnon(3, 6);
            game.turnon(3, 7);
            game.turnon(8, 12);
            game.turnon(9, 12);
            game.turnon(10, 12);
            


            for (int i = 0; i < 10 ; i++)
            {
                game.print();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                game.next_generation();

            }
        }
    }
}