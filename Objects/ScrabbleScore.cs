using System;
using System.Collections.Generic;

namespace ScrabbleScoreApp
{
  public class ScrabbleScore
  {
    private string _userInput;

    public ScrabbleScore(string userInput)
    {
      _userInput = userInput;
    }

    public string GetUserInput()
    {
      return _userInput;
    }

    public int ScrabbleScoreGenerator()
    {
      string userInput = GetUserInput().ToLower();
      int wordValue = 0;

      string[] onePoint = {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
      for (int i = 0; i < onePoint.Length; i++)
      {
        if (userInput == onePoint[i])
        {
          wordValue += 1;
        }
        else
        {
          wordValue += 0;
        }
      }
      return wordValue;
    }
  }
}
