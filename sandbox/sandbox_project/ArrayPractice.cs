/** 
* This file is for practicing the topics learnt
*/

using  System;
using System.Diagnostics;


public class ArrayPractice
{
    // create a fixed array
    public void  FixedArray()
    {
        // creating a fixed array
        int[] numbers =  new int[5];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;

        // print out the  array
        Console.WriteLine($"Fixed Array: " + string.Join(",  ", numbers));
        Console.WriteLine($"{numbers.Length}");

    }

    //  create a dynamic array
    public void DynamicArray()
    {
        // creating a dynamic array
        var numbers = new List<int>
        {
            1,
            2,
            3
        };

        Console.WriteLine($"Dynamic Array: " +  string.Join(", ", numbers));
        Console.WriteLine($"{numbers.Count}");
    }

public void Run()
{
  var executionTime = Time(() => LotsOfLoops(100), 10);
  Console.WriteLine($"Execution Time: {executionTime} ms");
}

private void LotsOfLoops(int n)
{
  int total = 0;
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      for (int k = 0; k < n; k++)
      {
          total += (i*j*k);
      }
    }
  }

  Console.WriteLine(total);
}

private double Time(Action executeAlgorithm, int times)
{
  var sw = Stopwatch.StartNew();
  for (var i = 0; i < times; ++i)
  {
    executeAlgorithm(); // Calls the action passed in to this method
  }

  sw.Stop();
  return sw.Elapsed.TotalMilliseconds / times;
}

public void DoSomething(int n)
{
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine(n * n);
  }

  for (var i = n; i > 0; i--)
  {
    Console.WriteLine(n * n * n);
  }
}

  public void DoSomethingElse(List<string> words)
  {
    for (int i = 0; i < words.Count; i++)
    {
      for (int j = 0; j < words.Count; j++)
        {
          Console.WriteLine(".");
        }
    }
  }


}