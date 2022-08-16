namespace lesson_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameOfLife game = new GameOfLife(10, 20);

            game.TurnOn(3, 3);
            game.TurnOn(3, 4);
            game.TurnOn(3, 5);
            game.TurnOn(3, 6);
            game.TurnOn(3, 7);
            game.TurnOn(8, 12);
            game.TurnOn(9, 12);
            game.TurnOn(10, 12);
            


            for (int i = 0; i < 10 ; i++)
            {          
                Console.WriteLine(game);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                game.ComputeNextGeneration();
            }            
        }
    }
}