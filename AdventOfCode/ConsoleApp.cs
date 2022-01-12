using AdventOfCode.Core;
using System;
using System.IO;

namespace AdventOfCode
{
  public class ConsoleApp
  {
    public static void Main(string[] args)
    {
      //TODO: salvar os valores em um arquivo de texto
      //TODO: carregar valores de um arquivo de texto
      string[] depths = File.ReadAllLines(@"C:\Adventoofcode\advent-of-code-2021\puzzleInput.txt");
      
      var day1 = new Day1();
      var count = day1.Run(null);

      Console.WriteLine("Total: {0}", count);
    }
  }
}
