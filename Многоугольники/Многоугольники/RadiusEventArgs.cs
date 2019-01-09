using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Многоугольники
{
    public class RadiusEventArgs: EventArgs
    {
        protected static int Radius;
        private int value;

        public RadiusEventArgs(int value)
        {
            this.value = value;
        }

        public static int RADIUS
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
