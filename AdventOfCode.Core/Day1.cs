using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Core
{
  public class Day1
  {
    //TODO: trocar o for por foreach

    public int Run(IList<int> depths)
    {
      var count = 0;
      var previous = depths[0];

      foreach (int n in depths)
      {
        if (n > previous)
        {
          previous = n;
          count += 1;
        }

      }
      return count;
    }
  }
}
