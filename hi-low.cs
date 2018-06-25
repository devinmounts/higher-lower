using System;
using System.Collections.Generic;

class Guesses
{
  private int _guesses;
  // private int _randomNumber;

  public void SetGuess(int newGuesses)
  {
   _guesses = newGuesses;
  }
  public int GetGuess()
  {
    return _guesses;
  }
}

public class Program
{
  public static void Main()
  {
  Guesses userGuess = new Guesses();
  Console.WriteLine("Would you like to play the guess a number game? Enter Yes or No");
  string response = Console.ReadLine();
  if (response == "yes" || response == "Yes")
  {
    Console.WriteLine("Think of a number between 1 and 100.  When you're ready enter Okay.");
  }
  else
  {
    return;
  }
  response = Console.ReadLine();
  if (response == "Okay")
  {
    Random randm = new Random();
    int rand_number = randm.Next(1,101);
    Console.WriteLine(rand_number);
  }
  else
  {
  Console.WriteLine("fail");
  }
  }

}
