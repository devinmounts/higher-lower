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

  if (response == "yes" || response == "Yes")
  {
  Console.WriteLine("Do you want the computer to guess the number?  When you're ready enter Yes or No.");
  }
  else
  {
  return;
  }
  response = Console.ReadLine();
  if (response == "No")
  {
  Console.WriteLine("Is your number higher or lower than: " + rand_number + " (Enter: Higher/Lower/Correct)");
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
    else if (response == "Correct")
    {
    Console.WriteLine("Success, I did it!");
    break;
    }
    else
    {
    Console.WriteLine("Oops, enter in a valid response...");
    }
    rand_number = randm.Next(Range[0], Range[1]);
    Console.WriteLine("Is your number higher or lower than: " + rand_number + " (Enter: Higher/Lower/Correct)");
    response = Console.ReadLine();
  }
  }
  else if (response == "Yes")
  {
  Console.WriteLine("I have my number, go ahead and start guessing");
  int inputtedValue =  int .Parse(Console.ReadLine());
    while (true)
    {
      if (inputtedValue == rand_number)
      {
      Console.WriteLine("Wow, you guessed my number!!!");
      break;
      }
      else if (inputtedValue < rand_number)
      {
      Console.WriteLine("Guess Again, my number is greater than " + inputtedValue + " .");
      inputtedValue = int .Parse(Console.ReadLine());
      }
      else if (inputtedValue > rand_number)
      {
      Console.WriteLine("Guess Again, my number is lower than " + inputtedValue + " .");
      inputtedValue = int .Parse(Console.ReadLine());
      }
    }
  }
  }
}
