using Anagrams.Entities;
using Anagrams.Graphics;
using System.Threading;

namespace Anagrams.Screen_Entities
{
    public class TitleScreen
    {
        // Title
        private static readonly Text TitleText = new Text(Anagrams.WindowWidth / 2, Anagrams.WindowHeight / 2 - 158, Anagrams.Inter_76pt, "Anagrams");

        // Buttons
        private static readonly Button PlayButton = new Button(Anagrams.WindowWidth / 2, Anagrams.WindowHeight / 2 - 16, Sprites.TitleButton, Anagrams.Inter_24pt, "Play", ToWordChoiceScreen);
        private static readonly Button RulesButton = new Button(Anagrams.WindowWidth / 2, Anagrams.WindowHeight / 2 + 64, Sprites.TitleButton, Anagrams.Inter_24pt, "Rules", ToRulesScreen);
        private static readonly Button OptionsButton = new Button(Anagrams.WindowWidth / 2, Anagrams.WindowHeight / 2 + 144, Sprites.TitleButton, Anagrams.Inter_24pt, "Options", ToOptionsScreen);

        // Button functions
        private static void ToWordChoiceScreen()
        {
            Anagrams.CurrentScreen = Screens.WordChoice;
        }

        private static void ToRulesScreen()
        {
            Anagrams.CurrentScreen = Screens.Rules;
        }

        private static void ToOptionsScreen()
        {
            Anagrams.CurrentScreen = Screens.Options;
        }

        // Entity List
        public static Entity[] EntityList = { TitleText, PlayButton, RulesButton, OptionsButton };
    }
}