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
    class SpawnShip : Mob
    {

        public MyTimer spawnTimer;
        public SpawnShip(Vector2 POS, int OWNERID)
            : base(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Units\Mobs\ENEMYSHIP", POS, new Vector2(100,100), OWNERID)
        {
            speed = 2.0f;
            
            health = 3;
            healthMax = health;


            spawnTimer = new MyTimer(8000);
            spawnTimer.AddToTimer(4000);
        }

        public override void Update(Vector2 OFFSET, Player ENEMY)
        {
            spawnTimer.UpdateTimer();

            if (spawnTimer.Test())
            {
                SpawnEgg();
                spawnTimer.ResetToZero();
            }
            

            base.Update(OFFSET, ENEMY);
        }

        public virtual void SpawnEgg()
        {
            GameGlobals.PassSpawnPoint(new SpawnEgg(new Vector2(pos.X, pos.Y), ownerId));
        }
        public override void Draw()
        {
            base.Draw();
        }


    }
}
