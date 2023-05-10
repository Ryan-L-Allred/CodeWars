
static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
{
    int sum = ClassPoints.Sum();
    int arrayLength = ClassPoints.Length;
    return sum / arrayLength < YourPoints ? true : false;
    
}

int[] array = new int[] {50, 50, 45, 60, 70};

Console.WriteLine(BetterThanAverage(array, 85)); //expected output: True
Console.WriteLine(BetterThanAverage(array, 30)); //expected output: False
