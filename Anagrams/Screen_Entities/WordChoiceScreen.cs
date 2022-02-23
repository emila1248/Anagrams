using Anagrams.Data;
using Anagrams.Entities;
using Anagrams.Game_Logic;
using Anagrams.Graphics;

namespace Anagrams.Screen_Entities
{
    class WordChoiceScreen
    {
        // Text
        private static readonly Text PromptText = new Text(Anagrams.WindowWidth / 2 + 2, Anagrams.WindowHeight / 2 - 72, Anagrams.Inter_28pt, "What kind of word would you like?");

        // Buttons
        private static readonly Button BackButton = new Button(48, 40, Sprites.BackButton, null, "", ToTitleScreen);
        private static readonly Button Button1 = new Button(Anagrams.WindowWidth / 2 - 100, Anagrams.WindowHeight / 2, Sprites.WordChoiceButton, Anagrams.Inter_22pt, "Random", RandomWord);
        private static readonly Button Button2 = new Button(Anagrams.WindowWidth / 2 + 100, Anagrams.WindowHeight / 2, Sprites.WordChoiceButton, Anagrams.Inter_22pt, "Custom", ToCustomWordScreen);

        // Button functions
        private static void ToTitleScreen()
        {
            Anagrams.CurrentScreen = Screens.Title;
        }

        private static void ToWordChoiceScreen()
        {
            BackButton.ExecuteFunction = ToTitleScreen;

            PromptText.Content = "What kind of word would you like?";
            PromptText.Updated = false;

            Button1.Text = "Random";
            Button1.ExecuteFunction = RandomWord;
            Button1.Updated = false;

            Button2.Text = "Custom";
            Button2.ExecuteFunction = ToCustomWordScreen;
            Button2.Updated = false;
        }

        private static void RandomWord()
        {
            GameData.StartingWord = WordManager.GetRandomStartingWord();

            BackButton.ExecuteFunction = ToWordChoiceScreen;

            PromptText.Content = $"Your random word is: {GameData.StartingWord}";
            PromptText.Updated = false;

            Button1.Text = "New Word";
            Button1.ExecuteFunction = RandomWord;
            Button1.Updated = false;

            Button2.Text = "Continue";
            Button2.Updated = false;
        }

        private static void ToCustomWordScreen()
        {

        }

        // Entity List
        public static Entity[] EntityList = { BackButton, PromptText, Button1, Button2 };
    }
}