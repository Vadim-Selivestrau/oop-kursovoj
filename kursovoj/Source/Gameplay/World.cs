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

    
    class World
    {

        public PlayerSpaceShip playerSpaceShip;

        public World()
        {
            playerSpaceShip = new PlayerSpaceShip(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\VLADYM", new Vector2(300, 300), new Vector2(200, 200));
        }

        public virtual void Update()
        {
            playerSpaceShip.Update();
        }

        public virtual void Draw()
        {
            playerSpaceShip.Draw();
        }
    }
}
