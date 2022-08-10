using NUnit.Framework;
using WordGame;

namespace WordGame.Tests;

public class GameTests
{
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
        Game game = new Game(); // Arange

        string actual = game.GetWordToGuess(); // Act
        string expected = "M_____";

        Assert.AreEqual(actual, expected); // Assert
    }
    
    [Test]
    public void Game_GetRemainingAttempts_ReturnRemainingAttempts()
    {
        Game game = new Game(); // Arange

        int actual = game.GetRemainingAttempts(); // Act
        int expected = 10;

        Assert.AreEqual(actual, expected); // Assert
    }
}
