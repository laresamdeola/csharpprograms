using System;

class Age {
  public void YourAge(){
    Console.WriteLine("How old are you?");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You are " + Convert.ToString(age));
  }
}