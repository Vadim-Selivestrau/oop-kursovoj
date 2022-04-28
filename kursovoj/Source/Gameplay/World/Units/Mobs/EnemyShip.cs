﻿#region Includes
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
    class EnemyShip : Mob
    {
        public EnemyShip(Vector2 POS)
            : base(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Units\shiprot", POS, new Vector2(250,250))
        {
            speed = 5.0f;
        }

        public override void Update(Vector2 OFFSET, PlayerSpaceShip PLAYER)
        {

            base.Update(OFFSET, PLAYER);
        }

        public override void Draw()
        {
            base.Draw();
        }


    }
}
