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
    class AttackableObject : Basic2d
    {
        public bool dead;

        public int ownerId;

        public float speed, hitDistance, health, healthMax;

        SoundEffect enemyEndSound = Globals.content.Load<SoundEffect>(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\minus");


        public AttackableObject(string PATH, Vector2 POS, Vector2 DIMS, int OWNERID)
            :base(PATH, POS, DIMS)
        {
            ownerId = OWNERID;

            dead = false;

            speed = 3.0f;

            health = 1;
            healthMax = health;

            hitDistance = 35.0f;
        }

        public virtual void Update(Vector2 OFFSET, Player ENEMY)
        {
            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }

        public virtual void GetHit(float DAMAGE)
        {
            enemyEndSound.Play();

            health -= DAMAGE;

            if(health <= 0)
            { 

                dead = true; 
            }
        }


    }
}
