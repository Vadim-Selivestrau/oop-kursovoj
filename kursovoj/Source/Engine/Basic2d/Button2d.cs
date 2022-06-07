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
    class Button2d : Basic2d
    {

        public bool isPressed, isHovered;
        public string text;

        public Color hoverColor;

        public SpriteFont font;

        public object info;

        PassObject ButtonClicked;
        public Button2d(string PATH, Vector2 POS, Vector2 DIMS, string FONTPATH, string TEXT, PassObject BUTTONCLICKED, object INFO) 
            : base(PATH, POS, DIMS)
        {
            text = TEXT;
            info = INFO;
            ButtonClicked = BUTTONCLICKED;
            if (FONTPATH != "")
            {
                font = Globals.content.Load<SpriteFont>(FONTPATH);
            }
            isPressed = false;
            hoverColor = new Color(200, 200, 200);
        }

        public virtual void Update(Vector2 OFFSET)
        {
            if (Hover(OFFSET))
            {
                
                isHovered = true;

                if (Globals.mouse.LeftClick())
                {
                    isHovered = false;
                    isPressed = true;
                }
                else if (Globals.mouse.LeftClickRelease())
                {

                }
            }
            else
            {
                isHovered = false;
            }
            if(!Globals.mouse.LeftClick() && !Globals.mouse.LeftClickHold())
            {
                isPressed = true;
            }

            base.Update(OFFSET);
        }
        public virtual void Reset()
        {
            isPressed = false;
            isHovered = false;
        }
        public virtual void RunBtnClick()
        {
            if (ButtonClicked != null)
            {
                ButtonClicked(info);
            }
            Reset();
        }

        public override void Draw()
        {
            Color tempColor = Color.White;
            if (isPressed)
            {
                tempColor = Color.Gray;
            }
            else if (isHovered)
            {
                tempColor = hoverColor;
            }


            base.Draw();
        }
    }
}
