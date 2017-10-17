using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    public class Car : Vehicle
    {
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 300)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }
        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 0 && value < 5)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 3;
                }
            }
        }
        public override int MaxCountСapacitys
        {
            get
            {
                return base.MaxCountСapacitys;
            }

            protected set
            {
                if (value > 0 && value < 9)
                {
                    base.MaxCountСapacitys = value;
                }
                else
                {
                    base.MaxCountСapacitys = 7;
                }
            }
        }
        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 1500 && value < 5000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }
        public Car(int maxSpeed, int maxCountPassengers, int maxCountСapacitys, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.MaxCountСapacitys = maxCountСapacitys;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            this.countСapacitys = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }
        public override void moveCar(Graphics g)
        {
            startPosX +=
                (MaxSpeed * 50 / (float)Weight) /
                    (countСapacitys == 0 ? 1 : countСapacitys);
            drawCar(g);
        }
        public override void drawCar(Graphics g)
        {
            drawLightCar(g);
        }
        protected virtual void drawLightCar(Graphics g)
        {
            //границы машины
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, startPosX, startPosY, 20, 20);
            g.DrawEllipse(pen, startPosX, startPosY + 30, 20, 20);
            g.DrawEllipse(pen, startPosX + 70, startPosY, 20, 20);
            g.DrawEllipse(pen, startPosX + 70, startPosY + 30, 20, 20);
            g.DrawRectangle(pen, startPosX - 1, startPosY + 10, 10, 30);
            g.DrawRectangle(pen, startPosX + 80, startPosY + 10, 10, 30);
            g.DrawRectangle(pen, startPosX + 10, startPosY - 1, 70, 52);

            // задние фары
            Brush brRed = new SolidBrush(Color.Red);
            g.FillEllipse(brRed, startPosX, startPosY, 20, 20);
            g.FillEllipse(brRed, startPosX, startPosY + 30, 20, 20);
            //передние фары 
            Brush brYellow = new SolidBrush(Color.Yellow);
            g.FillEllipse(brYellow, startPosX + 70, startPosY, 20, 20);
            g.FillEllipse(brYellow, startPosX + 70, startPosY + 30, 20, 20);
            //кузов
            Brush br = new SolidBrush(ColorBody);
            g.FillRectangle(br, startPosX - 50, startPosY + 10, 60, 30);
            g.FillRectangle(br, startPosX + 80, startPosY + 10, 10, 30);
            g.FillRectangle(br, startPosX + 10, startPosY, 70, 50);

            //стекла
            Brush brBlue = new SolidBrush(Color.LightBlue);
            g.FillRectangle(brBlue, startPosX + 60, startPosY + 5, 5, 40);
            g.FillRectangle(brBlue, startPosX + 20, startPosY + 5, 5, 40);
            g.FillRectangle(brBlue, startPosX + 25, startPosY + 3, 35, 2);
            g.FillRectangle(brBlue, startPosX + 25, startPosY + 46, 35, 2);

            //выделяем рамкой крышу
            g.DrawRectangle(pen, startPosX + 25, startPosY + 5, 35, 40);
            g.DrawRectangle(pen, startPosX + 65, startPosY + 10, 25, 30);
            g.DrawRectangle(pen, startPosX, startPosY + 10, 15, 30);
        }
    }
}
