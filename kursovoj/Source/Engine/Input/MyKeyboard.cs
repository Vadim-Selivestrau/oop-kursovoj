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
    class MyKeyboard
    {

        private KeyboardState newKeyboard, oldKeyboard;

        private List<MyKey> pressedKeys = new List<MyKey>(), previousPressedKeys = new List<MyKey>();

        public MyKeyboard()
        {

        }

        public virtual void Update()
        {
            newKeyboard = Keyboard.GetState();

            GetPressedKeys();

        }

        public void UpdateOld()
        {
            oldKeyboard = newKeyboard;

            previousPressedKeys = new List<MyKey>();
            for (int i = 0; i < pressedKeys.Count; i++)
            {
                previousPressedKeys.Add(pressedKeys[i]);
            }
        }


        public bool GetPress(string KEY)
        {

            for (int i = 0; i < pressedKeys.Count; i++)
            {

                if (pressedKeys[i].GetKey() == KEY)
                {
                    return true;
                }

            }


            return false;
        }
        /*public bool IsKeyUp(System.Windows.Input.Key key);*/
        public bool KeyUp()
        {
            if (newKeyboard == oldKeyboard)
            {
                return false;
            }
            return true;
        }

        public virtual void GetPressedKeys()
        {
            bool found = false;

            pressedKeys.Clear();
            for (int i = 0; i < newKeyboard.GetPressedKeys().Length; i++)
            {

                pressedKeys.Add(new MyKey(newKeyboard.GetPressedKeys()[i].ToString(), 1));

            }
        }

    }
}
