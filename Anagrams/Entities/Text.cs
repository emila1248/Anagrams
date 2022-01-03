using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Anagrams.Entities
{
    class Text : Entity
    {
        // Properties
        public SpriteFont Font { get; set; }
        public string Content { get; set; }
        public bool Updated { get; set; }

        private float TextWidth { get; set; }
        private float TextHeight { get; set; }

        // Constructor
        public Text(float x, float y, SpriteFont font, string content)
        {
            X = x;
            Y = y;
            Font = font;
            Content = content;
            Updated = true;

            TextWidth = font.MeasureString(content).X;
            TextHeight = font.MeasureString(content).Y;
        }

        // Update
        public override void Update(MouseState mouseState)
        {

        }

        // Draw
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (!Updated)
            {
                TextWidth = Font.MeasureString(Content).X;
                TextHeight = Font.MeasureString(Content).Y;
                Updated = true;
            }

            spriteBatch.DrawString(Font, Content, new Vector2(X - TextWidth / 2, Y - TextHeight / 2), Anagrams.CurrentTheme.Accent);
        }
    }
}
