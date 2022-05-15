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
    class Player
    {
        public PlayerSpaceShip playerSpaceShip;
        public List<Unit> units = new List<Unit>();
        public List<SpawnPoint> spawnPoints = new List<SpawnPoint>();
        public Player()
        {
               
        }

        public virtual void Update(Player ENEMY, Vector2 OFFSET)
        {
            if(playerSpaceShip != null)
            {
                playerSpaceShip.Update(OFFSET);
            }

            for (int i = 0; i < units.Count; i++)
            {
                units[i].Update(OFFSET, ENEMY);

                if (units[i].dead)
                {
                    ChangeScore(1);//numKilled++;//not correctly works
                    units.RemoveAt(i);
                    i--;
                }
            }

        }

        public virtual void AddUnit(object INFO)
        {
            units.Add((Unit)INFO);
        }

        public virtual void ChangeScore(int SCORE)
        {

        }
        public virtual void Draw(Vector2 OFFSET)
        {
            if(playerSpaceShip != null)
            {
                playerSpaceShip.Draw();
            }

            for (int i = 0; i < units.Count; i++)
            {
                units[i].Draw();
            }

            for (int i = 0; i < spawnPoints.Count; i++)
            {
                spawnPoints[i].Update(OFFSET); 

            }

            for (int i = 0; i < spawnPoints.Count; i++)
            {
                spawnPoints[i].Draw();
            }

        }
    }
}
