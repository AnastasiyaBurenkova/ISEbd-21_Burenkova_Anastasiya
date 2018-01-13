using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class Kabach
    ///  Класс, описывающий кабачок
    {
        /// состояние готовности кабачка, 0- не готов, 10-готова
        private int has_ready_kabach = 0;
        /// состояние загрязненности кабачка, 0- чистая, 10- очень грязная
        private int dirty_kabach = 10;
        /// порезанность. да. нет
        public bool Have_skin_kabach { set; get; }
        /// узнаем состояние готовности кабачка
        public int Has_ready_kabach { get { return has_ready_kabach; } }
        /// задаем состояние загрязнённости 
        public int Dirty_kabach { set { if (value > -1 && value < 11) dirty_kabach = value; } get { return dirty_kabach; } }
        /// изменяем состояние готовности при готовке
        public void GetHeat()
        {
            if (has_ready_kabach < 10)
            {
                has_ready_kabach++;
            }
        }
    }
}