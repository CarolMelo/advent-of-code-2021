using AdventOfCode.Core;
using FluentAssertions;
using System;
using Xunit;

namespace AdvantOfCode.Tests
{
  public class Day1Tests
  {
    [Fact]
    public void Run_WithExampleValues_ShouldReturnCorrectResult()
    {
      int[] depths = { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };

      var day1 = new Day1();

      day1.Run(depths).Should().Be(7);
    }
  }
}
