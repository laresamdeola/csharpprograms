using System;

class GuessTheNumber
{
    public string guess;
    public bool gameState = true;

    public int randomNumber()
    {
        Random rand = new Random();
        //Console.WriteLine(rand.Next(100, 110));
        return rand.Next(20, 25);
    }

    public void guessGame()
    {
        Console.WriteLine("Guess a number ");
        guess = Console.ReadLine();
        int guessNumber = Convert.ToInt32(guess);
        int randomizedNumber = randomNumber();
        //Console.WriteLine(randomizedNumber);

        if (randomizedNumber == guessNumber)
        {
            Console.WriteLine("You won");
            gameState = false;
        }
        else if (randomizedNumber > guessNumber)
        {
            Console.WriteLine("Guess Higher");
        }
        else
        {
            Console.WriteLine("Guess Lower");
        }
    }
}

// The game should be in limbo while till its finished.