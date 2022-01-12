using AdventOfCode.Core;
using System;
using System.Linq;

namespace AdventOfCode
{
  public class ConsoleApp
  {
    public static void Main(string[] args)
    {

      //var count = 0;
      //for (int i = 1; i < depths.Count(); i++)
      //{
      //  if (depths[i] > depths[i - 1])
      //  {

      //    count += 1;
      //  }

      //}

      var day1 = new Day1();
      var count = day1.Run(null);

      Console.WriteLine("Total: {0}", count);
    }
  }
}
