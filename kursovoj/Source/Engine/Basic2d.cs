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
    public class Basic2d
    {

        public Vector2 x, y;

        public Texture2D myModel;

        public Basic2d(string PATH, Vector2 X, Vector2 Y)
        {
            x = X;
            y = Y;

            myModel = Globals.content.Load<Texture2D>(PATH);
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {
            if(myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(x.X), (int)(x.Y), (int)(y.X), (int)(y.Y)), null, Color.Green, 0.0f, new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2), new SpriteEffects(), 0);
            }
        }
    }
}
