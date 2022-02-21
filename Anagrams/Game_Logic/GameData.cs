using System;
using System.Collections.Generic;
using System.Text;

namespace Anagrams.Game_Logic
{
    class GameData
    {
        public static readonly string[] StartingWords = WordManager.GetStartingWords();
        public static string StartingWord = null;
    }
}