using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("the dvdplayer is on");
        }
        public void Off()
        {
            Console.WriteLine("the dvdplayer is off");
        }
        public void Eject()
        {
            Console.WriteLine("the dvdplayer is ejected");
        }
        public void Pause()
        {
            Console.WriteLine("the dvd is paused");
        }
        public void Play(string movie)
        {
            Console.WriteLine("The dvdplayer play movie");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("set surroundAudio");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("set twochannelAudio");
        }
        public void Stop()
        {
            Console.WriteLine("The dvdplayer has stopped");
        }
    }
}
