namespace SelectionStatementExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 3);



            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");

            }

            else if (userInput > favNumber)
            {
                Console.WriteLine ("too high");


            }

            else
            {
                Console.WriteLine("you guessed correctly");
            }

            Console.WriteLine("What is your favorite school subject");
            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "english":
                    Console.WriteLine("boring subject");
                    break;

                case "history":
                    Console.WriteLine("easiest subject");
                    break;

                case "athletics":
                    Console.WriteLine("best time of the day");
                    break;


                case "music":
                    Console.WriteLine("show up and pass");
                    break;

                case "economics":
                    Console.WriteLine("you better study");
                    break;


                default:
                    Console.WriteLine("no class today");
                    break;

                

            }
            


        }





    }
}
