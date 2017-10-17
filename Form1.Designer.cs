using System;

namespace WindowsFormsApplication16
{
    partial class FormKitchen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonWash = new System.Windows.Forms.Button();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPotato = new System.Windows.Forms.NumericUpDown();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPriprava = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownPerez = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKabach = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonWash2 = new System.Windows.Forms.Button();
            this.buttonWash3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClearPotato = new System.Windows.Forms.Button();
            this.buttonClearPerez = new System.Windows.Forms.Button();
            this.buttonClearKabach = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddPan = new System.Windows.Forms.Button();
            this.buttonCook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddMaslo = new System.Windows.Forms.Button();
            this.buttonAddPotato = new System.Windows.Forms.Button();
            this.buttonAddPriprava = new System.Windows.Forms.Button();
            this.buttonPerez = new System.Windows.Forms.Button();
            this.buttonAddKabach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriprava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKabach)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWash
            // 
            this.buttonWash.Location = new System.Drawing.Point(443, 12);
            this.buttonWash.Name = "buttonWash";
            this.buttonWash.Size = new System.Drawing.Size(87, 48);
            this.buttonWash.TabIndex = 0;
            this.buttonWash.Text = "Помыть картошку";
            this.buttonWash.UseVisualStyleBackColor = true;
            this.buttonWash.Click += new System.EventHandler(this.buttonWash_Click_1);
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.Location = new System.Drawing.Point(204, 211);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(45, 17);
            this.checkBoxOn.TabIndex = 1;
            this.checkBoxOn.Text = "Вкл";
            this.checkBoxOn.UseVisualStyleBackColor = true;
            this.checkBoxOn.CheckedChanged += new System.EventHandler(this.checkBoxOn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ингридиенты";
            // 
            // numericUpDownPotato
            // 
            this.numericUpDownPotato.Location = new System.Drawing.Point(105, 51);
            this.numericUpDownPotato.Name = "numericUpDownPotato";
            this.numericUpDownPotato.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownPotato.TabIndex = 3;
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(333, 51);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(63, 17);
            this.radioButtonOpen.TabIndex = 4;
            this.radioButtonOpen.TabStop = true;
            this.radioButtonOpen.Text = "Открыт";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Картошка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Приправа";
            // 
            // numericUpDownPriprava
            // 
            this.numericUpDownPriprava.Location = new System.Drawing.Point(105, 79);
            this.numericUpDownPriprava.Name = "numericUpDownPriprava";
            this.numericUpDownPriprava.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownPriprava.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Перец";
            // 
            // numericUpDownPerez
            // 
            this.numericUpDownPerez.Location = new System.Drawing.Point(105, 108);
            this.numericUpDownPerez.Name = "numericUpDownPerez";
            this.numericUpDownPerez.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownPerez.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кабачок";
            // 
            // numericUpDownKabach
            // 
            this.numericUpDownKabach.Location = new System.Drawing.Point(105, 138);
            this.numericUpDownKabach.Name = "numericUpDownKabach";
            this.numericUpDownKabach.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownKabach.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кран";
            // 
            // buttonWash2
            // 
            this.buttonWash2.Location = new System.Drawing.Point(443, 61);
            this.buttonWash2.Name = "buttonWash2";
            this.buttonWash2.Size = new System.Drawing.Size(87, 48);
            this.buttonWash2.TabIndex = 15;
            this.buttonWash2.Text = "Помыть перец";
            this.buttonWash2.UseVisualStyleBackColor = true;
            this.buttonWash2.Click += new System.EventHandler(this.buttonWash2_Click_1);
            // 
            // buttonWash3
            // 
            this.buttonWash3.Location = new System.Drawing.Point(443, 115);
            this.buttonWash3.Name = "buttonWash3";
            this.buttonWash3.Size = new System.Drawing.Size(87, 43);
            this.buttonWash3.TabIndex = 16;
            this.buttonWash3.Text = "Помыть кабачок";
            this.buttonWash3.UseVisualStyleBackColor = true;
            this.buttonWash3.Click += new System.EventHandler(this.buttonWash3_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(709, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Нож";
            // 
            // buttonClearPotato
            // 
            this.buttonClearPotato.Location = new System.Drawing.Point(709, 41);
            this.buttonClearPotato.Name = "buttonClearPotato";
            this.buttonClearPotato.Size = new System.Drawing.Size(142, 36);
            this.buttonClearPotato.TabIndex = 18;
            this.buttonClearPotato.Text = "Почистить и порезать картошку";
            this.buttonClearPotato.UseVisualStyleBackColor = true;
            this.buttonClearPotato.Click += new System.EventHandler(this.buttonClearPotato_Click_1);
            // 
            // buttonClearPerez
            // 
            this.buttonClearPerez.Location = new System.Drawing.Point(709, 87);
            this.buttonClearPerez.Name = "buttonClearPerez";
            this.buttonClearPerez.Size = new System.Drawing.Size(142, 41);
            this.buttonClearPerez.TabIndex = 19;
            this.buttonClearPerez.Text = "Почистить и порезать перец";
            this.buttonClearPerez.UseVisualStyleBackColor = true;
            this.buttonClearPerez.Click += new System.EventHandler(this.buttonClearPerez_Click_1);
            // 
            // buttonClearKabach
            // 
            this.buttonClearKabach.Location = new System.Drawing.Point(709, 140);
            this.buttonClearKabach.Name = "buttonClearKabach";
            this.buttonClearKabach.Size = new System.Drawing.Size(142, 41);
            this.buttonClearKabach.TabIndex = 20;
            this.buttonClearKabach.Text = "Почистить и порезать кабачок";
            this.buttonClearKabach.UseVisualStyleBackColor = true;
            this.buttonClearKabach.Click += new System.EventHandler(this.buttonClearKabach_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Плита";
            // 
            // buttonAddPan
            // 
            this.buttonAddPan.Location = new System.Drawing.Point(194, 234);
            this.buttonAddPan.Name = "buttonAddPan";
            this.buttonAddPan.Size = new System.Drawing.Size(87, 34);
            this.buttonAddPan.TabIndex = 22;
            this.buttonAddPan.Text = "Поставить кастрюлю";
            this.buttonAddPan.UseVisualStyleBackColor = true;
            this.buttonAddPan.Click += new System.EventHandler(this.buttonAddPan_Click_1);
            // 
            // buttonCook
            // 
            this.buttonCook.Location = new System.Drawing.Point(194, 274);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(87, 23);
            this.buttonCook.TabIndex = 23;
            this.buttonCook.Text = "Готовить";
            this.buttonCook.UseVisualStyleBackColor = true;
            this.buttonCook.Click += new System.EventHandler(this.buttonCook_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Кастрюля";
            // 
            // buttonAddMaslo
            // 
            this.buttonAddMaslo.Location = new System.Drawing.Point(486, 220);
            this.buttonAddMaslo.Name = "buttonAddMaslo";
            this.buttonAddMaslo.Size = new System.Drawing.Size(89, 36);
            this.buttonAddMaslo.TabIndex = 26;
            this.buttonAddMaslo.Text = "Залить масло";
            this.buttonAddMaslo.UseVisualStyleBackColor = true;
            this.buttonAddMaslo.Click += new System.EventHandler(this.buttonAddMaslo_Click_1);
            // 
            // buttonAddPotato
            // 
            this.buttonAddPotato.Location = new System.Drawing.Point(486, 262);
            this.buttonAddPotato.Name = "buttonAddPotato";
            this.buttonAddPotato.Size = new System.Drawing.Size(89, 35);
            this.buttonAddPotato.TabIndex = 27;
            this.buttonAddPotato.Text = "Добавить картошку";
            this.buttonAddPotato.UseVisualStyleBackColor = true;
            this.buttonAddPotato.Click += new System.EventHandler(this.buttonAddPotato_Click_1);
            // 
            // buttonAddPriprava
            // 
            this.buttonAddPriprava.Location = new System.Drawing.Point(486, 306);
            this.buttonAddPriprava.Name = "buttonAddPriprava";
            this.buttonAddPriprava.Size = new System.Drawing.Size(89, 35);
            this.buttonAddPriprava.TabIndex = 28;
            this.buttonAddPriprava.Text = "Добавить приправу";
            this.buttonAddPriprava.UseVisualStyleBackColor = true;
            this.buttonAddPriprava.Click += new System.EventHandler(this.buttonAddPriprava_Click_1);
            // 
            // buttonPerez
            // 
            this.buttonPerez.Location = new System.Drawing.Point(619, 274);
            this.buttonPerez.Name = "buttonPerez";
            this.buttonPerez.Size = new System.Drawing.Size(84, 42);
            this.buttonPerez.TabIndex = 29;
            this.buttonPerez.Text = "Добавить перец";
            this.buttonPerez.UseVisualStyleBackColor = true;
            this.buttonPerez.Click += new System.EventHandler(this.buttonPerez_Click);
            // 
            // buttonAddKabach
            // 
            this.buttonAddKabach.Location = new System.Drawing.Point(619, 333);
            this.buttonAddKabach.Name = "buttonAddKabach";
            this.buttonAddKabach.Size = new System.Drawing.Size(84, 39);
            this.buttonAddKabach.TabIndex = 30;
            this.buttonAddKabach.Text = "Добавить кабачок";
            this.buttonAddKabach.UseVisualStyleBackColor = true;
            this.buttonAddKabach.Click += new System.EventHandler(this.buttonAddKabach_Click_1);
            // 
            // FormKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 436);
            this.Controls.Add(this.buttonAddKabach);
            this.Controls.Add(this.buttonPerez);
            this.Controls.Add(this.buttonAddPriprava);
            this.Controls.Add(this.buttonAddPotato);
            this.Controls.Add(this.buttonAddMaslo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonCook);
            this.Controls.Add(this.buttonAddPan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonClearKabach);
            this.Controls.Add(this.buttonClearPerez);
            this.Controls.Add(this.buttonClearPotato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonWash3);
            this.Controls.Add(this.buttonWash2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownKabach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownPerez);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPriprava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonOpen);
            this.Controls.Add(this.numericUpDownPotato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxOn);
            this.Controls.Add(this.buttonWash);
            this.HelpButton = true;
            this.Name = "FormKitchen";
            this.Text = "Кухня";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPotato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriprava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPerez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKabach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button buttonWash;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPotato;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPriprava;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownPerez;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownKabach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonWash2;
        private System.Windows.Forms.Button buttonWash3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonClearPotato;
        private System.Windows.Forms.Button buttonClearPerez;
        private System.Windows.Forms.Button buttonClearKabach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddPan;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddMaslo;
        private System.Windows.Forms.Button buttonAddPotato;
        private System.Windows.Forms.Button buttonAddPriprava;
        private System.Windows.Forms.Button buttonPerez;
        private System.Windows.Forms.Button buttonAddKabach;

        public EventHandler label1_Click { get; private set; }
    }
}

