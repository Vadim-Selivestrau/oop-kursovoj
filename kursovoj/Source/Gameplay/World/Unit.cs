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
        public float speed;
        public Unit(string PATH, Vector2 POS, Vector2 DIMS)
            :base(PATH, POS, DIMS)
        {
            speed = 3.0f;
        }

        public override void Update()
        {

            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }


    }
}
