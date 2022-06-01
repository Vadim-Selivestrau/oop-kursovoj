using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    internal class Main : Game
    {
        SpriteBatch spriteBatch;
        GraphicsDeviceManager graphics;
        
        GamePlay gamePlay;

        Basic2d cursor;

        Color color = Color.White;
        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            /// this.IsFixedTimeStep = true;
            /// this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            Globals.screenWidth = 1600; //1600
            Globals.screenHeight = 900; //900
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



            gamePlay = new GamePlay();

            
            
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


            gamePlay.Update();

            
            Globals.keyboard.UpdateOld();
            Globals.mouse.UpdateOld();
            




            base.Update(gameTime);
        }





        protected override void Draw(GameTime gameTime)
        {
            this.GraphicsDevice.Clear(Color.DarkGray);
            
            
            
            Globals.spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);


            gamePlay.Draw();

            cursor.Draw(new Vector2(Globals.mouse.GetNewMousePos().X, Globals.mouse.GetNewMousePos().Y), new Vector2(0, 0), color);
            Globals.spriteBatch.End();
            
            
            
            base.Draw(gameTime);
        }
    }
}
