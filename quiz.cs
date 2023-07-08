using System;
using System.Linq;

class Quiz
{
    public int score;
    public bool gameState = true;
    public int count;
    public string answer;
    public int celebrate = 1;

    string[] questions = {
    "1. What is the capital of Nigeria? ",
    "2. How many states are in Nigeria?",
    "3. What are the colors of the Nigerian Flag?",
    "4. How many geo-political zones does Nigeria have?",
    "5. Is Igbo a major tribe in Nigeria?",
    "6. What year did Nigeria gain independence?",
    "7. What is the name of the Nigeria's first President?",
      "8. What is the capital of Lagos State?",
      "9. Is River Niger in Nigeria?",
      "10. Which geo-political zone is Lagos State in?",
      "11. What is the capital of Oyo State?"
  };

    string[] answers = {
    "abuja", "36", "green white green", "6", "yes", "1960", "Nnamdi Azikiwe", "ikeja", "yes", "south-west", "ibadan"
  };

    public void gamePlay()
    {
        foreach (string question in questions)
        {
            Console.WriteLine(question);
            answer = Console.ReadLine();
            foreach (string ans in answers)
            {
                if (ans.ToLower() == answer.ToLower())
                {
                    score += 1;
                }
            }
            if (score > (answers.Length / 2))
            {
                while (celebrate == 1)
                {
                    Console.WriteLine("Amazing!");
                    celebrate -= 1;
                }
            }
        }
        Console.WriteLine($"Congrats, you scored {score}");
    }
}