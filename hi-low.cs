using System;
using SystemsCollections.Generic;

class UserInput {
  private int _guesses;

  public void SetGuess(int newGuesses)
  {
   _guesses = int.Parse(newGuesses);
  }
  public int GetGuess()
  {
    return _guesses;
  }
}

public class program
{
  public static void Main()
  {
  Guesses userGuess = new Guesses();
  Console.WriteLine()
  }
}
