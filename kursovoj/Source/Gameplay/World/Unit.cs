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
    class Unit : Basic2d
    {
        public bool dead;

        public float speed, hitDistance, health, healthMax;
        public Unit(string PATH, Vector2 POS, Vector2 DIMS)
            :base(PATH, POS, DIMS)
        {
            dead = false;

            speed = 3.0f;

            health = 1;
            healthMax = health;

            hitDistance = 35.0f;
        }

        public override void Update(Vector2 OFFSET)
        {

            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }

        public virtual void GetHit(float DAMAGE)
        {
            health -= DAMAGE;

            if(health <= 0)
            { 
                dead = true; 
            }
        }


    }
}
