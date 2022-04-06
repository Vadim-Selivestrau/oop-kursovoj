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
        public Vector2 offset;

        public PlayerSpaceShip playerSpaceShip;


        public List<Projectile> projectiles= new List<Projectile>();

        public World()
        {
            playerSpaceShip = new PlayerSpaceShip(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\VLADYM", new Vector2(50, 250), new Vector2(100, 100));

            GameGlobals.PassObjectile = AddProjectile;

            offset = new Vector2(0, 0);
        
        }

        public virtual void Update()
        {
            playerSpaceShip.Update();


            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Update(offset, null);

                if (projectiles[i].done)
                {
                    projectiles.RemoveAt(i);
                    i--;
                }
            }


        }


        public virtual void AddProjectile(object INFO)
        {
            projectiles.Add((Projectile)INFO);
        }



        public virtual void Draw()
        {
            playerSpaceShip.Draw();

            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Draw();
            }
        }
    }
}
