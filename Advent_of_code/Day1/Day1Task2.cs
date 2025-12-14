namespace Advent_of_code.Day1;

public class StartAndResult(int start, int result)
{
    public int Start { get; set; } = start;
    public int Result { get; set; } =  result;
}
public static class Day1Task2
{
    public static void RunDay1Task2()
    {
        var startAndResult = new StartAndResult(50, 0);
        using StreamReader reader = new(@"C:\Users\Phario\RiderProjects\Advent_of_code\Advent_of_code\Day1Input.txt");
        while (!reader.EndOfStream)
        {
            var lineContents = reader.ReadLine();
            if (lineContents == null) continue;
            var firstChar = lineContents[0];
            var turnAmount = int.Parse(lineContents[1..]);
            switch (firstChar)
            {
                case 'L':
                    RotateLeft(turnAmount, startAndResult);
                    break;
                case 'R':
                    RotateRight(turnAmount, startAndResult);
                    break;
            }
        }
        Console.WriteLine($"Result = {startAndResult.Result}");
    }

    private static void RotateLeft(int amount, StartAndResult startAndResult)
    {
        var tempAmount = amount;
        while (tempAmount > 0)
        {
            startAndResult.Start--;
            tempAmount--;
            if (startAndResult.Start < 0)
            {
                startAndResult.Start = 99;
            }

            if (startAndResult.Start == 0) startAndResult.Result++;
        }
    }

    private static void RotateRight(int amount, StartAndResult startAndResult)
    {
        var tempAmount = amount;
        while (tempAmount > 0)
        {
            startAndResult.Start++;
            tempAmount--;
            if (startAndResult.Start > 99)
            {
                startAndResult.Start = 0;
            }
            
            if (startAndResult.Start == 0) startAndResult.Result++;
        }
    }
}