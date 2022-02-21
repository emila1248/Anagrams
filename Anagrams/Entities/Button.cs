using Anagrams.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Anagrams.Entities
{
    public class Button : Entity
    {
        // Delegate
        public delegate void Function();

        // Properties
        public SpriteFont Font { get; set; }
        public string Text { get; set; }
        public Sprite[] Sprites { get; private set; }
        public bool MouseIsOver { get; private set; }
        public bool Clicked { get; private set; }
        public bool Updated { get; set; }
        public Function ExecuteFunction { get; set; }

        private float TextWidth { get; set; }
        private float TextHeight { get; set; }

        // Constructor
        public Button(float x, float y, Sprite[] sprites, SpriteFont font, string text, Function executeFunction)
        {
            X = x;
            Y = y;
            Scale = 1;
            Sprites = sprites;
            Font = font;
            Text = text;
            MouseIsOver = false;
            Clicked = false;
            Updated = true;
            ExecuteFunction = executeFunction;

            if (font != null)
            {
                TextWidth = font.MeasureString(text).X;
                TextHeight = font.MeasureString(text).Y;
            }
        }

        // Update
        public override void Update(MouseState mouseState)
        {
            double MouseX = mouseState.X;
            double MouseY = mouseState.Y;

            if (MouseX > X - Sprites[0].Width / 2 && MouseX < X + Sprites[0].Width / 2 && MouseY > Y - Sprites[0].Height / 2 && MouseY < Y + Sprites[0].Height / 2)
                MouseIsOver = true;
            else
                MouseIsOver = false;

            if (MouseIsOver && mouseState.LeftButton == ButtonState.Pressed)
            {
                if (!Clicked)
                {
                    Clicked = true;
                    ExecuteFunction();
                }
            }
            else
            {
                Clicked = false;
            }
        }

        // Draw
        public override void Draw(SpriteBatch spriteBatch)
        {
            Sprite sprite;

            if (!Updated)
            {
                TextWidth = Font.MeasureString(Text).X;
                TextHeight = Font.MeasureString(Text).Y;
                Updated = true;
            }

            if (MouseIsOver)
                sprite = Sprites[1];
            else
                sprite = Sprites[0];

            sprite.Draw(spriteBatch, X - sprite.Width / 2, Y - sprite.Height / 2);
            if (Font != null)
                spriteBatch.DrawString(Font, Text, new Vector2(X - TextWidth / 2, Y - TextHeight / 2), Anagrams.CurrentTheme.Background);
        }
    }
}