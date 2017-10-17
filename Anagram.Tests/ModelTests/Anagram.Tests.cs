using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram.Models;

namespace Anagram.Tests;
{
  [TestClass]
  public class AnagramTests
  {
    [TestMethod]
    public void GetValue1()
    {
      // Arrange
      Anagram1 newWord = new Anagram1("tea");

      var output = new List<string>{"eat", "ate", "tae"};

      // Act
      List<string> result = newWord.GetValue(newWord.GetWord());

      // Assert
      CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GetValue2()
    {
      Anagram1 newWord = new Anagram1("lapse");

      var output = new List<string>{"leaps", "pales", "peals", "pleas", "sepal"}; 
    }
  }
}
