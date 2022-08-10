using NUnit.Framework;
using WordGame;
using NSubstitute;

namespace WordGame.Tests
{
  public class WordChoserTests 
  {
    [Test]
    public void WordChoser_GetRandomFromDictionary_ReturnsRandomWord()
    {
      WordChoser word = new WordChoser(); // Arrange

      string actual = word.GetRandomFromDictionary(); // Act

      Assert.Contains(actual, WordChoser.DICTIONARY); // Assert
    }
  }
}
