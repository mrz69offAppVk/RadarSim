namespace Radar
{
    partial class FormTarget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarget));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTargetNum = new System.Windows.Forms.TextBox();
            this.textBoxStartAzimut = new System.Windows.Forms.TextBox();
            this.textBoxStartDistance = new System.Windows.Forms.TextBox();
            this.groupBoxPolarInfo = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEndAzimut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEndDistance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBoxTarget = new System.Windows.Forms.PictureBox();
            this.buttonAddTarget = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBoxPolarInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Азимут ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дальность";
            // 
            // textBoxTargetNum
            // 
            this.textBoxTargetNum.Location = new System.Drawing.Point(6, 19);
            this.textBoxTargetNum.Name = "textBoxTargetNum";
            this.textBoxTargetNum.Size = new System.Drawing.Size(137, 20);
            this.textBoxTargetNum.TabIndex = 6;
            this.textBoxTargetNum.Text = "0";
            this.textBoxTargetNum.TextChanged += new System.EventHandler(this.TextBoxTargetNum_TextChanged);
            // 
            // textBoxStartAzimut
            // 
            this.textBoxStartAzimut.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartAzimut.Name = "textBoxStartAzimut";
            this.textBoxStartAzimut.Size = new System.Drawing.Size(137, 20);
            this.textBoxStartAzimut.TabIndex = 7;
            this.textBoxStartAzimut.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBoxStartDistance
            // 
            this.textBoxStartDistance.Location = new System.Drawing.Point(6, 84);
            this.textBoxStartDistance.Name = "textBoxStartDistance";
            this.textBoxStartDistance.Size = new System.Drawing.Size(137, 20);
            this.textBoxStartDistance.TabIndex = 8;
            this.textBoxStartDistance.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // groupBoxPolarInfo
            // 
            this.groupBoxPolarInfo.Controls.Add(this.textBoxStartAzimut);
            this.groupBoxPolarInfo.Controls.Add(this.label2);
            this.groupBoxPolarInfo.Controls.Add(this.textBoxStartDistance);
            this.groupBoxPolarInfo.Controls.Add(this.label3);
            this.groupBoxPolarInfo.Location = new System.Drawing.Point(12, 63);
            this.groupBoxPolarInfo.Name = "groupBoxPolarInfo";
            this.groupBoxPolarInfo.Size = new System.Drawing.Size(160, 113);
            this.groupBoxPolarInfo.TabIndex = 11;
            this.groupBoxPolarInfo.TabStop = false;
            this.groupBoxPolarInfo.Text = "Начало координат";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxEndAzimut);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxEndDistance);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 145);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Конец координат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Растояние : ";
            // 
            // textBoxEndAzimut
            // 
            this.textBoxEndAzimut.Location = new System.Drawing.Point(6, 32);
            this.textBoxEndAzimut.Name = "textBoxEndAzimut";
            this.textBoxEndAzimut.Size = new System.Drawing.Size(137, 20);
            this.textBoxEndAzimut.TabIndex = 7;
            this.textBoxEndAzimut.TextChanged += new System.EventHandler(this.TextBoxEndAzimut_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Азимут ";
            // 
            // textBoxEndDistance
            // 
            this.textBoxEndDistance.Location = new System.Drawing.Point(6, 84);
            this.textBoxEndDistance.Name = "textBoxEndDistance";
            this.textBoxEndDistance.Size = new System.Drawing.Size(137, 20);
            this.textBoxEndDistance.TabIndex = 8;
            this.textBoxEndDistance.TextChanged += new System.EventHandler(this.TextBoxEndDistance_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дальность";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxSpeed);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 184);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Принадлежность";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(5, 141);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Высота полета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Скорость полета км/ч";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(6, 75);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(137, 20);
            this.textBoxSpeed.TabIndex = 15;
            this.textBoxSpeed.Text = "1000";
            this.textBoxSpeed.TextChanged += new System.EventHandler(this.TextBoxSpeed_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Чужой";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Свой";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // pictureBoxTarget
            // 
            this.pictureBoxTarget.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxTarget.Location = new System.Drawing.Point(178, 12);
            this.pictureBoxTarget.Name = "pictureBoxTarget";
            this.pictureBoxTarget.Size = new System.Drawing.Size(550, 559);
            this.pictureBoxTarget.TabIndex = 0;
            this.pictureBoxTarget.TabStop = false;
            this.pictureBoxTarget.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxTarget_Paint);
            this.pictureBoxTarget.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTarget_MouseClick);
            // 
            // buttonAddTarget
            // 
            this.buttonAddTarget.Location = new System.Drawing.Point(12, 548);
            this.buttonAddTarget.Name = "buttonAddTarget";
            this.buttonAddTarget.Size = new System.Drawing.Size(160, 23);
            this.buttonAddTarget.TabIndex = 18;
            this.buttonAddTarget.Text = "Добавить объект ";
            this.buttonAddTarget.UseVisualStyleBackColor = true;
            this.buttonAddTarget.Click += new System.EventHandler(this.ButtonAddTarget_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxTargetNum);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(160, 45);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Порядковый номер";
            // 
            // FormTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 596);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBoxTarget);
            this.Controls.Add(this.buttonAddTarget);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxPolarInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTarget";
            this.Text = "Новый объект";
            this.groupBoxPolarInfo.ResumeLayout(false);
            this.groupBoxPolarInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTarget)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTargetNum;
        private System.Windows.Forms.TextBox textBoxStartAzimut;
        private System.Windows.Forms.TextBox textBoxStartDistance;
        private System.Windows.Forms.GroupBox groupBoxPolarInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxEndAzimut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEndDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxTarget;
        private System.Windows.Forms.Button buttonAddTarget;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
    }
}