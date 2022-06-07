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
    class GamePlay
    {

        int playState;

        World world;

        PassObject ChangeGameState;
        public GamePlay(PassObject CHANGEGAMESTATE)
        {
            playState = 0;

            ResetWorld(null);
            ChangeGameState = CHANGEGAMESTATE;
        }
        public virtual void Update()
        {
            if(playState == 0)
            {
                world.Update();
            }
        }

        public virtual void ResetWorld(object INFO)
        {
            world = new World(ResetWorld, ChangeGameState);
        }

        public virtual void Draw()
        {
            if (playState == 0)
            {
                world.Draw();
            }
        }
    }
}
