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
    class Basic2d
    {

        public Vector2 pos, dims;

        public Texture2D myModel;

        public Basic2d(string PATH, Vector2 POS, Vector2 DIMS)
        {
            pos = POS;
            dims = DIMS;

            myModel = Globals.content.Load<Texture2D>(PATH);
        }

        public virtual void Update(Vector2 OFFSET)
        {

        }
        public virtual void Update(Vector2 OFFSET, PlayerSpaceShip PLAYER)
        {

        }



        public virtual void Draw()
        {
            if(myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X), (int)(pos.Y), (int)(dims.X), (int)(dims.Y)), null, Color.White, 0.0f, new Vector2(myModel.Bounds.Width / 2, myModel.Bounds.Height / 2), new SpriteEffects(), 0);
            }
        }

        public virtual void Draw(Vector2 OFFSET, Vector2 ORIGIN, Color COLOR)
        {
            if (myModel != null)
            {
                Globals.spriteBatch.Draw(myModel, new Rectangle((int)(pos.X + OFFSET.X), (int)(pos.Y + OFFSET.Y), (int)(dims.X), (int)(dims.Y)), null, COLOR, 0.0f, new Vector2(ORIGIN.X, ORIGIN.Y), new SpriteEffects(), 0);
            }
        }
    }
}
