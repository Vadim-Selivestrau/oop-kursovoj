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
        public bool done;

        public Unit owner;

        public Vector2 direction;

        public float speed;
        
        public MyTimer timer;
        
        public Projectile(string PATH, Vector2 POS, Vector2 DIMS, Unit OWNER, Vector2 TARGET)
            : base(PATH, POS, DIMS)
        {
            done = false;

            speed = 5.0f;

            owner = OWNER;

            direction = TARGET - owner.pos;
            direction.Normalize();

            timer = new MyTimer(1200);
        }

        public virtual void Update(Vector2 OFFSET, List<Unit> UNITS)
        {
            pos += direction * speed;

            timer.UpdateTimer();

           /* if (timer.Test())
            {
                done = true;
            }*/

            if (HitSomething(UNITS))
            {
                done = true;
            }

        }


        public virtual bool HitSomething(List<Unit> units)
        {
            return false;
        }



        public override void Draw()
        {
            base.Draw();
        }

    }
}
