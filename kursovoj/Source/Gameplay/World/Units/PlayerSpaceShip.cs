﻿#region Includes
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
    class PLAYER : Unit
    {
        public PLAYER(string PATH, Vector2 POS, Vector2 DIMS)
            :base(PATH, POS, DIMS)
        {
            speed = 3.0f;
        }

        public override void Update(Vector2 OFFSET)
        {
            if (Globals.keyboard.GetPress("W"))
            {
                pos = new Vector2(pos.X, pos.Y - speed);
            }

            if (Globals.keyboard.GetPress("A"))
            {
                pos = new Vector2(pos.X - speed, pos.Y);
            }

            if (Globals.keyboard.GetPress("S"))
            {
                pos = new Vector2(pos.X, pos.Y + speed);
            }

            if (Globals.keyboard.GetPress("D"))
            {
                pos = new Vector2(pos.X + speed, pos.Y);
            }

            if (Globals.keyboard.GetPress("Space"))
            {
                //GameGlobals.PassObjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(pos.X + Globals.screenHeight, pos.Y - 100)));
                if (Globals.keyboard.KeyUp())
                {
                    GameGlobals.PassObjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(pos.X + Globals.screenHeight, pos.Y)));
                }
                //GameGlobals.PassObjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(pos.X + Globals.screenHeight, pos.Y + 100)));
            }


            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }


    }
}
