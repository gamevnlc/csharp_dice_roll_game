namespace DiceRollGame;

public class Dice
{
    private readonly Random _random;
    private const int MaxNumber = 7;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll() => _random.Next(1, MaxNumber);
}