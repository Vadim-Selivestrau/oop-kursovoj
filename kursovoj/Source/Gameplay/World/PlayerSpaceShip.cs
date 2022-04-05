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
    class PlayerSpaceShip : Basic2d
    {
        public PlayerSpaceShip(string PATH, Vector2 POS, Vector2 DIMS)
            :base(PATH, POS, DIMS)
        {

        }

        public override void Update()
        {
            if (Globals.keyboard.GetPress("W"))
            {
                pos = new Vector2(pos.X, pos.Y - 3);
            }

            if (Globals.keyboard.GetPress("A"))
            {
                pos = new Vector2(pos.X - 3, pos.Y);
            }

            if (Globals.keyboard.GetPress("S"))
            {
                pos = new Vector2(pos.X, pos.Y + 3);
            }

            if (Globals.keyboard.GetPress("D"))
            {
                pos = new Vector2(pos.X + 3, pos.Y);
            }

            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }


    }
}
