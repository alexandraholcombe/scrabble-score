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
      char[] threePoint = {'b', 'c', 'm', 'p'};
      char[] fourPoint = {'f', 'h', 'v', 'w', 'y'};

      for (int i = 0; i < userInputArray.Length; i++)
      {
        //For 1 point
        for (int j = 0; j < onePoint.Length; j++)
        {
          if (userInputArray[i].Equals(onePoint[j]))
          {
            wordValue += 1;
          }
        }
        //For 2 points
        for (int j = 0; j < twoPoint.Length; j++)
        {
          if (userInputArray[i].Equals(twoPoint[j]))
          {
            wordValue += 2;
          }
        }
        //For 3 points
        for (int j = 0; j < threePoint.Length; j++)
        {
          if (userInputArray[i].Equals(threePoint[j]))
          {
            wordValue += 3;
          }
        }
        //For 4 points
        for (int j = 0; j < fourPoint.Length; j++)
        {
          if (userInputArray[i].Equals(fourPoint[j]))
          {
            wordValue += 4;
          }
        }
      }
      return wordValue;
    }
  }
}
