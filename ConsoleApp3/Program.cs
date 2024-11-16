using ConsoleApp3;

Console.WriteLine("Please choose a number between 1 and 100 in your mind.");
var guesser = new NumberGuesser(1, 100);

while (true)
{
    Console.WriteLine($"your number is  {guesser.Guess} ? (y/n)");
    if (KeyBoard.GetYesOrNo() == 'y')
    {
        Console.WriteLine("I guessed your number!");
        break;
    }

    Console.WriteLine("Is your number bigger? (y/n)");
    guesser.AdjustRange(KeyBoard.GetYesOrNo() == 'y');

    if (!guesser.IsValidRange)
    {
        Console.WriteLine("Incorrect information has been entered!");
        break;
    }
}

Console.WriteLine(" the end!");
