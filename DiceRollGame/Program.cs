// See https://aka.ms/new-console-template for more information

using DiceRollGame;

Dice dice = new Dice(new Random());
GameHandler gameHandler = new GameHandler(dice);
GameResults gameResult = gameHandler.Run();
GameHandler.PrintResult(gameResult);
Console.ReadKey();