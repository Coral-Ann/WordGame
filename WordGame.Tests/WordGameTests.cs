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
        Game game = new Game(mockWordChoser);

        int actual = game.GetRemainingAttempts(); // Act
        int expected = 10;

        Assert.That(actual, Is.EqualTo(expected)); // Assert
    }

    [Test]
    public void Game_GetRemainingAttempts_ReturnRemainingAttemptsAfterWrongGuess()
    {
        WordChoser mockWordChoser = Substitute.For<WordChoser>(); // Arange
        mockWordChoser.GetRandomFromDictionary().Returns("MAKERS");
        Game game = new Game(mockWordChoser);
        game.GetWordToGuess();
        game.GuessLetter('B');

        int actual = game.GetRemainingAttempts(); // Act
        int expected = 9;

        Assert.That(actual, Is.EqualTo(expected)); // Assert
    }

    [Test]
    public void Game_GuessLetter_ReturnsTrueIfCharInWord()
    {
        WordChoser mockWordChoser = Substitute.For<WordChoser>(); // Arange
        mockWordChoser.GetRandomFromDictionary().Returns("MAKERS");
        Game game = new Game(mockWordChoser);
        game.GetWordToGuess();

        bool actual = game.GuessLetter('A'); // Act
        bool expected = true;

        Assert.That(actual, Is.EqualTo(expected)); // Assert        
    }

    [Test]
    public void Game_GuessLetter_ReturnsFalseIfLetterUsed()
    {
        WordChoser mockWordChoser = Substitute.For<WordChoser>(); // Arange
        mockWordChoser.GetRandomFromDictionary().Returns("MAKERS");
        Game game = new Game(mockWordChoser);
        game.GetWordToGuess();
        game.GuessLetter('A');

        bool actual = game.GuessLetter('A'); // Act
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected)); // Assert        
    }

    [Test]
        public void Game_GuessLetter_ReturnsFalseIfWrongLetter()
    {
        WordChoser mockWordChoser = Substitute.For<WordChoser>(); // Arange
        mockWordChoser.GetRandomFromDictionary().Returns("MAKERS");
        Game game = new Game(mockWordChoser);
        game.GetWordToGuess();

        bool actual = game.GuessLetter('B'); // Act
        bool expected = false;

        Assert.That(actual, Is.EqualTo(expected)); // Assert 
    }
}
