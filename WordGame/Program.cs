using System;
using WordGame;

WordChoser chooser = new WordChoser();
Game game = new Game(chooser);
System.Console.WriteLine("Welcome! Today the word to guess is:");

do 
{
    System.Console.WriteLine(game.GetWordToGuess());
    System.Console.WriteLine("Enter one letter to guess:");

    char guess = System.Console.ReadKey().KeyChar;
    Boolean result = game.GuessLetter(guess);

    if (result == true) {
        System.Console.WriteLine("\nRight!");
    } else {
        System.Console.WriteLine("\nWrong! " + "\nAttempts left: " + game.GetRemainingAttempts());
    }

    if (game.IsGameWon()) 
    {
        System.Console.WriteLine("Yeaaah! You won!");
        return;
    }

    if (game.IsGameLost()) 
    {
        System.Console.WriteLine("Oh no! You lost!");
        return;
    }
} 
while (true);
