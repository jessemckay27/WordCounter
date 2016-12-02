using System.Collections.Generic;
using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _userSentence;
    private string _userWord;
    private int _wordCount;

    public RepeatCounter(string userSentence, string userWord)
    {
      _userSentence = userSentence;
      _userWord = userWord;
    }

    public int CountRepeats()
    {
      int _wordCount = 0;
      string[] userSentenceSplit = _userSentence.ToUpper().Split(' ');
      for (int i = 0; i < userSentenceSplit.Length; i++)
      {
        if (userSentenceSplit[i] == _userWord.ToUpper())
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }
  }
}
