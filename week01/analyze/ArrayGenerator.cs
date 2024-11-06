using System;

public static class ArrayGenerator
{
    /// <summary>
    /// Generates a large array of random integers.
    /// </summary>
    /// <param name="size">The size of the array.</param>
    /// <param name="minValue">The minimum value of the random integers.</param>
    /// <param name="maxValue">The maximum value of the random integers.</param>
    /// <returns>The generated array.</returns>
    public static int[] GenerateLargeArray(int size, int minValue = 1, int maxValue = 10000)
    {
        Random random = new();
        int[] largeArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            largeArray[i] = random.Next(minValue, maxValue);
        }
        return largeArray;
    }
}
