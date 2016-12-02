using Xunit;

namespace WordCounterTest
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_EnterStringCountOneWord_1()
    {
      Counter findWord = new Counter("It is snowing on the mountain", "mountain")
      Assert.Equal(1, findWord.CountRepeats());
    }
  }
}
