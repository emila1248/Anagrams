namespace Anagrams.Graphics
{
    public class Sprites
    {
        // Offests
        private const int THEME_OFFSET = 288;

        // Button Sprites
        public static Sprite[] TitleButton =
        {
            new Sprite(Anagrams.CurrentTheme.Number * THEME_OFFSET, 0, 192, 60),
            new Sprite(Anagrams.CurrentTheme.Number * THEME_OFFSET, 60, 192, 60)
        };

        public static Sprite[] BackButton =
        {
            new Sprite(Anagrams.CurrentTheme.Number * THEME_OFFSET + 192, 0, 50, 36),
            new Sprite(Anagrams.CurrentTheme.Number * THEME_OFFSET + 192, 36, 50, 36)
        };

        public static Sprite[] WordChoiceButton =
        {
            new Sprite(Anagrams.CurrentTheme.Number * THEME_OFFSET, 120, 168, 56),
            new Sprite(Anagrams.CurrentTheme.Number * THEME_OFFSET, 176, 168, 56)
        };
    }
}
