namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your favorite class");
            string favoriteClass = Console.ReadLine().ToLower();

            switch (favoriteClass)
            {
                case "chemistry":
                    Console.WriteLine("Walter White coming in");
                    break;
                case "math":
                    Console.WriteLine("Do you celebrate Pi Day?");
                    break;
                case "gym":
                    Console.WriteLine("Sam Sulek or The Rock?");
                    break;
                case "english":
                    Console.WriteLine("A rose by any other name would smell just as sweet");
                    break;
                case "shop":
                    Console.WriteLine("Let's make clocks and soupe up our cars");
                    break;
                default:
                    Console.WriteLine("No idea what that is. How about you describe it to me. I promise I'll listen.");
                    break;
            }
            Console.ReadLine();
        }
    }
}