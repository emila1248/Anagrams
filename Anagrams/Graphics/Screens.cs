using Anagrams.Screen_Entities;

namespace Anagrams.Graphics
{
    public class Screens
    {
        // Screens
        public static Screen Title = new Screen(TitleScreen.EntityList);
        public static Screen Rules = new Screen(RulesScreen.EntityList);
        public static Screen Options = new Screen(OptionsScreen.EntityList);
        public static Screen WordChoice = new Screen(WordChoiceScreen.EntityList);
    }
}