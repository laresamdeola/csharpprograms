using System;

class GuessTheNumber
{
    public string guess;
    public bool gameState = true;
    public static int maxEntered = 10;
    public static int minEntered = 1;
    public int count = 1;

    public static int randomNumber()
    {
        Random rand = new Random();
        //Console.WriteLine(rand.Next(100, 110));
        return rand.Next(minEntered, maxEntered);
    }

    int randomizedNumber = randomNumber();

    public void userRandomNumbers()
    {
        Console.WriteLine("Do you want to enter the minimum and maximum guess?");
        string choice = Console.ReadLine();
        if (choice.ToLower() == "yes" || choice == "y" || choice == "ok")
        {
            Console.WriteLine("What is you maximum guess?");
            maxEntered = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is you minimum guess?");
            minEntered = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            maxEntered = 10;
            minEntered = 1;
        }
    }

    public void guessGame()
    {
        
        Console.WriteLine("Guess a number ");
        guess = Console.ReadLine();
        int guessNumber = Convert.ToInt32(guess);
        Console.WriteLine(randomizedNumber);
        if (randomizedNumber > guessNumber)
        {
            Console.WriteLine("Guess Higher");
        }
        else if (randomizedNumber < guessNumber)
        {
            Console.WriteLine("Guess Lower");
        }
        else if (randomizedNumber == guessNumber)
        {
            Console.WriteLine("You won");
            gameState = false;
        }
    }
}

// The game should be in limbo while till its finished.