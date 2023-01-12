using System;

class Program
{
    static void Main(string[] args)
    {   
        // Parts 1 and 2, the user give the number
        
        //Console.Write("What is the magic number? ");
        //string magicNumber = Console.ReadLine();
        // int number = int.Parse(magicNumber);

        // Part 3 - random njumber
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);


        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
        
    }
}