namespace SelectionStatementExercise
{
    public class Program
    {
        public static string GetDrinkByProfession(string p)
        {
            string userInput = Console.ReadLine();

            return userInput;
        }



        static void Main(string[] args)
        {
            //exercise one -----------

            Random r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess My favorite number...");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber) 
            {
                Console.WriteLine($"{userInput}: <-- This number is too low");
            }

            else if(userInput > favNumber) 
            {
                Console.WriteLine($"{userInput}: <-- This number is too high");
            }

            else
            {
                Console.WriteLine("Yay! you guessed it!");
            }

            //exercise two-------------

            Console.WriteLine("What is your favorite school subject?");

            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                case "algerbra":
                case "geometry":
                case "triginomitry":
                    Console.WriteLine("Math is cool!");
                    break;
                case "science":
                case "biology":
                case "physics":
                case "chemestry":
                    Console.WriteLine("I loooovvveee science!");
                    break;
                case "english":
                    Console.WriteLine("English makes you a better communicator");
                    break;
                case "History":
                    Console.WriteLine("Its always fun to know what happened in the past so we can learn from it! Awesome!");
                    break;
                default:
                    Console.WriteLine("I'm not familiar with that subject");
                    Console.WriteLine("tell me about it!");
                    Console.ReadLine();
                    Console.WriteLine("thats interesting");
                    break;
            }

            // code wars_________
            Console.WriteLine("Type in your profession and I will guess your drink.");
            var prof = Console.ReadLine();

            switch (prof.ToLower())
            {
                case "Jabroni":
                    Console.WriteLine("Patron Tequila is your drink");
                    break;
                case "School Councilor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "Programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "Bike Gang Member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollars");
                     break;
                case "Rapper":
                    Console.WriteLine("Cristal");
                    break;
                    default:
                    Console.WriteLine("beer");
                    break;
            }
        }
    }
}
