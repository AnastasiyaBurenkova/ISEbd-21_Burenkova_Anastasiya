using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class FormKitchen : System.Windows.Forms.Form
    {
        private Potato[] potato;
        private Perez[] perez;
        private Kabach[] kabach;

        private Priprava priprava;
        private Maslo maslo;

        private WaterTap waterTap;

        private Knife knife;

        private Pan pan;

        private Stove stove;

        public FormKitchen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция, вызываемая при загрузки формы
        /// инициализурем здесь некоторые элементы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKitchen_Load(object sender, EventArgs e)
        {
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
        }
       
        
        private void checkBoxOn_CheckedChanged(object sender, EventArgs e)
        {
            stove = new Stove();
            stove.State = checkBoxOn.Checked;
        }
        
       
        private void buttonWash_Click_1(object sender, EventArgs e)
        {
            if (numericUpDownPotato.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potato = new Potato[Convert.ToInt32(numericUpDownPotato.Value)];
                //pan = new Pan();
                //pan.Init(Convert.ToInt32(numericUpDownPotato.Value));
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i] = new Potato();
                }
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i].Dirty_potato = 0;
                }
                numericUpDownPotato.Enabled = false;
                //radioButtonClose.Checked = true;
                MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonOpen_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                waterTap = new WaterTap();
                waterTap.State = true;
            }
        }

       // private void radioButtonClose_CheckedChanged_1(object sender, EventArgs e)
      //  {
        //    if (radioButtonClose.Checked)
         //   {
           //     waterTap.State = false;
          //  }
       // }

        private void buttonWash2_Click_1(object sender, EventArgs e)
        {
            if (numericUpDownPerez.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                perez = new Perez[Convert.ToInt32(numericUpDownPerez.Value)];
              //  pan.Init(Convert.ToInt32(numericUpDownPerez.Value));
                for (int i = 0; i < perez.Length; ++i)
                {
                    perez[i] = new Perez();
                }
                for (int i = 0; i < perez.Length; ++i)
                {
                    perez[i].Dirty_perez = 0;
                }
                numericUpDownPerez.Enabled = false;
                //radioButtonClose.Checked = true;
                MessageBox.Show("Перец помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Перца то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWash3_Click_1(object sender, EventArgs e)
        {
            if (numericUpDownKabach.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                kabach = new Kabach[Convert.ToInt32(numericUpDownKabach.Value)];
              //  pan.Init(Convert.ToInt32(numericUpDownKabach.Value));
                for (int i = 0; i < kabach.Length; ++i)
                {
                    kabach[i] = new Kabach();
                }
                for (int i = 0; i < kabach.Length; ++i)
                {
                    kabach[i].Dirty_kabach = 0;
                }
                numericUpDownKabach.Enabled = false;
               // radioButtonClose.Checked = true;
                MessageBox.Show("Кабачок помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Кабачка то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearPotato_Click_1(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i].Dirty_potato > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Помыть бы ее сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                knife = new Knife();
                knife.Clean_and_res(potato[i]);
            }
            buttonClearPotato.Enabled = true;
            MessageBox.Show("Картошку помыли, можно кидать в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClearPerez_Click_1(object sender, EventArgs e)
        {
            if (perez == null)
            {
                MessageBox.Show("Перца то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (perez.Length == 0)
            {
                MessageBox.Show("Перца то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < perez.Length; ++i)
            {
                if (perez[i].Dirty_perez > 0)
                {
                    MessageBox.Show("Перец грязный!!! Помыть бы его сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < perez.Length; ++i)
            {
                knife.Clean_and_res2(perez[i]);
            }
            buttonClearPerez.Enabled = true;
            MessageBox.Show("Перец помыли, можно кидать в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonClearKabach_Click_1(object sender, EventArgs e)
        {
            if (kabach == null)
            {
                MessageBox.Show("Кабачка то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kabach.Length == 0)
            {
                MessageBox.Show("Кабачка то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < kabach.Length; ++i)
            {
                if (kabach[i].Dirty_kabach > 0)
                {
                    MessageBox.Show("Кабачок грязный!!! Помыть бы его сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < kabach.Length; ++i)
            {
                knife.Clean_and_res3(kabach[i]);
            }
            buttonClearKabach.Enabled = true;
            MessageBox.Show("Кабачок помыли, можно кидать в кастрюлю", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonAddMaslo_Click_1(object sender, EventArgs e)
        {
            buttonAddPriprava.Enabled = true;
           // radioButtonClose.Checked = true;
            MessageBox.Show("Масло залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddPriprava_Click_1(object sender, EventArgs e)
        {
            priprava = new Priprava();
            priprava.Count = Convert.ToInt32(numericUpDownPriprava.Value);
            if (priprava.Count > 0)
            {
                pan = new Pan();
                pan.AddPriprava(priprava);
                MessageBox.Show("Приправу добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Приправы же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddPotato_Click_1(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i].Dirty_potato > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (potato[i].Have_skin_potato)
                {
                    MessageBox.Show("У нас обычная картошка, не в мундире. Надо почистить!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                pan = new Pan();
                pan.AddPotato(potato[i]);
            }
            buttonAddPan.Enabled = true;
            MessageBox.Show("Картошку положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPerez_Click(object sender, EventArgs e)
        {
            if (perez == null)
            {
                MessageBox.Show("Перца то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (perez.Length == 0)
            {
                MessageBox.Show("Перца то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < perez.Length; ++i)
            {
                if (perez[i].Dirty_perez > 0)
                {
                    MessageBox.Show("Перец грязный!!! Какой его варить, а ну мыть его быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (perez[i].Have_skin_perez)
                {
                    MessageBox.Show("У нас обычный перец, не в мундире. Надо почистить!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < perez.Length; ++i)
            {
                pan.AddPerez(perez[i]);
            }
            buttonAddPan.Enabled = true;
            MessageBox.Show("Перец положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddKabach_Click_1(object sender, EventArgs e)
        {
            if (kabach == null)
            {
                MessageBox.Show("Кабачка то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (kabach.Length == 0)
            {
                MessageBox.Show("Кабачка то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < kabach.Length; ++i)
            {
                if (kabach[i].Dirty_kabach > 0)
                {
                    MessageBox.Show("Кабачок грязный!!! Какой его варить, а ну мыть его быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (kabach[i].Have_skin_kabach)
                {
                    MessageBox.Show("У нас обычный кабачок, не в мундире. Надо почистить!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < kabach.Length; ++i)
            {
                pan.AddKabach(kabach[i]);
            }
            buttonAddPan.Enabled = true;
            MessageBox.Show("Кабачок положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddPan_Click_1(object sender, EventArgs e)
        {
            stove.Pan = pan;
            buttonCook.Enabled = true;
            MessageBox.Show("Кастрюлька на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCook_Click_1(object sender, EventArgs e)
        {
            if (!stove.Pan.ReadyToGo)
            {
                MessageBox.Show("У нас не все готово к варке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Варить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (stove.Pan.IsReady())
            {
                //buttonGetPan.Enabled = true;
                checkBoxOn.Checked = false;
                MessageBox.Show("Сварилась!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, овощное рагу не сварилась", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
    }
}