namespace WindowsFormsApplication18
{
    partial class Form1
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
            this.pictureBoxDraw = new System.Windows.Forms.PictureBox();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBoxMaxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMaxCountPassenget = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.checkBoxFrontSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxBackSpoiler = new System.Windows.Forms.CheckBox();
            this.checkBoxSideSpoiler = new System.Windows.Forms.CheckBox();
            this.buttonSetAuto = new System.Windows.Forms.Button();
            this.buttonSetSportSedan = new System.Windows.Forms.Button();
            this.buttonSetGruzovik = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxСapacity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDraw
            // 
            this.pictureBoxDraw.InitialImage = null;
            this.pictureBoxDraw.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxDraw.Name = "pictureBoxDraw";
            this.pictureBoxDraw.Size = new System.Drawing.Size(539, 301);
            this.pictureBoxDraw.TabIndex = 0;
            this.pictureBoxDraw.TabStop = false;

            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(267, 394);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectColor.TabIndex = 1;
            this.buttonSelectColor.Text = "Color";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.Location = new System.Drawing.Point(487, 394);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDopColor.TabIndex = 2;
            this.buttonSelectDopColor.Text = "Color";
            this.buttonSelectDopColor.UseVisualStyleBackColor = true;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // textBoxMaxSpeed
            // 
            this.textBoxMaxSpeed.Location = new System.Drawing.Point(95, 310);
            this.textBoxMaxSpeed.Name = "textBoxMaxSpeed";
            this.textBoxMaxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxSpeed.TabIndex = 3;
            // 
            // textBoxMaxCountPassenget
            // 
            this.textBoxMaxCountPassenget.Location = new System.Drawing.Point(159, 346);
            this.textBoxMaxCountPassenget.Name = "textBoxMaxCountPassenget";
            this.textBoxMaxCountPassenget.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxCountPassenget.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(45, 369);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 5;
            // 
            // checkBoxFrontSpoiler
            // 
            this.checkBoxFrontSpoiler.AutoSize = true;
            this.checkBoxFrontSpoiler.Location = new System.Drawing.Point(379, 313);
            this.checkBoxFrontSpoiler.Name = "checkBoxFrontSpoiler";
            this.checkBoxFrontSpoiler.Size = new System.Drawing.Size(65, 17);
            this.checkBoxFrontSpoiler.TabIndex = 6;
            this.checkBoxFrontSpoiler.Text = "Бампер";
            this.checkBoxFrontSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackSpoiler
            // 
            this.checkBoxBackSpoiler.AutoSize = true;
            this.checkBoxBackSpoiler.Location = new System.Drawing.Point(379, 345);
            this.checkBoxBackSpoiler.Name = "checkBoxBackSpoiler";
            this.checkBoxBackSpoiler.Size = new System.Drawing.Size(59, 17);
            this.checkBoxBackSpoiler.TabIndex = 7;
            this.checkBoxBackSpoiler.Text = "Кузов ";
            this.checkBoxBackSpoiler.UseVisualStyleBackColor = true;
            // 
            // checkBoxSideSpoiler
            // 
            this.checkBoxSideSpoiler.AutoSize = true;
            this.checkBoxSideSpoiler.Location = new System.Drawing.Point(379, 376);
            this.checkBoxSideSpoiler.Name = "checkBoxSideSpoiler";
            this.checkBoxSideSpoiler.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSideSpoiler.TabIndex = 8;
            this.checkBoxSideSpoiler.Text = "Колеса";
            this.checkBoxSideSpoiler.UseVisualStyleBackColor = true;
            // 
            // buttonSetAuto
            // 
            this.buttonSetAuto.Location = new System.Drawing.Point(596, 25);
            this.buttonSetAuto.Name = "buttonSetAuto";
            this.buttonSetAuto.Size = new System.Drawing.Size(127, 41);
            this.buttonSetAuto.TabIndex = 9;
            this.buttonSetAuto.Text = "Задать авто";
            this.buttonSetAuto.UseVisualStyleBackColor = true;
            this.buttonSetAuto.Click += new System.EventHandler(this.buttonSetAuto_Click);
            // 
            // buttonSetSportSedan
            // 
            this.buttonSetSportSedan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSetSportSedan.Location = new System.Drawing.Point(596, 100);
            this.buttonSetSportSedan.Name = "buttonSetSportSedan";
            this.buttonSetSportSedan.Size = new System.Drawing.Size(127, 40);
            this.buttonSetSportSedan.TabIndex = 10;
            this.buttonSetSportSedan.Text = "Задать Грузовой автомобиль ";
            this.buttonSetSportSedan.UseVisualStyleBackColor = true;
            this.buttonSetSportSedan.Click += new System.EventHandler(this.buttonSetSportSedan_Click);
            // 
            // buttonSetGruzovik
            // 
            this.buttonSetGruzovik.Location = new System.Drawing.Point(596, 173);
            this.buttonSetGruzovik.Name = "buttonSetGruzovik";
            this.buttonSetGruzovik.Size = new System.Drawing.Size(127, 38);
            this.buttonSetGruzovik.TabIndex = 11;
            this.buttonSetGruzovik.Text = "Задать Грузовик";
            this.buttonSetGruzovik.UseVisualStyleBackColor = true;
            this.buttonSetGruzovik.Click += new System.EventHandler(this.buttonSetGruzovik_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(596, 246);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(127, 43);
            this.buttonMove.TabIndex = 12;
            this.buttonMove.Text = "Движение";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Max скорость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Max кол-во пассажиров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Груз";
            // 
            // textBoxСapacity
            // 
            this.textBoxСapacity.Location = new System.Drawing.Point(50, 403);
            this.textBoxСapacity.Name = "textBoxСapacity";
            this.textBoxСapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxСapacity.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 429);
            this.Controls.Add(this.textBoxСapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonSetGruzovik);
            this.Controls.Add(this.buttonSetSportSedan);
            this.Controls.Add(this.buttonSetAuto);
            this.Controls.Add(this.checkBoxSideSpoiler);
            this.Controls.Add(this.checkBoxBackSpoiler);
            this.Controls.Add(this.checkBoxFrontSpoiler);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxMaxCountPassenget);
            this.Controls.Add(this.textBoxMaxSpeed);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.pictureBoxDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDraw;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.TextBox textBoxMaxSpeed;
        private System.Windows.Forms.TextBox textBoxMaxCountPassenget;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.CheckBox checkBoxFrontSpoiler;
        private System.Windows.Forms.CheckBox checkBoxBackSpoiler;
        private System.Windows.Forms.CheckBox checkBoxSideSpoiler;
        private System.Windows.Forms.Button buttonSetAuto;
        private System.Windows.Forms.Button buttonSetSportSedan;
        private System.Windows.Forms.Button buttonSetGruzovik;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxСapacity;
    }
}