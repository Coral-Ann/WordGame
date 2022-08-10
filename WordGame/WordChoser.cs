using System;
using System.Text;

namespace WordGame;


public class WordChoser
{
  public static readonly string[] DICTIONARY = new string[] { "MAKERS", "CANDIES", "DEVELOPER", "LONDON" };

  public virtual string GetRandomFromDictionary()
  {
    Random rand = new Random();
    return DICTIONARY[rand.Next(DICTIONARY.Length)];
  }
}