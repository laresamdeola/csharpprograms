using System;
using System.Linq;

class Quiz {
  public int score;
  public bool gameState = true;
  public int count;
  public string answer;
  
  string[] questions = {
    "1. What is the capital of Nigeria? ",
    "2. How many states are in Nigeria?",
    "3. What are the colors of the Nigerian Flag?"
  };

  string[] answers = {
    "abuja", "36", "green white green"
  };

  public void gamePlay() {
    foreach(string question in questions){
      Console.WriteLine(question);
      answer = Console.ReadLine();
      foreach(string ans in answers) {
        if(ans.ToLower() == answer) {
          score += 1;
        }
      }
    }
    Console.WriteLine($"Congratulations, you scored {score}");
  }
}