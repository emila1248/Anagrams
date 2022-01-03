using Anagrams.Graphics;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Anagrams.Entities
{
    public abstract class Entity
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Scale { get; set; }

        public abstract void Update(MouseState mouseState);
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
