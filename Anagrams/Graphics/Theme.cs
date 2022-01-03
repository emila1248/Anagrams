using Microsoft.Xna.Framework;

namespace Anagrams.Graphics
{
    public class Theme
    {
        // Fields
        private static int NumberOfThemes = 0;
        
        // Properties
        public int Number { get; }
        public Color Background { get; }
        public Color Accent { get; }
        public Color Accent_2 { get; }
        
        // Constructor
        public Theme(Color background, Color accent, Color accent_2)
        {
            Number = NumberOfThemes++;
            Background = background;
            Accent = accent;
            Accent_2 = accent_2;
        }

    }
}
