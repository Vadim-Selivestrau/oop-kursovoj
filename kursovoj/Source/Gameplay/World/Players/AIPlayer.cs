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
    class AIPlayer : Player
    {
        public AIPlayer(int ID) 
            : base(ID)
        {
            spawnPoints.Add(new Portal(new Vector2(Globals.screenWidth + 100, 100), id));


            spawnPoints.Add(new Portal(new Vector2(Globals.screenWidth + 100, 300), id));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(500);

            spawnPoints.Add(new Portal(new Vector2(Globals.screenWidth + 100, 500), id));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(1000);

            spawnPoints.Add(new Portal(new Vector2(Globals.screenWidth + 100, 700), id));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(3000);

            spawnPoints.Add(new Portal(new Vector2(Globals.screenWidth + 100, 850), id));
            spawnPoints[spawnPoints.Count - 1].spawnTimer.AddToTimer(2500);

        }

        public override void Update(Player ENEMY, Vector2 OFFSET)
        {
            base.Update(ENEMY, OFFSET);
        }

        
    }
}
