using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Core
{
  public class Day1
  {
    //TODO: TROCAR POR UM ILIST<int> 
    //TODO: organizar código

    public int Run(int[] depths)
    {

      IList<int> listDepths = (IList.ConvertAll(depths, s => Int32.Parse(s)));

      var count = 0;
      for (int i = 1; i < listDepths.Count(); i++)
      {
        if (listDepths[i] > listDepths[i - 1])
        {

          count += 1;
        }

      }
      return count;
    }
  }
}
