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
      char[] fivePoint = {'k'};
      char[] eightPoint = {'j', 'x'};
      char[] tenPoint = {'q', 'z'};
      char[][] pointArrays = {onePoint, twoPoint, threePoint, fourPoint, fivePoint, eightPoint, tenPoint};


      for (int i = 0; i < userInputArray.Length; i++)
      {

        for (int k = 0; k < pointArrays.Length; k++)
        {
          for (int j = 0; j < pointArrays[k].Length; j++)
          {
            bool iteration = userInputArray[i].Equals(pointArrays[k][j]);
            //For 1 point
            if (k == 0 && iteration)
            {
              wordValue += 1;
            }
            else if (k == 1 && iteration)
            {
              wordValue += 2;
            }
            //For 3 point
            else if (k == 2 && iteration)
            {
              wordValue += 3;
            }
            //For 4 point
            else if (k == 3 && iteration)
            {
              wordValue += 4;
            }
            //For 5 point
            else if (k == 4 && iteration)
            {
              wordValue +=5;
            }
            //For 8 point
            else if (k == 5 && iteration)
            {
              wordValue +=8;
            }
            //For 10 point
            else if (k == 6 && iteration)
            {
              wordValue +=10;
            }
          }
        }
      }
      return wordValue;
    }
  }
}
