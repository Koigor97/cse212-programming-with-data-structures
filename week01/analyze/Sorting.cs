using System.Diagnostics;

public static class Sorting {
    public static void Run() {
        // generate a large array of random integers
        var numbers = ArrayGenerator.GenerateLargeArray(10000);
        
        Stopwatch stopwatch = Stopwatch.StartNew();

        SortArray(numbers);
        // Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}

        stopwatch.Stop();
        /** 
        * Print the first 10 elements to verify sorting without overwhelming the output
        * Then test the performance of the sorting algorithm
        */
     
        Console.WriteLine("First 10 elements of sorted array: {0}", string.Join(", ", numbers[..10]));
        Console.WriteLine("Sorting took {0}ms", stopwatch.ElapsedMilliseconds);
    }

    private static void SortArray(int[] data) {
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) {
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) {
                if (data[swapPos] > data[swapPos + 1]) {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}