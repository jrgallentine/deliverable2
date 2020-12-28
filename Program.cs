using System;



namespace DeliverableTwo
{
    class Program
    {
        static int Coin()
        {
            Random rng = new Random();
            return rng.Next(0, 2);
        }

        static void Main(string[] args)
        {




            double heads = 0;
            double tails = 0;



            Console.Write("---Heads or tails? ");

            bool headsOrTailsGuess = true;
            switch (Console.ReadLine())
            {
                case "heads": headsOrTailsGuess = true; break;
                case "tails": headsOrTailsGuess = false; break;
            }



            Console.Write("---How many times shall we flip? ");
            double numberOfFlips = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfFlips; i++)
            {
                if (Coin() == 0)
                {
                    Console.WriteLine("Heads");
                    heads++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tails++;
                }





            }
            double correctCount = heads;
            double correctCount2 = tails;
            //I am struggling to figure out how to do this with a single "correctCount" with the current structure I've built//
            double hperc = 100 * (correctCount / numberOfFlips);
            double tperc = 100 * (correctCount2 / numberOfFlips);






            if (headsOrTailsGuess == true)
            {
                Console.WriteLine("---Your selection, heads, came up " + correctCount + " time(s)!");
                Console.WriteLine("---That's " + (Math.Round(hperc, 1)) + "%");
            }


            else
            {
                Console.WriteLine("---Your selection, tails, came up " + correctCount2 + " time(s)!");
                Console.WriteLine("---That's " + (Math.Round(tperc, 1)) + "%");
            }





        }
    }
}
