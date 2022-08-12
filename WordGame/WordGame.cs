using System;
using System.Text;
using System.Collections.Generic;

namespace WordGame;

public class Game
{ 
  public int attemptsLeft;
  string wordToGuess;
  List<Char> guessedLetters;

  public Game(WordChoser word)
  {
    wordToGuess = word.GetRandomFromDictionary();
    attemptsLeft = 10;
    guessedLetters = new List<Char>();
  }

  public string GetWordToGuess()
  {
    StringBuilder hint = new StringBuilder();
    for(int i = 0; i < wordToGuess.Length; i++)
    {
      if ( i == 0 || guessedLetters.Contains(wordToGuess[i]))
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

  public bool GuessLetter(char letter)
  {
    if (wordToGuess.Contains(letter) && !guessedLetters.Contains(letter))
    {
      guessedLetters.Add(letter);
      return true;
    } else if (wordToGuess.Contains(letter) && guessedLetters.Contains(letter)) {
      return false;
    } else {
      attemptsLeft--;
      return false;
    }
  }

  public bool IsGameLost()
  {
    if (attemptsLeft == 0)
    {
      return true;
    } else {
      return false;
    }
  }
}
