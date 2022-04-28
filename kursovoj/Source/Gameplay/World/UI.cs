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

        public SpriteFont font;

        public QuantityDisplayBar healthBar;
        public UI()
        {
            font = Globals.content.Load<SpriteFont>(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\MyFont");

            healthBar = new QuantityDisplayBar(new Vector2(100, 16), 2 , Color.Red);
        }


        public void Update(World WORLD)
        {
            healthBar.Update(WORLD.GetPLAYER().health, WORLD.GetPLAYER().healthMax);
        }

        public void Draw(World WORLD)
        {
            string tempStr = "num kills = " + WORLD.numKilled;
            Vector2 strDims = font.MeasureString(tempStr);
            Globals.spriteBatch.DrawString(font, tempStr, new Vector2(Globals.screenWidth/2-strDims.X/2, 20) ,Color.Black);

            healthBar.Draw(new Vector2(20, Globals.screenHeight - 40));
        }

    }
}
