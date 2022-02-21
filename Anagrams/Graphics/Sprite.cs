using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Anagrams.Graphics
{
    public class Sprite
    {
        public int X { get; }
        public int Y { get; }
        public int[] Position { get; }
        public int Width { get; }
        public int Height { get; }
        public int[] Size { get; }

        public Sprite(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Position = new int[] { x, y };
            Width = width;
            Height = height;
            Size = new int[] { width, height };
        }

        public void Draw(SpriteBatch spriteBatch, float xPos, float yPos)
        {
            spriteBatch.Draw(Anagrams.Spritesheet, new Vector2(xPos, yPos), new Rectangle(X, Y, Width, Height), Color.White);
        }
    }
}