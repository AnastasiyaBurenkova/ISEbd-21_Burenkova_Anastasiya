using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class Maslo
    {
        ///температура масла . 0- холодный, 100- шипит
        private int temperature = 0;
        public int Temperature { get { return temperature; } }
        /// повышаем температуру пока не зашипит
        public void GetHeat()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }

    }
}