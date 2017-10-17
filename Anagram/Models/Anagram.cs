using System.Collections.Generic;

namespace Anagram.Models
{
  public class Anagram1
  {
    private string _word;

    private static List<string> _instances = new List<string> {};

    // constructor
    public Anagram1 (string word)
    {
      _word = word;
    }
      public string GetWord()
      {
        return _word;
      }

      public List<string> stringOne = new List <string>  {"abets","baste","betas","beast","beats"};
      public List<string> stringTwo = new List <string>  {"acres", "cares", "races", "scare"};
      public List<string> stringThree = new List <string>  {"alert", "alter", "later"};
      public List<string> stringFour = new List <string>  {"angel","angle", "glean"};
      public List<string> stringFive = new List <string>  {"ascot","coats","coast", "tacos"};
      public List<string> stringSix = new List <string> {"aster", "rates", "stare", "taser", "tears"};
      public List<string> stringOne = new List <string>  {"abets","baste","betas","beast","beats"};

      public List<string> GetAll(string input)
      {
        List<string> result = new List<string>{};
        foreach(string element in stringOne)
        {

        }
      }


    }
  }
}
