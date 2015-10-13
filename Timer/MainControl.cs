using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainControl : Form
    {
        Forms.TimerForm timerForm;
        public MainControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTN_RESET.Enabled = false;
            timerForm = new Forms.TimerForm();
            timerForm.FormBorderStyle = FormBorderStyle.None;//无边框
            timerForm.TransparencyKey = Color.DarkCyan;
            timerForm.TopMost = true;
            BTN_SHOWTIMER.PerformClick();
            BTN_SAVE.PerformClick();
        }
                
        private void BTN_SHOWTIMER_Click(object sender, EventArgs e)
        {
            timerForm.Show();
        }

        private void BTN_HIDETIMER_Click(object sender, EventArgs e)
        {
            timerForm.Hide();
        }

        private void BTN_STARTTIMER_Click(object sender, EventArgs e)
        {
            BTN_RESET.Enabled = false;
            timerForm.start();
        }

        private void BTN_STOPTIMER_Click(object sender, EventArgs e)
        {
            BTN_RESET.Enabled = true;
            timerForm.stop();
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            //timerForm.stop();
            
            timerForm.reset();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                int total = Int32.Parse(T_TOTAL.Text);
                int alert = Int32.Parse(T_ALERT.Text);
                int count = Int32.Parse(T_COUNTDOWN.Text);
                timerForm.setTotal(total);
                timerForm.setAlertTime(alert);
                timerForm.setCountSec(count);
            }
            catch (Exception)
            {
                MessageBox.Show("参数处理错误");
            }
        }

        private void C_SHOWLEFT_CheckedChanged(object sender, EventArgs e)
        {
            timerForm.setShowLast(C_SHOWLEFT.Checked);
        }

        private void C_SHOTELAPSED_CheckedChanged(object sender, EventArgs e)
        {
            timerForm.setShowElapsed(C_SHOTELAPSED.Checked);
        }

        private void MainControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerForm.isBusy()) 
            {
                timerForm.stop();
            }
        }

        private void C_CONTINUE_CheckedChanged(object sender, EventArgs e)
        {
            timerForm.setContinue(C_CONTINUE.Checked);
        }

        private void BTN_TEXTCOLOR_Click(object sender, EventArgs e)
        {

            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                timerForm.setTextColor(this.colorDialog1.Color);
            }
         }

        private void BTN_RINGCOLOR_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                timerForm.setRingColor(this.colorDialog1.Color);
            }
        }

        private void BTN_EXPAND_Click(object sender, EventArgs e)
        {
            timerForm.expandSize();
        }

        private void BTN_SHRINK_Click(object sender, EventArgs e)
        {
            timerForm.shrinkSize();
        }
    }
}
