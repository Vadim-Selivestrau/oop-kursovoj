using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    internal class Main : Game
    {

        private GraphicsDeviceManager graphics;
        World world;


        public Main()
            : base()
        {
            this.graphics = new GraphicsDeviceManager(this);
            this.Content.RootDirectory = "Content";
            this.IsFixedTimeStep = true;
            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.content = this.Content;
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);
            
            world = new World();
        
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            world.Update();
        }

        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.OrangeRed);
            Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);


            world.Draw();


            Globals.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
