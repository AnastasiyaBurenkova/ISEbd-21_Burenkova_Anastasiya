using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class Potato
    ///  Класс, описывающий картофель
    {
        /// состояние готовности картошки, 0- не готов, 10-готова
        private int has_ready_potato = 0;
        /// состояние загрязненности картошки, 0- чистая, 10- очень грязная
        private int dirty_potato = 10;
        /// Наличие кожуры и порезанность. да. нет
        public bool Have_skin_potato { set; get; }
        /// узнаем состояние готовности картошки
        public int Has_ready_potato { get { return has_ready_potato; } }
        /// задаем состояние загрязнённости 
        public int Dirty_potato { set { if (value > -1 && value < 11) dirty_potato = value; } get { return dirty_potato; } }
        /// изменяем состояние готомности при готовке
        public void GetHeat()
        {
            if (has_ready_potato < 10)
            {
                has_ready_potato++;
            }
        }
    }
}
