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
    class SpawnEgg : SpawnPoint
    {

        int maxSpawn, totalSpawn;
        public SpawnEgg(Vector2 POS, int OWNERID)
            : base(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", POS, new Vector2(45,45), OWNERID)
        {
            totalSpawn = 0;
            maxSpawn = 3;
        }

        public override void Update(Vector2 OFFSET)
        {
               

            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }

        public override void SpawnMob()
        {
            Mob tempMob = new LittleShip(new Vector2(pos.X, pos.Y), ownerId);

            if(tempMob != null)
            { 
                GameGlobals.PassMob(tempMob);

                totalSpawn++;
                if(totalSpawn >= maxSpawn)
                {
                    dead = true;
                }
            }
        }

        


    }
}
