using System;
using System.Collections.Generic;

class Guesses
{
  private int _guesses;

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
  int[] Range = {1, 101};
  Random randm = new Random();
  int rand_number = randm.Next(Range[0], Range[1]);
  // List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
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
  Console.WriteLine("Is your number higher or lower than: " + rand_number + " (Enter: Higher/Lower/Correct)");
  }
  response = Console.ReadLine();

  while (true)
  {
    if (response == "Higher")
    {
    Range[0] = rand_number;
    Console.WriteLine(Range[0]);
    }
    else if (response == "Lower")
    {
    Range[1] = rand_number;
    Console.WriteLine(Range[1]);
    }
    else
    {
    Console.WriteLine("Success, I did it!");
    break;
    }
    rand_number = randm.Next(Range[0], Range[1]);
    Console.WriteLine("Is your number higher or lower than: " + rand_number + " (Enter: Higher/Lower/Correct)");
    response = Console.ReadLine();
  }

  }
}
