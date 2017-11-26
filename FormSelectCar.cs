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


        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        ITransport car = null;
        /// <summary>
        /// Получить машину
        /// </summary>
        public ITransport getCar { get { return car; } }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
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
        /// <summary>
        /// Событие
        /// </summary>
        private event myDel eventAddCar;
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
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
        /// <summary>
        /// Готовимся к перетаскиванию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelCar.DoDragDrop(labelCar.Text,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Готовимся к перетаскиванию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGruzovik_MouseDown(object sender, MouseEventArgs e)
        {
            labelGruzovik.DoDragDrop(labelGruzovik.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверяем, что мы принимаем (мы не всеядные)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// Принимаем то, что перетаскивали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {//случаным образом выбриаем какая машина встанет
                case "Car":
                    car = new Car(100, 4, 3, 500, Color.Black);
                    break;
                case "Gruzovik":
                    car = new Gruzovik(100, 4, 3, 500, Color.Black, true, true, true, Color.Black);
                    break;
            }
            DrawCar();
        }
        /// <summary>
        /// Перетаскиваем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Готовимся к приему
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// Принимаем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }
        /// <summary>
        /// Принимаем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        

        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

    }
}

