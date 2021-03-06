using Xunit;
using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_EnterOneWordCountOneWord_1()
    {
      RepeatCounter newCounter = new RepeatCounter("snowing", "snowing");
      Assert.Equal(1, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterOneWordCountNoWords_0()
    {
      RepeatCounter newCounter = new RepeatCounter("raining", "snowing");
      Assert.Equal(0, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterMultipleWordsCountOneWord_1()
    {
      RepeatCounter newCounter = new RepeatCounter("it is snowing", "snowing");
      Assert.Equal(1, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterMultipleWordsCountNoWords_0()
    {
      RepeatCounter newCounter = new RepeatCounter("it is raining", "snowing");
      Assert.Equal(0, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterStringCountThreeWords_3()
    {
      RepeatCounter newCounter = new RepeatCounter("the storm on the mountain is heavier than the storm last year", "the");
      Assert.Equal(3, newCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_EnterStringCountOneWordIgnoreCase_1()
    {
      RepeatCounter newCounter = new RepeatCounter("it is snowing on the mountain", "SnOWiNg");
      Assert.Equal(1, newCounter.CountRepeats());
    }
  }
}
