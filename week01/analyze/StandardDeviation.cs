using System.Diagnostics;

/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
public static class StandardDeviation {
    public static void Run() {
        // generate a large array of random integers - increase the size of the array as needed
        var numbers = ArrayGenerator.GenerateLargeArray(10000);

        Stopwatch stopwatch = Stopwatch.StartNew();

        // calculate standard deviation using each method
        Console.WriteLine("Standard Deviation Method 1" + StandardDeviation1(numbers));
        stopwatch.Stop();
        Console.WriteLine("Standard Deviation Method 1 took {0}ms", stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        Console.WriteLine("Standard Deviation Method 2" + StandardDeviation2(numbers)); 
        stopwatch.Stop();
        Console.WriteLine("Standard Deviation Method 2 took {0}ms", stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        Console.WriteLine("Standard Deviation Method 3" + StandardDeviation3(numbers));  
        stopwatch.Stop();
        Console.WriteLine("Standard Deviation Method 3 took {0}ms", stopwatch.ElapsedMilliseconds);
    }

    private static double StandardDeviation1(int[] numbers) {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers) {
            total += number;
            count += 1;
        }

        var avg = total / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }

    private static double StandardDeviation2(int[] numbers) {
        var sumSquaredDifferences = 0.0;
        var countNumbers = 0;
        foreach (var number in numbers) {
            var total = 0;
            var count = 0;
            foreach (var value in numbers) {
                total += value;
                count += 1;
            }

            var avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);
    }

    private static double StandardDeviation3(int[] numbers) {
        var count = numbers.Length;
        var avg = (double)numbers.Sum() / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
}