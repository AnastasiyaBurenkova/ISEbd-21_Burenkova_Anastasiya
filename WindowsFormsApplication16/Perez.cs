using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class Perez
    ///  Класс, описывающий перец
    {
        /// состояние готовности перца, 0- не готов, 10-готова
        private int has_ready_perez = 0;
        /// состояние загрязненности перца, 0- чистая, 10- очень грязная
        private int dirty_perez = 10;
        /// Наличие кожуры и порезанность. да. нет
        public bool Have_skin_perez { set; get; }
        /// узнаем состояние готовности перца
        public int Has_ready_perez { get { return has_ready_perez; } }
        /// задаем состояние загрязнённости 
        public int Dirty_perez { set { if (value > -1 && value < 11) dirty_perez = value; } get { return dirty_perez; } }
        /// изменяем состояние готовности при готовке
        public void GetHeat()
        {
            if (has_ready_perez < 10)
            {
                has_ready_perez++;
            }
        }
    }
}