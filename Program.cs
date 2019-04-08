using System;
using System.Collections.Generic;

namespace words
{
  class Program
  {
    static void Main(string[] args)
    {
      // create a dictionary with key value pairs to represent words (key) and its definition (value)
    //   Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

    //   // add several words and their definition
    //   wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
    //   wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");

    //   // use square bracket lookup to get the definition of a specific word
    //   //   string wordsAndDefinitions = wordsAndDefinitions[words.Key];
    //   // loop over dictionary to get the following output: "The definition of [WORD] is [DEFINITION]"
    //   foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
    //   {
    //     Console.WriteLine($"The definition of {word.Key} is {word.Value}");
    //   }


// Now, we are going to rebuild the structure of our data. Instead of one dictionary with key value pairs
// for words and definitions. We want to track more than just the word and its definition, so we are going to build a
// list of dictionaries.

      // Make a new list
      List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

      // We want to track the following about each word: word, definition, part of speech, example sentence

      /*
          Example of one dictionary in the list:
          {
              "word": "excited",
              "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
              "part of speech": "adjective",
              "example sentence": "I am excited to learn C#!"
          }
       */

      // create dictionary to represent a few word
      Dictionary<string, string> excitedWord = new Dictionary<string, string>();
        excitedWord.Add("word", "excited");
        excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, entusiasm, eagerness");
        excitedWord.Add("part of speech", "adjective");
        excitedWord.Add("example sentence", "I am excited to learn C#!");

      // Add dictionaries to your list
      dictionaryOfWords.Add(excitedWord);
      // create another dictionary and add that to the list
      Dictionary<string, string> hopelessWord = new Dictionary<string, string>();
        hopelessWord.Add("word", "hopeless");
        hopelessWord.Add("definition", "feeling or causing despair about something");
        hopelessWord.Add("part of speech", "adjective");
        hopelessWord.Add("example sentence", "Sometimes learning to code feels hopeless");

      dictionaryOfWords.Add(hopelessWord);
      // loop over your list of dictionaries and output the data

      /*
      Example output for one word in the list of dictionaries:
          word: excited
          definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
          part of speech: adjective
          example sentence: I am excited to learn C#!
       */

      // iterate list
      foreach (Dictionary<string, string> word in dictionaryOfWords)
      {
        // iterate key value pair of dictionary
        foreach (KeyValuePair<string, string> attribute in word)
        {
          Console.WriteLine($"{attribute.Key}: {attribute.Value}");
        }

      }
    }
  }
}
