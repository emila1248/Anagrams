using Anagrams.Entities;
using Anagrams.Graphics;

namespace Anagrams.Screen_Entities
{
    public class RulesScreen
    {
        // Buttons
        private static readonly Button BackButton = new Button(48, 40, Sprites.BackButton, null, "", ToTitleScreen);

        // Button functions
        private static void ToTitleScreen()
        {
            Anagrams.CurrentScreen = Screens.Title;
        }

        // Entity List
        public static Entity[] EntityList = { BackButton };
    }
}
