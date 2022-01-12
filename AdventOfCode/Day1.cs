using System;
using System.Linq;

namespace AdventOfCode
{
  public class Day1
  {
    public static void Main(string[] args)
    {
      //Valores em um array
      int[] depths = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };

      //Contar quantas vezes o número anterior é menor que o próximo
      var count = 0;
      for (int i = 1; i < depths.Count(); i++)
      {
        if (depths[i] > depths[i - 1])
        {

          count += 1;
        }

      }

      Console.WriteLine("Total: {0}", count);
    }
  }
}
