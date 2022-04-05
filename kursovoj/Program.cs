namespace MyGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(Main game = new Main())
            {
                game.Run();
            }
        }
    }
}