using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
    public class Gruzovik : Car
    {
        private bool bamper;
        private bool kuzov;
        private bool kolesa;
        private Color dopColor;
        public Gruzovik(int maxSpeed, int maxCountPassenger, int maxCountСapacity, double weight, Color color,
            bool bamper, bool kuzov, bool kolesa, Color dopColor) :
            base(maxSpeed, maxCountPassenger, maxCountСapacity, weight, color)
        {
            this.bamper = bamper;
            this.kuzov = kuzov;
            this.kolesa = kolesa;
            this.dopColor = dopColor;
        }
        public void setDopColor(Color color)
        {
            dopColor = color;
        }
        protected override void drawLightCar(Graphics g)
        {
            if (bamper)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, startPosX + 80, startPosY - 6, 20, 20);
                g.DrawEllipse(pen, startPosX + 80, startPosY + 35, 20, 20);
                g.DrawEllipse(pen, startPosX - 57, startPosY - 6, 70, 20);
                g.DrawEllipse(pen, startPosX - 57, startPosY + 35, 70, 20);
                g.DrawRectangle(pen, startPosX + 80, startPosY - 6, 15, 15);
                g.DrawRectangle(pen, startPosX + 80, startPosY + 40, 15, 15);
                g.DrawRectangle(pen, startPosX, startPosY - 6, 14, 15);
                g.DrawRectangle(pen, startPosX, startPosY + 40, 14, 15);

                Brush spoiler = new SolidBrush(dopColor);
                g.FillEllipse(spoiler, startPosX + 80, startPosY - 5, 20, 20);
                g.FillEllipse(spoiler, startPosX + 80, startPosY + 35, 20, 20);
                g.FillRectangle(spoiler, startPosX + 75, startPosY, 25, 40);
                g.FillRectangle(spoiler, startPosX + 80, startPosY - 5, 15, 15);
                g.FillRectangle(spoiler, startPosX + 80, startPosY + 40, 15, 15);

                g.FillEllipse(spoiler, startPosX - 57, startPosY - 5, 70, 20);
                g.FillEllipse(spoiler, startPosX - 57, startPosY + 35, 70, 20);
                g.FillRectangle(spoiler, startPosX - 5, startPosY, 25, 40);
                g.FillRectangle(spoiler, startPosX, startPosY - 5, 15, 15);
                g.FillRectangle(spoiler, startPosX, startPosY + 40, 15, 15);
            }
            if (kolesa)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen, startPosX + 25, startPosY - 6, 39, 10);
                g.DrawRectangle(pen, startPosX + 25, startPosY + 45, 39, 10);

                Brush spoiler = new SolidBrush(dopColor);
                g.FillRectangle(spoiler, startPosX + 25, startPosY - 5, 40, 10);
                g.FillRectangle(spoiler, startPosX + 25, startPosY + 45, 40, 10);
            }
            base.drawLightCar(g);
            if (kuzov)
            {
                Brush spoiler = new SolidBrush(dopColor);
                g.FillRectangle(spoiler, startPosX - 55, startPosY, 60, 50);
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen, startPosX - 55, startPosY, 60, 50);
            }
        }

    }
}