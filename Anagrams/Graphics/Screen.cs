using Anagrams.Entities;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Anagrams.Graphics
{
    public class Screen
    {
        // Properties
        public Entity[] Entities;

        // Constructor
        public Screen(Entity[] entities)
        {
            Entities = entities;
        }

        // Update
        public void Update(MouseState mouseState)
        {
            foreach (Entity entity in Entities)
            {
                entity.Update(mouseState);
            }
        }

        // Draw
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Entity entity in Entities)
            {
                entity.Draw(spriteBatch);
            }
        }
    }
}