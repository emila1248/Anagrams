using Anagrams.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Anagrams
{
    public class Anagrams : Game
    {
        // Setup
        private static GraphicsDeviceManager GraphicsManager;
        private static SpriteBatch SpriteBatch;
        
        // Spritesheet
        public static Texture2D Spritesheet;
        
        // Fonts
        public static SpriteFont Inter_76pt;
        public static SpriteFont Inter_28pt;
        public static SpriteFont Inter_24pt;
        public static SpriteFont Inter_22pt;

        // Variables
        public static int WindowWidth = 960;
        public static int WindowHeight = 704;
        public static Theme CurrentTheme = Themes.Natural;
        public static Screen CurrentScreen;

        // Anagrams
        public Anagrams()
        {
            GraphicsManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        // Initialize
        protected override void Initialize()
        {
            // Set window size
            GraphicsManager.PreferredBackBufferWidth = WindowWidth;
            GraphicsManager.PreferredBackBufferHeight = WindowHeight;
            GraphicsManager.ApplyChanges();

            base.Initialize();
        }

        // Load Content
        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            Spritesheet = Content.Load<Texture2D>("Spritesheet");
            Inter_76pt = Content.Load<SpriteFont>("Inter_76pt");
            Inter_28pt = Content.Load<SpriteFont>("Inter_28pt");
            Inter_24pt = Content.Load<SpriteFont>("Inter_24pt");
            Inter_22pt = Content.Load<SpriteFont>("Inter_22pt");
        }
        
        // Update
        protected override void Update(GameTime gameTime)
        {
            // Get mouse state
            MouseState MouseState = Mouse.GetState();
            
            // Update current screen
            if (CurrentScreen == null)
            {
                CurrentScreen = Screens.Title;
            }
            CurrentScreen.Update(MouseState);
            
            base.Update(gameTime);
        }

        // Draw
        protected override void Draw(GameTime gameTime)
        {
            // Draw background
            GraphicsDevice.Clear(CurrentTheme.Background);
            
            // Begin sprite batch
            SpriteBatch.Begin();
            
            CurrentScreen.Draw(SpriteBatch);
            
            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
