using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class FormSelectCar : Form
    {
        ITransport car = null;
        public ITransport getCar { get { return car; } }
        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.setPosition(45, 5);
                car.drawCar(gr);
                pictureBoxCar.Image = bmp;
            }
        }
        private event myDel eventAddCar;
        
        public void AddEvent(myDel ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new myDel(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }

        public FormSelectCar()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void labelCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelCar.DoDragDrop(labelCar.Text,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelGruzovik_MouseDown(object sender, MouseEventArgs e)
        {
            labelGruzovik.DoDragDrop(labelGruzovik.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Car":
                    car = new Car(100, 4, 3, 500, Color.Black);
                    break;
                case "Gruzovik":
                    car = new Gruzovik(100, 4, 3, 500, Color.Black, true, true, true, Color.Black);
                    break;
            }
            DrawCar();
        }
        
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
       
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }
        
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is Gruzovik)
                {
                    (car as Gruzovik).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (eventAddCar != null)
            {
                eventAddCar(car);
            }
            Close();
        }
    }
}

