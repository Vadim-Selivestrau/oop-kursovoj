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
    class Mob : Unit
    {
        public Mob(string PATH, Vector2 POS, Vector2 DIMS)
            : base(PATH, POS, DIMS)
        {
            speed = 3.0f;
        }
        public override void Update(Vector2 OFFSET, PlayerSpaceShip PLAYER)
        {
             AI(PLAYER);



            base.Update(OFFSET);
        }

        public virtual void AI(PlayerSpaceShip PLAYER)
        {
            pos = new Vector2 ((pos.X - speed),pos.Y);
        }


        public override void Draw()
        {
            base.Draw();
        }

        



    }
}
