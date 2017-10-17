using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram.Tests;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTests
  {
    [TestMethod]
    public void GetValue1_EqualToInput2_True()
    {
      // Arrange
      Anagram1 newWord = new Anagram1("tea");

      var output = new List<string>{"eat", "ate", "tae"};

      // Act
      List<string> result = newWord.GetValue(newWord.GetWord());

      // Assert
      CollectionAssert.AreEqual(expected, result);
    }
  }
}
