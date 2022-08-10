using System;
using System.Text;

namespace WordGame;


public class Game
{ 
  string wordToGuess;
  public Game(string word)
  {
    wordToGuess = word;
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
}
