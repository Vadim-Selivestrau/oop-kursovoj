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
        public Mob(string PATH, Vector2 POS, Vector2 DIMS, int OWNERID)
            : base(PATH, POS, DIMS, OWNERID)
        {
            speed = 3.0f;
        }
        public override void Update(Vector2 OFFSET, Player ENEMY)
        {
             AI(ENEMY.playerSpaceShip);



            base.Update(OFFSET);
        }

        public virtual void AI(PlayerSpaceShip PLAYER)
        {
            pos = new Vector2 ((pos.X - speed),pos.Y);

            if (Globals.GetDistance(pos, PLAYER.pos) < Globals.playerSize.X)
            {
                PLAYER.GetHit(1);
                dead = true;
            }


            if(pos.X < 50)
            {
                dead = true;
                
            }
           /* if (Globals.GetDistance(pos, new Vector2(Globals.screenHeight, Globals.screenWidth) )
            {
                /*counter - 50 score*/
            //}
        }


        public override void Draw()
        {
            base.Draw();
        }

        



    }
}
