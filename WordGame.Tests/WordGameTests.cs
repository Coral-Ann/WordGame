using NUnit.Framework;
using WordGame;

namespace WordGame.Tests;

public class GameTests
{
    [Test]
    public void Game_GetWordToGuess_ReturnsWordToGuess()
    {
        Game game = new Game();
        Assert.AreEqual("B_____", game.GetWordToGuess());
    }
}
