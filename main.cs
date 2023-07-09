using System;

class Program
{
    public static void Main(string[] args)
    {
        /*
        Quiz countryQuiz = new Quiz();
        countryQuiz.gamePlay();
        */
        GuessTheNumber trial = new GuessTheNumber();
        //trial.userRandomNumbers();
        while (trial.gameState)
        {
            trial.guessGame();
        }
    }
}
