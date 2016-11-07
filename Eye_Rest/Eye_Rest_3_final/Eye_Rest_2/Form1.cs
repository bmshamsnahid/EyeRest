using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Media;
using System.IO;

namespace Eye_Rest_2
{
    public partial class Form1 : Form
    {
        int sec, store_second, start_time;
        SoundPlayer audio = new SoundPlayer(Eye_Rest_2.Properties.Resources.spanish_guitar);

        public WindowStyle WindowStyle { get; set; }

        //Get the value from the textbox or combobox string and return the integer
        int getParsedValue(string str)
        {
            int number;
            bool flag = false;

            flag = Int32.TryParse(str, out number);

            if (flag) return int.Parse(str);
            else return 0;
        }

        //Change the visiability of Textbox
        void TextBoxVisiability(bool flag)
        {
            textBox_hourInput.Visible = textBox_minuteInput.Visible = textBox_secondInput.Visible = flag;
            //pictureBox_enter_time.Visible = flag;
        }

        void RemainingTextBoxVisiability(bool flag)
        {
            textBox_timeLeftHour.Visible = textBox_timeLeftMinute.Visible = textBox_timeLeftSecond.Visible = flag;
            pictureBox_time_left.Visible = flag;
            pictureBox_enter_time.Visible = !flag;
            listbox_visiability(!flag);
            radiobutton_visiability(!flag);
        }

        //Change the visiability of Comboboxbox
        void ComboBoxVisiability(bool flag)
        {
            comboBox_hourInput.Visible = comboBox_minuteInput.Visible = comboBox_secondInput.Visible = flag;
        }

        void button_visiability(bool flag)
        {
            button_startTimer.Visible = flag;
            button_playTimer.Visible = flag;
            button_pauseTimer.Visible = flag;
            button_stopSound.Visible = flag;
            button_reset.Visible = flag;
            button_restart.Visible = flag;
        }

        void listbox_visiability(bool flag)
        {
            listBox1.Visible = flag;
        }

        void radiobutton_visiability(bool flag)
        {
            radioButton_showComboBox.Visible = flag;
            radioButton_showTextBox.Visible = flag;
        }

        void picturebox_input_time_visiability(bool flag)
        {
            pictureBox_hour.Visible = flag;
            pictureBoxminute.Visible = flag;
            pictureBox_second.Visible = flag;
        }

        //Play sound and keep stop button visiable
        void playSound()
        {
            audio.Play();
            ////////////////////////////////////////////////////////////////////////////////////
            button_stopSound.Visible = true;
        }

        //Stop sound and make stop button not-visiable
        void stopSound()
        {
            audio.Stop();
            button_stopSound.Visible = false;
        }

        int total_time()
        {
            int Hour, Minute, Second, total_min, total_second = 0;

            if (radioButton_showComboBox.Checked == true)
            {
                TextBoxVisiability(false);
                ComboBoxVisiability(true);
                Hour = getParsedValue(comboBox_hourInput.Text);
                Minute = getParsedValue(comboBox_minuteInput.Text);
                Second = getParsedValue(comboBox_secondInput.Text);
            }

            else
            {
                TextBoxVisiability(true);
                ComboBoxVisiability(false);
                Hour = getParsedValue(textBox_hourInput.Text);
                Minute = getParsedValue(textBox_minuteInput.Text);
                Second = getParsedValue(textBox_secondInput.Text);
            }

            total_min = sec = 0;

            total_min = (Hour * 60) + Minute;
            total_second = (total_min * 60) + Second;

            store_second = total_second;

            return total_second;
        }

        void start_remaining_time_textbox(int second) {
            int remaining_hour, remaining_minute, remaining_second;
            remaining_hour = second / 3600;
            second -= (remaining_hour*3600);
            remaining_minute = second/60;
            second -= (remaining_minute * 60);
            remaining_second = second;
            assign_remaining_textbox(remaining_hour, remaining_minute, remaining_second);
        }

        void assign_remaining_textbox(int remaining_hour, int remaining_minute, int remaining_second)
        {
            textBox_timeLeftHour.Text = remaining_hour.ToString();
            textBox_timeLeftMinute.Text = remaining_minute.ToString();
            textBox_timeLeftSecond.Text = remaining_second.ToString();
        }

        void assign_input_textbox(int remaining_hour, int remaining_minute, int remaining_second)
        {
            textBox_hourInput.Text = remaining_hour.ToString();
            textBox_minuteInput.Text = remaining_minute.ToString();
            textBox_secondInput.Text = remaining_second.ToString();
        }

        void startOver() 
        {
            timer_timer.Enabled = false;
            
            TextBoxVisiability(true);
            picturebox_input_time_visiability(true);
            button_startTimer.Visible = true;

            ComboBoxVisiability(false);
            RemainingTextBoxVisiability(false);

            radioButton_showComboBox.Checked = radioButton_showTextBox.Checked = false;

            button_stopSound.Visible = false;
            button_playTimer.Visible = false;
            button_pauseTimer.Visible = false;
            button_restart.Visible = false;
            button_reset.Visible = false;

            assign_remaining_textbox(0, 0, 0);
            assign_input_textbox(0, 0, 0);

            stopSound();
        }

        void musicrun()
        {
            sec = store_second;
            stopSound();
            timer_timer.Enabled = true;
            button_startTimer.Visible = false;
            TextBoxVisiability(false);
            ComboBoxVisiability(false);
            RemainingTextBoxVisiability(true);
            button_pauseTimer.Visible = true;
            button_reset.Visible = true;
            button_restart.Visible = true;
        }

        void showDialouge()
        {
            assign_remaining_textbox(0, 0, 0);
            DialogResult messagebox_result = MessageBox.Show("Start over same time configaration?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (messagebox_result == DialogResult.Yes)
            {
                musicrun();
            }
            if (messagebox_result == DialogResult.No)
            {
                startOver();
            }
            if (messagebox_result == DialogResult.Cancel)
            {
                DialogResult messagebox_exit = MessageBox.Show("Do you want to exit from the Eye Rest?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (messagebox_exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
                startOver();
            }
        }

        void show_logo() 
        {
            pictureBox_logo.Visible = true;
            start_time = 1;
            timer_showing_logo_image.Interval = 1000;
            timer_showing_logo_image.Enabled = true;
        }

        void hide_all()
        {
            TextBoxVisiability(false);
            RemainingTextBoxVisiability(false);
            ComboBoxVisiability(false);
            button_visiability(false);
            listbox_visiability(false);
            radiobutton_visiability(false);
            picturebox_input_time_visiability(false);
            pictureBox_enter_time.Visible = false;
            pictureBox_time_left.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hide_all();
            show_logo();
        }

        private void button_startTimer_Click(object sender, EventArgs e)
        {
            button_startTimer.Visible = false;
            button_playTimer.Visible = false;
            button_pauseTimer.Visible = true;
            button_restart.Visible = true;
            button_reset.Visible = true;

            sec = total_time();
            timer_timer.Enabled = true;
            timer_timer.Interval = 1000;
            TextBoxVisiability(false);
            ComboBoxVisiability(false);
            RemainingTextBoxVisiability(true);
        }

        private void timer_timer_Tick(object sender, EventArgs e)
        {
            start_remaining_time_textbox(sec);
            if (sec == 0)
            {
                button_playTimer.Visible = button_pauseTimer.Visible = button_reset.Visible = button_restart.Visible = false;
                TextBoxVisiability(false);
                timer_timer.Enabled = false;
                playSound();
            }
            else
            {
                
            }
            sec--;
        }

        private void radioButton_showTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_showTextBox.Checked == true)
            {
                TextBoxVisiability(true);
                ComboBoxVisiability(false);
            }
        }

        private void radioButton_showComboBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_showComboBox.Checked == true)
            {
                TextBoxVisiability(false);
                ComboBoxVisiability(true);
            }
        }

        private void button_stopSound_Click(object sender, EventArgs e)
        {
            stopSound();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            button_startTimer.Visible = true;
            showDialouge();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            sec = store_second;
            timer_timer.Enabled = true;
            timer_timer.Interval = 1000;
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            startOver();
        }

        private void button_pauseTimer_Click(object sender, EventArgs e)
        {
            timer_timer.Enabled = false;
            button_playTimer.Visible = true;
            button_pauseTimer.Visible = false;
        }

        private void button_playTimer_Click(object sender, EventArgs e)
        {
            timer_timer.Enabled = true;
            button_playTimer.Visible = false;
            button_pauseTimer.Visible = true;
        }

        private void timer_showing_logo_image_Tick(object sender, EventArgs e)
        {
            if (start_time != 0)
            {
                pictureBox_logo.Visible = true;
            }
            else {
                pictureBox_logo.Visible = false;
                timer_showing_logo_image.Enabled = false;
                startOver();
            }
            start_time--;
        }
    }
}
