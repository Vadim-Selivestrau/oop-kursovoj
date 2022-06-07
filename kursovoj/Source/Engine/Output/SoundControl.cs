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
    public class SoundControl
    {
        public float volume;
        public SoundEffect sound;
        public SoundEffectInstance instance;

        public SoundControl(string MUSICPATH)
        {
            if(MUSICPATH != "")
            {

            }
        }


        public virtual void ChangeMusic(string MUSICPATH)
        {
            sound = Globals.content.Load<SoundEffect>(MUSICPATH);
            instance = sound.CreateInstance();
            volume = .25f;



            instance.Volume = volume;
            instance.IsLooped = true;
            instance.Play();
        }
    }
}
