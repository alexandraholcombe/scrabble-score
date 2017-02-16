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
      string userInput = GetUserInput();

      return 0;
    }
  }
}
