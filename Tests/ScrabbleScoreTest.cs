using Xunit;
using System;
using System.Collections.Generic;

namespace ScrabbleScoreApp
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void ScrabbleScoreGenerator_ForUserInputNumber_0()
    {
      string userInput = "42";
      ScrabbleScore testScrabbleScore = new ScrabbleScore(userInput);
      int result = testScrabbleScore.ScrabbleScoreGenerator();
      int expectedResult = 0;
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ScrabbleScoreGenerator_ForUserInputA_1()
    {
      string userInput = "a";
      ScrabbleScore testScrabbleScore = new ScrabbleScore(userInput);
      int result = testScrabbleScore.ScrabbleScoreGenerator();
      int expectedResult = 1;
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void ScrabbleScoreGenerator_ForUserInputDo_3()
    {
      string userInput = "do";
      ScrabbleScore testScrabbleScore = new ScrabbleScore(userInput);
      int result = testScrabbleScore.ScrabbleScoreGenerator();
      int expectedResult = 3;
      Assert.Equal(expectedResult, result);
    }
  }
}
