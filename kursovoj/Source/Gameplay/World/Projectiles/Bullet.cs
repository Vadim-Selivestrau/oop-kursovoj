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
    class Bullet : Projectile
    {

        public Bullet(Vector2 POS, Unit OWNER, Vector2 TARGET)
            : base(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Projectiles\bulllet", POS, new Vector2(20, 20), OWNER, TARGET)
        {

        }

        public override void Update(Vector2 OFFSET, List<Unit> UNITS)
        {
            base.Update(OFFSET, UNITS);

        }


       



        public override void Draw()
        {
            base.Draw();
        }

    }
}
