namespace Radar
{
    partial class RadarForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadarForm));
            this.pictureBoxF1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxScaleLayout = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxSpeedLayout = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.groupBoxViewInfoLayout = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxF1)).BeginInit();
            this.groupBoxScaleLayout.SuspendLayout();
            this.groupBoxSpeedLayout.SuspendLayout();
            this.groupBoxViewInfoLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxF1
            // 
            this.pictureBoxF1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxF1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxF1.Name = "pictureBoxF1";
            this.pictureBoxF1.Size = new System.Drawing.Size(898, 609);
            this.pictureBoxF1.TabIndex = 0;
            this.pictureBoxF1.TabStop = false;
            this.pictureBoxF1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxF1_Paint);
            this.pictureBoxF1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxF1_MouseMove);
            this.pictureBoxF1.Resize += new System.EventHandler(this.PictureBox1_Resize);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(752, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBoxScaleLayout
            // 
            this.groupBoxScaleLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxScaleLayout.BackColor = System.Drawing.Color.Black;
            this.groupBoxScaleLayout.Controls.Add(this.radioButton2);
            this.groupBoxScaleLayout.Controls.Add(this.radioButton1);
            this.groupBoxScaleLayout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxScaleLayout.Location = new System.Drawing.Point(752, 53);
            this.groupBoxScaleLayout.Name = "groupBoxScaleLayout";
            this.groupBoxScaleLayout.Size = new System.Drawing.Size(134, 44);
            this.groupBoxScaleLayout.TabIndex = 6;
            this.groupBoxScaleLayout.TabStop = false;
            this.groupBoxScaleLayout.Text = "Масштаб";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(72, 17);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "150";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "75";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // groupBoxSpeedLayout
            // 
            this.groupBoxSpeedLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSpeedLayout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxSpeedLayout.Controls.Add(this.radioButton4);
            this.groupBoxSpeedLayout.Controls.Add(this.radioButton3);
            this.groupBoxSpeedLayout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxSpeedLayout.Location = new System.Drawing.Point(752, 103);
            this.groupBoxSpeedLayout.Name = "groupBoxSpeedLayout";
            this.groupBoxSpeedLayout.Size = new System.Drawing.Size(134, 45);
            this.groupBoxSpeedLayout.TabIndex = 7;
            this.groupBoxSpeedLayout.TabStop = false;
            this.groupBoxSpeedLayout.Text = "Скорость вращения";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(63, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "12 об";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "6 об";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(752, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(798, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(846, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.TabIndex = 16;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(752, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 36);
            this.button5.TabIndex = 14;
            this.button5.Text = "Налет";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBoxViewInfoLayout
            // 
            this.groupBoxViewInfoLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxViewInfoLayout.BackColor = System.Drawing.Color.Black;
            this.groupBoxViewInfoLayout.Controls.Add(this.checkBox3);
            this.groupBoxViewInfoLayout.Controls.Add(this.checkBox2);
            this.groupBoxViewInfoLayout.Controls.Add(this.checkBox1);
            this.groupBoxViewInfoLayout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxViewInfoLayout.Location = new System.Drawing.Point(752, 154);
            this.groupBoxViewInfoLayout.Name = "groupBoxViewInfoLayout";
            this.groupBoxViewInfoLayout.Size = new System.Drawing.Size(134, 95);
            this.groupBoxViewInfoLayout.TabIndex = 17;
            this.groupBoxViewInfoLayout.TabStop = false;
            this.groupBoxViewInfoLayout.Text = "Показать";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(88, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Координаты";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Номер";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Маршрут";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(752, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 36);
            this.button6.TabIndex = 18;
            this.button6.Text = "Стоп";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(752, 373);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 36);
            this.button7.TabIndex = 19;
            this.button7.Text = "Фото";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // RadarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 609);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBoxViewInfoLayout);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxSpeedLayout);
            this.Controls.Add(this.groupBoxScaleLayout);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxF1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadarForm";
            this.Text = "Radar";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxF1)).EndInit();
            this.groupBoxScaleLayout.ResumeLayout(false);
            this.groupBoxScaleLayout.PerformLayout();
            this.groupBoxSpeedLayout.ResumeLayout(false);
            this.groupBoxSpeedLayout.PerformLayout();
            this.groupBoxViewInfoLayout.ResumeLayout(false);
            this.groupBoxViewInfoLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxF1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxScaleLayout;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxSpeedLayout;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBoxViewInfoLayout;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button7;
    }
}

