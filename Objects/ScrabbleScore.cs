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
      char[] userInputArray = userInput.ToCharArray();
      int wordValue = 0;

      char[] onePoint = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      char[] twoPoint = {'d', 'g'};

      for (int i = 0; i < userInputArray.Length; i++)
      {
        for (int j = 0; j < onePoint.Length; j++)
        {
          if (userInputArray[i].Equals(onePoint[j]))
          {
            wordValue += 1;
          }
        }
        for (int j = 0; j < twoPoint.Length; j++)
        {
          if (userInputArray[i].Equals(twoPoint[j]))
          {
            wordValue += 2;
          }
        }
      }
      return wordValue;
    }
  }
}
