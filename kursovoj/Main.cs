using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    internal class Main : Game
    {
        SpriteBatch spriteBatch;
        GraphicsDeviceManager graphics;
        
        World world;

        Basic2d cursor;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            /// this.IsFixedTimeStep = true;
            /// this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Globals.screenWidth = 800; //1600
            Globals.screenHeight = 500; //900
            Globals.playerSize = new Vector2(100,100);

            graphics.PreferredBackBufferWidth = Globals.screenWidth;
            graphics.PreferredBackBufferHeight = Globals.screenHeight;

            graphics.ApplyChanges();

            




            base.Initialize();
        }

        protected override void LoadContent()
        {
            Globals.content = this.Content;
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);



            cursor = new Basic2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\CursorArrow", new Vector2(0, 0), new Vector2(28,28));



            Globals.keyboard = new MyKeyboard();
            Globals.mouse = new MyMouseControl();



            world = new World();
        
        }

        protected override void UnloadContent()
        {
            base.UnloadContent();
        }




        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Globals.gameTime = gameTime;

            Globals.keyboard.Update();
            Globals.mouse.Update();


            world.Update();

            
            Globals.keyboard.UpdateOld();
            Globals.mouse.UpdateOld();
            




            base.Update(gameTime);
        }





        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.DarkGray);
            
            
            
            Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);


            world.Draw();

            cursor.Draw(new Vector2(Globals.mouse.GetNewMousePos().X, Globals.mouse.GetNewMousePos().Y), new Vector2(0, 0));
            Globals.spriteBatch.End();
            
            
            
            base.Draw(gameTime);
        }
    }
}
