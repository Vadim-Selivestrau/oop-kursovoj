#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
#endregion

namespace MyGame
{
    class UI
    {
        public Basic2d pauseOverlay;

        public SpriteFont font;

        public QuantityDisplayBar healthBar;

        public UI()
        {
            pauseOverlay = new Basic2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\bulllet", new Vector2(Globals.screenWidth/2, Globals.screenHeight/2), new Vector2(300,300));

            font = Globals.content.Load<SpriteFont>(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\MyFont");

            healthBar = new QuantityDisplayBar(new Vector2(100, 25), 2 , Color.White);
        }


        public void Update(World WORLD)
        {
            healthBar.Update(WORLD.user.playerSpaceShip.health, WORLD.user.playerSpaceShip.healthMax);
        }

        public void Draw(World WORLD)
        {
            string tempStr = "score = " + GameGlobals.score;
            Vector2 strDims = font.MeasureString(tempStr);
            Globals.spriteBatch.DrawString(font, tempStr, new Vector2(Globals.screenWidth/2-strDims.X/2, 20) ,Color.Black);

            healthBar.Draw(new Vector2(20, Globals.screenHeight - 40));



            

            if (WORLD.user.playerSpaceShip.dead)
            {
                

                tempStr = "YOU DIED";
                strDims = font.MeasureString(tempStr);
                Globals.spriteBatch.DrawString(font, tempStr, new Vector2(Globals.screenWidth / 2 - strDims.X / 2, Globals.screenHeight/2), Color.Red);

            }

            if (GameGlobals.paused)
            {
                pauseOverlay.Draw();
            }
        }

    }
}
