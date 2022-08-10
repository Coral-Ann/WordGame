using System;
using System.Text;

namespace WordGame;


public class Game
{ 
  string wordToGuess;
  int attemptsLeft;
  public Game(string word)
  {
    wordToGuess = word;
    attemptsLeft = 10;
  }

  public string GetWordToGuess()
  {
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
}
