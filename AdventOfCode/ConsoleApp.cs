using AdventOfCode.Core;
using System;
using System.IO;

namespace AdventOfCode
{
  public class ConsoleApp
  {
    public static void Main(string[] args)
    {

      var input = File.ReadAllLines(@"C:\Adventoofcode\advent-of-code-2021\puzzleInput.txt");
      var depths = InputParser.Parse(input);
      
      var day1 = new Day1();
      var count = day1.Run(depths);

      Console.WriteLine("Total: {0}", count);
    }
  }
}
