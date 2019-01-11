using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Многоугольники
{
    public class RadiusEventArgs: EventArgs
    {
        protected int Radius;

        public RadiusEventArgs(int value)
        {
            Radius = value;
        }

        public int RADIUS
        {
            get
            {
                return Radius;
            }
            set
            {
                Radius = value;
            }
        }
    }
}
