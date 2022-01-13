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

      //IList<int> listDepths = depths.ConvertAll(depths, s => Int32.Parse(s));
      //IList<int> listDepths = (IList.ConvertAll(depths, s => Int32.Parse(s)));

      var count = 0;
      for (int i = 1; i < depths.Count(); i++)
      {
        if (depths[i] > depths[i - 1])
        {

          count += 1;
        }

      }
      return count;
    }
  }
}
