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
    class Unit : AttackableObject
    {
        
        public Unit(string PATH, Vector2 POS, Vector2 DIMS, int OWNERID)
            :base(PATH, POS, DIMS, OWNERID)
        {
            
        }

        public virtual void Update(Vector2 OFFSET, Player ENEMY)
        {

            base.Update(OFFSET);
        }

        public override void Draw()
        {
            base.Draw();
        }

        


    }
}
