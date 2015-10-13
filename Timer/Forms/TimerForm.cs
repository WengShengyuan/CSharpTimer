using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer.Src.GraphicModule;
using System.Media;
using System.Threading;

namespace Timer.Forms
{
    public partial class TimerForm : Form
    {
        TimerGraphic tg;
        SoundPlayer sp;
        DateTime now;
        Boolean mouseDn=false;
        Point mouseP;

        int total = -1;
        int alertTime = -1;
        int countSec = -1;
        Boolean C_Continue = false;
        Boolean showLast = true;
        Boolean showElapsed = true;
        Color textColor = Color.Black;
        Color ringColor = Color.Orange;

        Boolean timeUpAlerted = false;
        Boolean alerted = false;
        Boolean countBeeped = false;
        int lastBeeped = -1;
        

        public TimerForm()
        {
            InitializeComponent();
            tg = new TimerGraphic(pictureBox1);
            tg.clearGraphic();

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true; // 设置可以通告进度
            backgroundWorker1.WorkerSupportsCancellation = true; // 设置可以取消
            PictureBox.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        public void setTotal(int sec)
        {
            this.total = sec;
        }
        public void setAlertTime(int time)
        {
            this.alertTime = time;
        }
        public void setCountSec(int sec)
        {
            this.countSec = sec;
        }
        public void setShowLast(Boolean show)
        {
            this.showLast = show;
        }
        public void setShowElapsed(Boolean show)
        {
            this.showElapsed = show;
        }
        public void setContinue(Boolean cContinue)
        {
            this.C_Continue = cContinue;
        }
        public void setTextColor(Color c)
        {
            this.textColor = c;
        }
        public void setRingColor(Color c)
        {
            this.ringColor = c;
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {

        }

        #region backgroundWorker
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        public void expandSize()
        {
            double por = (double)this.Width / (double)this.Height;
            this.Height = this.Height + 5;
            this.Width = (Int32)(por * (double)this.Height);
            tg.calSize();
        }

        public void shrinkSize()
        {
            double por = (double)this.Width / (double)this.Height;
            this.Height = this.Height - 5;
            this.Width = (Int32)(por * (double)this.Height);
            tg.calSize();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                double milisec = (DateTime.Now - now).TotalMilliseconds;
                int restSec = (Int32)(total * 1000 - milisec) / 1000;
                if (milisec > total * 1000)
                {
                    tg.clearGraphic();
                    tg.draw(milisec, total * 1000, showLast, showElapsed, ringColor, textColor);
                    tg.apply();
                    if (C_Continue)
                    {
                        if (!timeUpAlerted)
                        {
                            alerted = false;
                            sp = new SoundPlayer(Timer.Properties.Resources._3);
                            sp.Play();
                            timeUpAlerted = true;
                        }
                        
                    }
                    else
                    {
                        alerted = false;
                        sp = new SoundPlayer(Timer.Properties.Resources._3);
                        sp.Play();
                        break;
                    }
                }

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                
                
                tg.clearGraphic();
                tg.draw(milisec, total * 1000, showLast, showElapsed, ringColor, textColor);
                tg.apply();

                if (restSec != lastBeeped) 
                {
                    if (countSec > 0 && restSec <= countSec-1 && restSec >= 0)
                    {
                        sp = new SoundPlayer(Timer.Properties.Resources._1);
                        sp.Play();
                        lastBeeped = restSec;
                    }
                }

                if (!alerted && restSec == alertTime-1)
                {
                    sp = new SoundPlayer(Timer.Properties.Resources._2);
                    sp.Play();
                    alerted = true;
                }

                Thread.Sleep(10); 
            }
        }
        #endregion

        private void TimerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                this.Hide();
            }
        }

        public void reset()
        {
            tg.clearGraphic();
            tg.draw(0, 100, false, false, ringColor, textColor);
            tg.apply();
        }

        public void start() 
        {
            if (total < 0)
            {
                MessageBox.Show("未设置计时时间");
                return;
            }

            if (countSec > alertTime)
            {
                MessageBox.Show("倒计时时间不应大于提示时间");
                return;
            }
            now = DateTime.Now;
            if(!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        public void stop()
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();

            }
            else
            {
                MessageBox.Show("没有计时进程");
            }
        }

        public Boolean isBusy()
        {
            return backgroundWorker1.IsBusy;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseP = new Point(-e.X, -e.Y); //得到变量的值
                mouseDn = true;                  //点击左键按下时标注为true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDn)
            {
                mouseDn = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDn)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseP.X, mouseP.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }

    }
}
