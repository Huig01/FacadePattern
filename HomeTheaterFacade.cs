using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class HomeTheaterFacade
    {
        public HomeTheaterFacade(Amplifier amp, CdPlayer cdPlayer, DvdPlayer dvdPlayer, PopcornPopper popcornPopper, Projector projector, Screen screen, TheaterLights lights, Tuner tuner) {
            this.amp = amp;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.tuner = tuner;
        }

        private Amplifier amp;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights lights;
        private Tuner tuner;
        
        public void WatchMovie(string movie)
        {
            popcornPopper.On();
            popcornPopper.Pop();

            lights.Dim(10);

            screen.Down();

            projector.On();
            projector.SetInput(dvdPlayer);
            projector.WideScreenMode();

            amp.On();
            amp.SetDvd(dvdPlayer);
            amp.SetSurroundSound();
            amp.SetVolume(5);

            dvdPlayer.On();
            dvdPlayer.Play("Die Hard");
        }
        public void EndMovie()
        {
            dvdPlayer.Stop();
            dvdPlayer.Off();            
           
            amp.Off();           

            projector.Off();            

            screen.Up();

            lights.Off();            

            popcornPopper.Off();
        }
        public void ListenToCd()
        {

        }

        public void EndCd()
        {

        }

        public void ListenTRadio()
        {

        }
        public void EndRadio()
        {

        }

    }
}
