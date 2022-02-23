using Anagrams.Game_Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anagrams.Data
{
    class GameData
    {
        public static readonly string[] StartingWords = WordManager.GetStartingWords();
        public static string StartingWord = null;
    }
}