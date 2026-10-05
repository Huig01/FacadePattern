using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Projector
    {
        private DvdPlayer _dvdPlayer;
        public Projector()
        {
        }

        public void SetInput(DvdPlayer dvdPlayer)
        {
            this._dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("The projector is on");
        }

        public void Off()
        {
            Console.WriteLine("The projector is off");
        }

        public void TvMode()
        {
            Console.WriteLine("The tvmode is on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("The widescreenmode is on");
        }
    }
}
