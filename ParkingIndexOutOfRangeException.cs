using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    class ParkingIndexOutOfRangeException : Exception
    {
        public ParkingIndexOutOfRangeException():
            base ("На парковке нет машин по такому месту")
        { }
    }
}
