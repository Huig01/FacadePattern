using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("The cdplayer is on");
        }
        public void Off()
        {
            Console.WriteLine("The cdplayer is on");
        }
        public void Eject()
        {
            Console.WriteLine("The cdplayer is ejected");
        }
        public void Pause()
        {
            Console.WriteLine("The cdplayer is paused");
        }
        public void Play()
        {
            Console.WriteLine("The cdplayer is being palyed");
        }
        public void Stop()
        {
            Console.WriteLine("The cdplayer has stopped");
        }
    }
}
