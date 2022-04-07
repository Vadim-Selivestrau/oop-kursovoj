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

    
    class World
    {
        public Vector2 offset;

        public PlayerSpaceShip playerSpaceShip;


        public List<Projectile> projectiles= new List<Projectile>();

        public List<Mob> mobs = new List<Mob>();

        public List<SpawnPoint> spawnPoints= new List<SpawnPoint>();

        public World()
        {
            playerSpaceShip = new PlayerSpaceShip(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\VLADYM", new Vector2(50, 250), new Vector2(100, 100));

            GameGlobals.PassObjectile = AddProjectile;
            GameGlobals.PassMob = AddMob;

            offset = new Vector2(0, 0);

            spawnPoints.Add(new SpawnPoint(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", new Vector2(Globals.screenWidth + 100, 200), new Vector2(100, 200)));


            spawnPoints.Add(new SpawnPoint(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", new Vector2(Globals.screenWidth + 100, 300), new Vector2(100, 200)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(500);

            spawnPoints.Add(new SpawnPoint(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", new Vector2(Globals.screenWidth + 100, 400), new Vector2(100, 200)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(1000);

            spawnPoints.Add(new SpawnPoint(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", new Vector2(Globals.screenWidth + 100, 500), new Vector2(100, 200)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(3000);

            spawnPoints.Add(new SpawnPoint(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\circle", new Vector2(Globals.screenWidth + 100, 100), new Vector2(100, 200)));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(2500);
        }

        public virtual void Update()
        {
            playerSpaceShip.Update(offset);

            for (int i = 0; i < spawnPoints.Count; i++)
            {
                spawnPoints[i].Update(offset);

               
            }



            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Update(offset, mobs.ToList<Unit>());

                if (projectiles[i].done)
                {
                    projectiles.RemoveAt(i);
                    i--;
                }
            }


            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].Update(offset, playerSpaceShip);

                if (mobs[i].dead)
                {
                    mobs.RemoveAt(i);
                    i--;
                }
            }


        }


        public virtual void AddMob(object INFO)
        {
            mobs.Add((Mob)INFO);
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

            for (int i = 0; i < mobs.Count; i++)
            {
                mobs[i].Draw();
            }


            for (int i = 0; i < spawnPoints.Count; i++)
            {
                spawnPoints[i].Draw();
            }
        }
    }
}
