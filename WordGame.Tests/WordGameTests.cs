using NUnit.Framework;
using WordGame;
using NSubstitute;

namespace WordGame.Tests;

public class GameTests
{
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
        WordChoser mockWordChoser = Substitute.For<WordChoser>(); // Arange
        mockWordChoser.GetRandomFromDictionary().Returns("MAKERS");
        Game game = new Game(mockWordChoser);

        string actual = game.GetWordToGuess(); // Act
        string expected = "M_____";

        Assert.That(actual, Is.EqualTo(expected)); // Assert
    }

    [Test]
    public void Game_GetRemainingAttempts_ReturnRemainingAttempts()
    {
        WordChoser mockWordChoser = Substitute.For<WordChoser>(); // Arange
        mockWordChoser.GetRandomFromDictionary().Returns("MAKERS");
        Game game = new Game(mockWordChoser);

        int actual = game.GetRemainingAttempts(); // Act
        int expected = 10;

        Assert.That(actual, Is.EqualTo(expected)); // Assert
    }
}
