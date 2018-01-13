using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class WaterTap
    {
        public bool State { set; get; }
        public void Wash(Potato p)
        {
            if (State)
            {
                p.Dirty_potato = 0;
            }
        }
        public void Wash2(Perez p2)
        {
            if (State)
            {
                p2.Dirty_perez = 0;
            }
        }
        public void Wash3(Kabach p3)
        {
            if (State)
            {
                p3.Dirty_kabach = 0;
            }
        }

    }
}
