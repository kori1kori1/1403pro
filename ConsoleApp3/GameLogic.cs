

namespace ConsoleApp3;

static class KeyBoard
{
    public static char GetYesOrNo()
    {
        char key;
        do
        {
            key = Console.ReadKey(true).KeyChar;
        } while (key != 'y' && key != 'n');
        Console.WriteLine(key);
        return key;
    }
}

class NumberGuesser
{
    private int min, max;

    public NumberGuesser(int start, int end)
    {
        min = start;
        max = end;
    }

    public int Guess => (min + max) / 2;

    public void AdjustRange(bool isHigher)
    {
        if (isHigher) min = Guess + 1;
        else max = Guess - 1;
    }

    public bool IsValidRange => min <= max;
}

