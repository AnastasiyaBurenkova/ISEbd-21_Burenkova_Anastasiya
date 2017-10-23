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
    public partial class Form2 : Form

    {
        Parking parking;

        public Form2()
        {
            InitializeComponent();
            parking = new Parking(5);
            //заполнение listBox
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }
        /// <summary>
        /// Метод для отрисовки уровня парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking.Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        
      
        /// <summary>
        /// Забираем машину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void buttonDown_Click_1(object sender, EventArgs e)
        {
            parking.LevelDown();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click_1(object sender, EventArgs e)
        {
            parking.LevelUp();
            listBoxLevels.SelectedIndex = parking.getCurrentLevel;
            Draw();
        }

        private void buttonSetCar_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var car = new Car(100, 4, 1000, 13, dialog.Color);
                int place = parking.PutCarInParking(car);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }
        }

        private void buttonSetGru_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var car = new Gruzovik(100, 4, 1000, 13, dialog.Color, true, true, true, dialogDop.Color);
                    int place = parking.PutCarInParking(car);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void buttonTakeCar_Click_1(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    ITransport car = parking.GetCarInParking(Convert.ToInt32(maskedTextBox1.Text));
                    if (car != null)
                    {//если удалось забрать, то отрисовываем
                        Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.setPosition(5, 50);
                        car.drawCar(gr);
                        pictureBoxTakeCar.Image = bmp;
                        Draw();
                    }
                    else
                    {//иначе сообщаем об этом
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }
                }
            }
        
        }
    }
}
