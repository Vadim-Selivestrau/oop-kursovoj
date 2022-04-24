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
    class SpawnPoint : Basic2d
    {
        private bool dead;

        private float speed, hitDistance;

        public MyTimer spawnTimer = new MyTimer(2200);
        public SpawnPoint(string PATH, Vector2 POS, Vector2 DIMS)
            : base(PATH, POS, DIMS)
        {
            dead = false;

            hitDistance = 35.0f;
        }

        public override void Update(Vector2 OFFSET)
        {
            spawnTimer.UpdateTimer();

            if (spawnTimer.Test())
            {
                SpawnMob();
                spawnTimer.ResetToZero();
            }

            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }

        public virtual void SpawnMob()
        {
            GameGlobals.PassMob(new EnemyShip(new Vector2(pos.X, pos.Y)));
        }

        public virtual void GetHit()
        {
            dead = true;
        }


    }
}
