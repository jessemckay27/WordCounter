using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _userWord;
    private int _wordCount;

    public Counter(string userSentence, string userWord)
    {
      _userSentence = userSentence;
      _userWord = userWord;
      _wordCount = 0;
    }

    public string CountRepeats()
    {
      string[] userSentenceSplit = _userSentence.Split(' ');
      for (int i = 0; i < userSentenceSplit.Length; i++)
      {
        if (userSentenceSplit[i] == _userWord)
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }
  }
}
