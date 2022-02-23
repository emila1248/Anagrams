using Anagrams.Data;
using System;
using System.IO;

namespace Anagrams.Game_Logic
{
    public class WordManager
    {
        public static string[] GetStartingWords()
        {
            return File.ReadAllLines(@".\Data\RandomWords.txt");
        }

        public static string GetRandomStartingWord()
        {
            int RandomIndex = new Random().Next(GameData.StartingWords.Length);
            return GameData.StartingWords[RandomIndex];
        }
    }
}