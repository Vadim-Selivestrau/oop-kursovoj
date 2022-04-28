#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
#endregion


namespace MyGame
{
    class QuantityDisplayBar
    {
        public int boarder;

        public Basic2d bar, barBGK;

        public Color color;

        public QuantityDisplayBar(Vector2 DIMS, int BOARDER, Color COLOR)
        {
            boarder = BOARDER;
            color = COLOR;

            bar = new Basic2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Mics\hearts", new Vector2(0, 0), new Vector2(DIMS.X - boarder * 2, DIMS.Y - boarder * 2));
            barBGK = new Basic2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\2d\Units\shipevil", new Vector2(0, 0), new Vector2(DIMS.X, DIMS.Y));

        }

        public virtual void Update(float  CURRENT, float MAX)
        {
            bar.dims = new Vector2(CURRENT/MAX*(barBGK.dims.X-boarder*2), bar.dims.Y);
        }
        
        public virtual void Draw(Vector2 OFFSET)
        {
            barBGK.Draw(OFFSET, new Vector2(0,0), Color.Black);
            bar.Draw(OFFSET + new Vector2(boarder, boarder), new Vector2(0,0), color);
        }

    }
}
