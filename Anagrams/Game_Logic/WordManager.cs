using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Anagrams.Game_Logic
{
    class WordManager
    {
        public static string[] GetStartingWords()
        {
            return File.ReadAllLines(@".\Game_Logic\RandomWords.txt");
        }

        public static string GetRandomStartingWord()
        {
            int RandomIndex = new Random().Next(GameData.StartingWords.Length);
            return GameData.StartingWords[RandomIndex];
        }
    }
}