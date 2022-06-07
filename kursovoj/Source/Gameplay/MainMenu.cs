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
    class MainMenu
    {
        public Basic2d bkg;

        public PassObject PlayClickDel, ExitClickDel;

        public List<Button2d> buttons = new List<Button2d>();
        public MainMenu(PassObject PLAYCLICKDEL, PassObject EXITCLICKDEL)
        {
            PlayClickDel = PLAYCLICKDEL;
            ExitClickDel = EXITCLICKDEL;

            bkg = new Basic2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\bcgOrig", new Vector2(Globals.screenWidth/2, Globals.screenHeight/2), new Vector2(Globals.screenWidth, Globals.screenHeight));
            buttons.Add(new Button2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\circle", new Vector2(50, 50), new Vector2(96, 32), @"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\MyFont", "Play", PlayClickDel, 1));
            buttons.Add(new Button2d(@"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\circle", new Vector2(300, 750), new Vector2(96, 32), @"D:\uni\4sem\OOP\kursovoj\kursovoj\Content\bin\MyFont", "Exit", ExitClickDel, null));
        }

        public virtual void Update()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Update(new Vector2(50, 50));
            }
        }
        public virtual void Draw()
        {
            bkg.Draw();
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Draw();
            }
        }
    }
}
