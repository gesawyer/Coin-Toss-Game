using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            
            int i = 0;
            int numberHeads = 0;
            int numberTails = 0;
            int correctCount = 0;

            Console.WriteLine("Hello, friendo. Welcome to the Coin Toss game. How many coin tosses would you like ? ");

            string input = Console.ReadLine();
            int numberOfFlips = int.Parse(input);


            Console.WriteLine("Ok! Out of those " + numberOfFlips + " tosses, do you think there will be more heads or tails?");

            string headsOrTailsGuess = Console.ReadLine();
            Console.WriteLine();


            do
            {
                int toss = rnd.Next(1, 3);

                i++;

                


                if (toss == 1)
                {
                    numberHeads++;
                    
                    Console.WriteLine("heads");

                    if (headsOrTailsGuess == "heads")
                    {
                        correctCount++;

                    }
                      
                }
                else if (toss == 2)
                {
                    numberTails++;
                    
                    Console.WriteLine("tails");

                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }

                }



            } while (i < numberOfFlips);

           
            Console.WriteLine();
            Console.WriteLine($"Your guess, {headsOrTailsGuess}, came up {correctCount} times.");

            float percentage = (float)correctCount/(float)numberOfFlips * 100;

            Console.WriteLine("That is " + percentage + " percent.");


        } 
            
          

    }
}    
        
