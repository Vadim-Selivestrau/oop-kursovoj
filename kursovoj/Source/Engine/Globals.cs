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

    public delegate void PassObject(object i);
    public delegate object PassObjectAndReturn(object i);




    class Globals
    {

        public static int screenHeight, screenWidth;
        public static Vector2 playerSize;

        public static Song song;

        public static Random rand = new Random();

        public static ContentManager content;
        public static SpriteBatch spriteBatch;

        public static Effect baseEffect;

        public static MyKeyboard keyboard;
        public static MyMouseControl mouse;

        public static GameTime gameTime;

        public static float GetDistance(Vector2 pos, Vector2 target)
        {
            return (float)Math.Sqrt(Math.Pow(pos.X - target.X, 2) + Math.Pow(pos.Y - target.Y, 2));
        }


        
    }
}
