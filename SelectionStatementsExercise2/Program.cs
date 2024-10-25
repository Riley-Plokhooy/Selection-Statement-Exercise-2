namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject() 
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("I think math is okay");
                    break;
                case "science":
                    Console.WriteLine("As Bill Nye once said: Science Rules");
                    break;
                case "pe":
                case "p.e":
                case "physical education":
                    Console.WriteLine("P.E. is fun on occasion");
                    break;
                case "history":
                    Console.WriteLine("History is boring in my opinion");
                    break;
                case "geography":
                    Console.WriteLine("It's okay I guess");
                    break;
                case "lunch":
                    Console.WriteLine("You are a genius");
                    break;
                default:
                    Console.WriteLine("Im going to pretend that I wrote code for that as well. Thats a great subject!");
                    break;
            }
        }
    }
}