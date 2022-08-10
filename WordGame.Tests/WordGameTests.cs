using NUnit.Framework;
using WordGame;

namespace WordGame.Tests;

public class GameTests
{
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
        Game game = new Game("MAKERS"); // Arange

        string actual = game.GetWordToGuess(); // Act
        string expected = "M_____";

        Assert.AreEqual(actual, expected); // Assert
    }
}
