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
      RepeatCounter newCounter = new RepeatCounter("it is snowing", "snowing");
      Assert.Equal(1, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterStringCountThreeWords_3()
    {
      RepeatCounter newCounter = new RepeatCounter("the storm on the mountain is heavier than the storm last year", "the");
      Assert.Equal(3, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterStringCountOneWordIgnoreCase_3()
    {
      RepeatCounter newCounter = new RepeatCounter("it is Snowing on the mountain", "SnOWiNg");
      Assert.Equal(1, newCounter.CountRepeats());
    }
  }
}
