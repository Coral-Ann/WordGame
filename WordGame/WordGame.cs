using System;
using System.Text;

namespace WordGame;


public class Game
{ 
  int attemptsLeft;
  private readonly string[] _dictionary;

  public Game()
  {
    attemptsLeft = 10;
    string[] _dictionary = { "MAKERS", "CANDIES", "DEVELOPER", "LONDON" };
  }

  public string GetWordToGuess()
  {
    string wordToGuess = GetRandomFromDictionary();
    StringBuilder hint = new StringBuilder();
    for(int i = 0; i < wordToGuess.Length; i++)
    {
      if ( i == 0)
      {
        hint.Append(wordToGuess[i]);
      } else {
        hint.Append("_");
      }
    }
    return hint.ToString();
  }

  public int GetRemainingAttempts()
  {
    return attemptsLeft;
  }

  public string GetRandomFromDictionary()
  {
    Random rand = new Random();
    return _dictionary[rand.Next(_dictionary.Length)];
  }
}
