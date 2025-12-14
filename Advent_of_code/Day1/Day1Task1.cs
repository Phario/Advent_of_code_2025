namespace Advent_of_code.Day1;

public static class Day1Task1
{
    public static void RunDay1Task1()
    {
        var start = 50;
        var result = 0;
        using StreamReader reader = new(@"C:\Users\Phario\RiderProjects\Advent_of_code\Advent_of_code\Day1Input.txt");
        while (!reader.EndOfStream)
        {
            var lineContents = reader.ReadLine();
            if (lineContents != null)
            {
                var firstChar = lineContents[0];
                var turnAmount = int.Parse(lineContents[1..]);
                turnAmount %= 100;
                start = firstChar switch
                {
                    'L' => RotateLeft(start, turnAmount),
                    'R' => RotateRight(start, turnAmount),
                    _ => start
                };
            }

            if (start == 0)
            {
                result++;
            }
            
        }
        Console.WriteLine($"Result = {result}");
    }

    private static int RotateLeft(int start, int amount)
    {
        if (start - amount < 0)
        {
            return 100 - (amount - start);
        }
        else return start - amount;
    }

    private static int RotateRight(int start, int amount)
    {
        return (amount + start) % 100;
    }
}