using Xunit;
using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_EnterStringCountOneWord_1()
    {
      RepeatCounter newCounter = new RepeatCounter("It is snowing on the mountain mount", "mountain");
      Assert.Equal(1, newCounter.CountRepeats());
    }
  }
}
