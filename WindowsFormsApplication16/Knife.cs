using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class Knife
    {
        public void Clean_and_res(Potato p)
        {
            if (p.Have_skin_potato)
            {
                p.Have_skin_potato = false;
            }
        }
        public void Clean_and_res2(Perez p2)
        {
            if (p2.Have_skin_perez)
            {
                p2.Have_skin_perez = false;
            }
        }
        public void Clean_and_res3(Kabach p3)
        {
            if (p3.Have_skin_kabach)
            {
                p3.Have_skin_kabach = false;
            }
        }
    }
}
