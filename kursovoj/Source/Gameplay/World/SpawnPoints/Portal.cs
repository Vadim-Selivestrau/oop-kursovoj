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
    class Portal : SpawnPoint
    {


        public Portal(Vector2 POS, int OWNERID)
            : base(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", POS, new Vector2(45,45), OWNERID)
        {

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
            int num = Globals.rand.Next(0, 10 + 1);

            Mob tempMob = null;

            if(num < 5)
            {
                tempMob = new EnemyShip(new Vector2(pos.X, pos.Y), ownerId);
            }
            else if(num < 8)
            {
                tempMob = new SpawnShip(new Vector2(pos.X, pos.Y), ownerId);
            }

            if(tempMob != null)
            {
                GameGlobals.PassMob(tempMob);
            }
            
        }

        


    }
}
