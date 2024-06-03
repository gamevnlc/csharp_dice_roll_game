namespace DiceRollGame;

public class GameHandler
{
    private readonly Dice _dice;
    private const int MaxTry = 3;

    public GameHandler(Dice dice)
    {
        _dice = dice;
    }

    public GameResults Run()
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {MaxTry} tries.");
        var diceNumber = _dice.Roll();
        var tryCount = 0;
        while (tryCount < MaxTry)
        {
            Console.WriteLine("Enter the number:");
            var guessInput = Console.ReadLine();
            if (Int32.TryParse(guessInput, out var inputNumber))
            {
                if (inputNumber == diceNumber)
                {
                    return GameResults.Win;
                }

                Console.WriteLine("Wrong number.");
                tryCount += 1;
            }
        }

        return GameResults.Lose;
    }

    public static void PrintResult(GameResults gameResult)
    {
        Console.WriteLine(gameResult == GameResults.Lose ? "You lose." : "You win");
    }
}