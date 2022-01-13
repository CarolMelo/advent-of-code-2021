using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Core
{
  public static class InputParser
  {
    public static IList<int> Parse(string[] values)
    {
      var depths = new List<int>();

      for (int i=0; i<values.Length; i++)
      {
        var success = Int32.TryParse(values[i], out var depth);

        if (success)
        {
          depths.Add(depth);
        }
      }
      return depths;
    }
  }
}
