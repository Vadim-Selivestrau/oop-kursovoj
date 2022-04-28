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
    class Projectile : Basic2d
    {
        private bool done;

        private Unit owner;

        private Vector2 direction;

        private float speed;

        private MyTimer timer;

        public bool GetDone()
        {
            return done;
        }
        
        public Projectile(string PATH, Vector2 POS, Vector2 DIMS, Unit OWNER, Vector2 TARGET)
            : base(PATH, POS, DIMS)
        {
            done = false;

            speed = 10.0f;

            owner = OWNER;

            direction = TARGET - owner.pos;
            direction.Normalize();

            timer = new MyTimer(5000);
        }

        public virtual void Update(Vector2 OFFSET, List<Unit> UNITS)
        {
            pos += direction * speed;

            timer.UpdateTimer();

            if (timer.Test())
            {
                done = true;
            }

            if (HitSomething(UNITS))
            {
                done = true;
            }
            

        }


        public virtual bool HitSomething(List<Unit> UNITS)
        {
            for(int i = 0; i < UNITS.Count; i++) 
            {
                if (Globals.GetDistance(pos, UNITS[i].pos) < UNITS[i].hitDistance)
                {
                    UNITS[i].GetHit(1);
                    return true;
                }
            }


            return false;
        }



        public override void Draw()
        {
            base.Draw();
        }

    }
}
