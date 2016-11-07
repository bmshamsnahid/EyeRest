namespace Eye_Rest_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textBox_hourInput = new System.Windows.Forms.TextBox();
            this.textBox_minuteInput = new System.Windows.Forms.TextBox();
            this.textBox_secondInput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton_showTextBox = new System.Windows.Forms.RadioButton();
            this.radioButton_showComboBox = new System.Windows.Forms.RadioButton();
            this.comboBox_hourInput = new System.Windows.Forms.ComboBox();
            this.comboBox_minuteInput = new System.Windows.Forms.ComboBox();
            this.comboBox_secondInput = new System.Windows.Forms.ComboBox();
            this.timer_timer = new System.Windows.Forms.Timer(this.components);
            this.textBox_timeLeftHour = new System.Windows.Forms.TextBox();
            this.textBox_timeLeftMinute = new System.Windows.Forms.TextBox();
            this.textBox_timeLeftSecond = new System.Windows.Forms.TextBox();
            this.timer_showing_logo_image = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_time_left = new System.Windows.Forms.PictureBox();
            this.pictureBox_enter_time = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.button_playTimer = new System.Windows.Forms.Button();
            this.button_pauseTimer = new System.Windows.Forms.Button();
            this.button_restart = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.pictureBox_second = new System.Windows.Forms.PictureBox();
            this.pictureBoxminute = new System.Windows.Forms.PictureBox();
            this.pictureBox_hour = new System.Windows.Forms.PictureBox();
            this.button_stopSound = new System.Windows.Forms.Button();
            this.button_startTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_time_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_enter_time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hour)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_hourInput
            // 
            this.textBox_hourInput.Location = new System.Drawing.Point(4, 59);
            this.textBox_hourInput.Name = "textBox_hourInput";
            this.textBox_hourInput.Size = new System.Drawing.Size(75, 20);
            this.textBox_hourInput.TabIndex = 2;
            // 
            // textBox_minuteInput
            // 
            this.textBox_minuteInput.Location = new System.Drawing.Point(85, 59);
            this.textBox_minuteInput.Name = "textBox_minuteInput";
            this.textBox_minuteInput.Size = new System.Drawing.Size(75, 20);
            this.textBox_minuteInput.TabIndex = 3;
            // 
            // textBox_secondInput
            // 
            this.textBox_secondInput.Location = new System.Drawing.Point(166, 59);
            this.textBox_secondInput.Name = "textBox_secondInput";
            this.textBox_secondInput.Size = new System.Drawing.Size(75, 20);
            this.textBox_secondInput.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 13);
            this.listBox1.TabIndex = 5;
            // 
            // radioButton_showTextBox
            // 
            this.radioButton_showTextBox.AutoSize = true;
            this.radioButton_showTextBox.Location = new System.Drawing.Point(6, 108);
            this.radioButton_showTextBox.Name = "radioButton_showTextBox";
            this.radioButton_showTextBox.Size = new System.Drawing.Size(63, 17);
            this.radioButton_showTextBox.TabIndex = 6;
            this.radioButton_showTextBox.TabStop = true;
            this.radioButton_showTextBox.Text = "Textbox";
            this.radioButton_showTextBox.UseVisualStyleBackColor = true;
            this.radioButton_showTextBox.CheckedChanged += new System.EventHandler(this.radioButton_showTextBox_CheckedChanged);
            // 
            // radioButton_showComboBox
            // 
            this.radioButton_showComboBox.AutoSize = true;
            this.radioButton_showComboBox.Location = new System.Drawing.Point(75, 108);
            this.radioButton_showComboBox.Name = "radioButton_showComboBox";
            this.radioButton_showComboBox.Size = new System.Drawing.Size(98, 17);
            this.radioButton_showComboBox.TabIndex = 7;
            this.radioButton_showComboBox.TabStop = true;
            this.radioButton_showComboBox.Text = "Drop Down List";
            this.radioButton_showComboBox.UseVisualStyleBackColor = true;
            this.radioButton_showComboBox.CheckedChanged += new System.EventHandler(this.radioButton_showComboBox_CheckedChanged);
            // 
            // comboBox_hourInput
            // 
            this.comboBox_hourInput.FormattingEnabled = true;
            this.comboBox_hourInput.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox_hourInput.Location = new System.Drawing.Point(4, 58);
            this.comboBox_hourInput.Name = "comboBox_hourInput";
            this.comboBox_hourInput.Size = new System.Drawing.Size(75, 21);
            this.comboBox_hourInput.TabIndex = 8;
            // 
            // comboBox_minuteInput
            // 
            this.comboBox_minuteInput.FormattingEnabled = true;
            this.comboBox_minuteInput.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboBox_minuteInput.Location = new System.Drawing.Point(85, 58);
            this.comboBox_minuteInput.Name = "comboBox_minuteInput";
            this.comboBox_minuteInput.Size = new System.Drawing.Size(75, 21);
            this.comboBox_minuteInput.TabIndex = 9;
            // 
            // comboBox_secondInput
            // 
            this.comboBox_secondInput.FormattingEnabled = true;
            this.comboBox_secondInput.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.comboBox_secondInput.Location = new System.Drawing.Point(166, 58);
            this.comboBox_secondInput.Name = "comboBox_secondInput";
            this.comboBox_secondInput.Size = new System.Drawing.Size(75, 21);
            this.comboBox_secondInput.TabIndex = 10;
            // 
            // timer_timer
            // 
            this.timer_timer.Tick += new System.EventHandler(this.timer_timer_Tick);
            // 
            // textBox_timeLeftHour
            // 
            this.textBox_timeLeftHour.Location = new System.Drawing.Point(4, 59);
            this.textBox_timeLeftHour.Name = "textBox_timeLeftHour";
            this.textBox_timeLeftHour.Size = new System.Drawing.Size(75, 20);
            this.textBox_timeLeftHour.TabIndex = 15;
            // 
            // textBox_timeLeftMinute
            // 
            this.textBox_timeLeftMinute.Location = new System.Drawing.Point(85, 59);
            this.textBox_timeLeftMinute.Name = "textBox_timeLeftMinute";
            this.textBox_timeLeftMinute.Size = new System.Drawing.Size(75, 20);
            this.textBox_timeLeftMinute.TabIndex = 16;
            // 
            // textBox_timeLeftSecond
            // 
            this.textBox_timeLeftSecond.Location = new System.Drawing.Point(166, 59);
            this.textBox_timeLeftSecond.Name = "textBox_timeLeftSecond";
            this.textBox_timeLeftSecond.Size = new System.Drawing.Size(75, 20);
            this.textBox_timeLeftSecond.TabIndex = 17;
            // 
            // timer_showing_logo_image
            // 
            this.timer_showing_logo_image.Tick += new System.EventHandler(this.timer_showing_logo_image_Tick);
            // 
            // pictureBox_time_left
            // 
            this.pictureBox_time_left.Image = global::Eye_Rest_2.Properties.Resources.image_time_left;
            this.pictureBox_time_left.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_time_left.Name = "pictureBox_time_left";
            this.pictureBox_time_left.Size = new System.Drawing.Size(237, 25);
            this.pictureBox_time_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_time_left.TabIndex = 26;
            this.pictureBox_time_left.TabStop = false;
            // 
            // pictureBox_enter_time
            // 
            this.pictureBox_enter_time.Image = global::Eye_Rest_2.Properties.Resources.image_enter_time;
            this.pictureBox_enter_time.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_enter_time.Name = "pictureBox_enter_time";
            this.pictureBox_enter_time.Size = new System.Drawing.Size(237, 25);
            this.pictureBox_enter_time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_enter_time.TabIndex = 25;
            this.pictureBox_enter_time.TabStop = false;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Eye_Rest_2.Properties.Resources.logo_image;
            this.pictureBox_logo.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(237, 121);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 24;
            this.pictureBox_logo.TabStop = false;
            // 
            // button_playTimer
            // 
            this.button_playTimer.Image = global::Eye_Rest_2.Properties.Resources.image_play;
            this.button_playTimer.Location = new System.Drawing.Point(85, 82);
            this.button_playTimer.Name = "button_playTimer";
            this.button_playTimer.Size = new System.Drawing.Size(75, 23);
            this.button_playTimer.TabIndex = 22;
            this.button_playTimer.UseVisualStyleBackColor = true;
            this.button_playTimer.Click += new System.EventHandler(this.button_playTimer_Click);
            // 
            // button_pauseTimer
            // 
            this.button_pauseTimer.Image = global::Eye_Rest_2.Properties.Resources.image_pause;
            this.button_pauseTimer.Location = new System.Drawing.Point(85, 82);
            this.button_pauseTimer.Name = "button_pauseTimer";
            this.button_pauseTimer.Size = new System.Drawing.Size(75, 23);
            this.button_pauseTimer.TabIndex = 21;
            this.button_pauseTimer.UseVisualStyleBackColor = true;
            this.button_pauseTimer.Click += new System.EventHandler(this.button_pauseTimer_Click);
            // 
            // button_restart
            // 
            this.button_restart.Image = global::Eye_Rest_2.Properties.Resources.image_restart;
            this.button_restart.Location = new System.Drawing.Point(166, 82);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(75, 23);
            this.button_restart.TabIndex = 19;
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // button_reset
            // 
            this.button_reset.Image = global::Eye_Rest_2.Properties.Resources.image_reset;
            this.button_reset.Location = new System.Drawing.Point(4, 82);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 18;
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // pictureBox_second
            // 
            this.pictureBox_second.Image = global::Eye_Rest_2.Properties.Resources.image_second;
            this.pictureBox_second.Location = new System.Drawing.Point(166, 35);
            this.pictureBox_second.Name = "pictureBox_second";
            this.pictureBox_second.Size = new System.Drawing.Size(75, 20);
            this.pictureBox_second.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_second.TabIndex = 13;
            this.pictureBox_second.TabStop = false;
            // 
            // pictureBoxminute
            // 
            this.pictureBoxminute.Image = global::Eye_Rest_2.Properties.Resources.image_minute;
            this.pictureBoxminute.Location = new System.Drawing.Point(85, 35);
            this.pictureBoxminute.Name = "pictureBoxminute";
            this.pictureBoxminute.Size = new System.Drawing.Size(75, 20);
            this.pictureBoxminute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxminute.TabIndex = 12;
            this.pictureBoxminute.TabStop = false;
            // 
            // pictureBox_hour
            // 
            this.pictureBox_hour.Image = global::Eye_Rest_2.Properties.Resources.image_hour;
            this.pictureBox_hour.Location = new System.Drawing.Point(4, 35);
            this.pictureBox_hour.Name = "pictureBox_hour";
            this.pictureBox_hour.Size = new System.Drawing.Size(75, 20);
            this.pictureBox_hour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_hour.TabIndex = 11;
            this.pictureBox_hour.TabStop = false;
            // 
            // button_stopSound
            // 
            this.button_stopSound.Image = global::Eye_Rest_2.Properties.Resources.button_stop;
            this.button_stopSound.Location = new System.Drawing.Point(85, 82);
            this.button_stopSound.Name = "button_stopSound";
            this.button_stopSound.Size = new System.Drawing.Size(75, 23);
            this.button_stopSound.TabIndex = 1;
            this.button_stopSound.UseVisualStyleBackColor = true;
            this.button_stopSound.Click += new System.EventHandler(this.button_stopSound_Click);
            // 
            // button_startTimer
            // 
            this.button_startTimer.Image = global::Eye_Rest_2.Properties.Resources.button_start;
            this.button_startTimer.Location = new System.Drawing.Point(85, 82);
            this.button_startTimer.Name = "button_startTimer";
            this.button_startTimer.Size = new System.Drawing.Size(75, 23);
            this.button_startTimer.TabIndex = 0;
            this.button_startTimer.UseVisualStyleBackColor = true;
            this.button_startTimer.Click += new System.EventHandler(this.button_startTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 127);
            this.Controls.Add(this.pictureBox_time_left);
            this.Controls.Add(this.pictureBox_enter_time);
            this.Controls.Add(this.pictureBox_logo);
            this.Controls.Add(this.button_playTimer);
            this.Controls.Add(this.button_pauseTimer);
            this.Controls.Add(this.button_restart);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_timeLeftSecond);
            this.Controls.Add(this.textBox_timeLeftMinute);
            this.Controls.Add(this.textBox_timeLeftHour);
            this.Controls.Add(this.pictureBox_second);
            this.Controls.Add(this.pictureBoxminute);
            this.Controls.Add(this.pictureBox_hour);
            this.Controls.Add(this.comboBox_secondInput);
            this.Controls.Add(this.comboBox_minuteInput);
            this.Controls.Add(this.comboBox_hourInput);
            this.Controls.Add(this.radioButton_showComboBox);
            this.Controls.Add(this.radioButton_showTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_secondInput);
            this.Controls.Add(this.textBox_minuteInput);
            this.Controls.Add(this.textBox_hourInput);
            this.Controls.Add(this.button_stopSound);
            this.Controls.Add(this.button_startTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Eye Rest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_time_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_enter_time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxminute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startTimer;
        private System.Windows.Forms.Button button_stopSound;
        private System.Windows.Forms.TextBox textBox_hourInput;
        private System.Windows.Forms.TextBox textBox_minuteInput;
        private System.Windows.Forms.TextBox textBox_secondInput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton_showTextBox;
        private System.Windows.Forms.RadioButton radioButton_showComboBox;
        private System.Windows.Forms.ComboBox comboBox_hourInput;
        private System.Windows.Forms.ComboBox comboBox_minuteInput;
        private System.Windows.Forms.ComboBox comboBox_secondInput;
        private System.Windows.Forms.PictureBox pictureBox_hour;
        private System.Windows.Forms.PictureBox pictureBoxminute;
        private System.Windows.Forms.PictureBox pictureBox_second;
        private System.Windows.Forms.Timer timer_timer;
        private System.Windows.Forms.TextBox textBox_timeLeftHour;
        private System.Windows.Forms.TextBox textBox_timeLeftMinute;
        private System.Windows.Forms.TextBox textBox_timeLeftSecond;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Button button_pauseTimer;
        private System.Windows.Forms.Button button_playTimer;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Timer timer_showing_logo_image;
        private System.Windows.Forms.PictureBox pictureBox_enter_time;
        private System.Windows.Forms.PictureBox pictureBox_time_left;
    }
}

