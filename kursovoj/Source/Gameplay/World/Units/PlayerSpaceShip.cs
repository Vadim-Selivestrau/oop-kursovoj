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
    class PlayerSpaceShip : Unit
    {
        SoundEffect shootSound = Globals.content.Load<SoundEffect>(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\shoot");
            
        public PlayerSpaceShip(string PATH, Vector2 POS, Vector2 DIMS, int OWNERID)
            :base(PATH, POS, DIMS, OWNERID)
        {
            speed = 6.0f;

            health = 30;
            healthMax = health;
        }

        public override void Update(Vector2 OFFSET)
        {
            bool checkCordon = false;

            
            if (Globals.keyboard.GetPress("W"))
            {
                if (pos.Y > Globals.playerSize.Y / 2) 
                { 
                    pos = new Vector2(pos.X, pos.Y - speed);
                    checkCordon = true; 
                }
            }

            if (Globals.keyboard.GetPress("A"))
            {
                if (pos.X > (Globals.playerSize.X / 2) - 5)
                {
                    pos = new Vector2(pos.X - speed, pos.Y);
                    checkCordon = true;
                }
            }

            if (Globals.keyboard.GetPress("S"))
            {
                if (pos.Y < Globals.screenHeight - (Globals.playerSize.Y / 2))
                {
                    pos = new Vector2(pos.X, pos.Y + speed);
                    checkCordon = true;
                }
            }

            if (Globals.keyboard.GetPress("D"))
            {
                if (pos.X < Globals.screenWidth - (Globals.playerSize.X / 2))
                {
                    pos = new Vector2(pos.X + speed, pos.Y);
                    checkCordon = true;
                }
            }

            if (Globals.keyboard.GetPress("Space"))
            {
                if (Globals.keyboard.KeyUp())
                {
                    shootSound.Play();
                    GameGlobals.PassObjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(pos.X + Globals.screenHeight, pos.Y - 100)));
                    GameGlobals.PassObjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(pos.X + Globals.screenHeight, pos.Y)));
                    GameGlobals.PassObjectile(new Bullet(new Vector2(pos.X, pos.Y), this, new Vector2(pos.X + Globals.screenHeight, pos.Y + 100)));
                }

            }
            if (checkCordon)
            {
                //GameGlobals.CheckCordon(pos);
            }

            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }


    }
}
