using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("The lights are on");
        }

        public void Off()
        {
            Console.WriteLine("The lights are off");
        }

        public void Dim(int value)
        {
            Console.WriteLine("The lights are dimmed: " + value);
        }
    }
}
