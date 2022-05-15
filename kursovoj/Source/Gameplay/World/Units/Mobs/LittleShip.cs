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
    class LittleShip : Mob
    {

        public MyTimer spawnTimer;
        public LittleShip(Vector2 POS, int OWNERID)
            : base(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Units\Mobs\spaceship2", POS, new Vector2(50,50), OWNERID)
        {
            speed = 4.0f;
            

        }

        public override void Update(Vector2 OFFSET, Player ENEMY)
        {
            
            

            base.Update(OFFSET, ENEMY);
        }

       
        public override void Draw()
        {
            base.Draw();
        }


    }
}
