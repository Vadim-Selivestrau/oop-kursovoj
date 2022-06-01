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

        private Vector2 offset;

        

        private UI ui;


        public User user;

        public AIPlayer aIPlayer;



        

        private List<Projectile> projectiles= new List<Projectile>();
        
        

        PassObject ResetWorld;

        public World(PassObject RESETWORLD)
        {
            ResetWorld = RESETWORLD;
            
            GameGlobals.PassObjectile = AddProjectile;
            GameGlobals.PassMob = AddMob;
            GameGlobals.PassSpawnPoint = AddSpawnPoint;


            GameGlobals.paused = false;

            //GameGlobals.CheckCordon = CheckCordon;


            user = new User(1);
            aIPlayer = new AIPlayer(2);


            offset = new Vector2(0, 0);

            

            ui = new UI();
        }

        public virtual void Update()
        {
            if (!user.playerSpaceShip.dead && !GameGlobals.paused) 
            {
                user.Update(aIPlayer, offset);
                aIPlayer.Update(user, offset);

                
                



                for (int i = 0; i < projectiles.Count; i++)
                {
                    projectiles[i].Update(offset, aIPlayer.units.ToList<Unit>());

                    if (projectiles[i].GetDone())
                    {
                        projectiles.RemoveAt(i);
                        i--;
                    }
                }


                
            }
            else
            {
                if (Globals.keyboard.GetPress("Enter"))
                {
                    ResetWorld(null);
                }
            }
            if (Globals.keyboard.GetPress("P"))
            {
                if (Globals.keyboard.KeyUp())
                {
                    GameGlobals.paused = !GameGlobals.paused;
                }
            }

            ui.Update(this);

        }


        public virtual void AddMob(object INFO)
        {
            Unit tempUnit = (Unit)INFO;


            if (user.id == tempUnit.ownerId)
            {
                user.AddUnit(tempUnit);
            }
            else if (aIPlayer.id == tempUnit.ownerId)
            {
                aIPlayer.AddUnit(tempUnit); 
            }


            aIPlayer.AddUnit((Mob)INFO);
        }


        public virtual void AddProjectile(object INFO)
        {
            projectiles.Add((Projectile)INFO);
        }


        public virtual void AddSpawnPoint(object INFO)
        {
            SpawnPoint tempSpawnPoint = (SpawnPoint)INFO;


            if (user.id == tempSpawnPoint.ownerId)
            {
                user.AddSpawnPoint(tempSpawnPoint);
            }
            else if (aIPlayer.id == tempSpawnPoint.ownerId)
            {
                aIPlayer.AddSpawnPoint(tempSpawnPoint);
            }


        }


        public virtual void Draw()
        {
            
            user.Draw(offset);

            
            aIPlayer.Draw(offset);

            for (int i = 0; i < projectiles.Count; i++)
            {
                projectiles[i].Draw();
            }


            ui.Draw(this);
        }

        public virtual void CheckCordon(object INFO) 
        {
            Vector2 tempPos = (Vector2)INFO;
            if(tempPos.X < 0)
            {
                user.playerSpaceShip.speed = 0.2f;
            }
            else
            {
                user.playerSpaceShip.speed = 3.0f;
            }
        }
    }
}
