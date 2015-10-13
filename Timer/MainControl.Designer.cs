namespace Timer
{
    partial class MainControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_SHOWTIMER = new System.Windows.Forms.Button();
            this.BTN_HIDETIMER = new System.Windows.Forms.Button();
            this.BTN_STARTTIMER = new System.Windows.Forms.Button();
            this.BTN_STOPTIMER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.T_TOTAL = new System.Windows.Forms.TextBox();
            this.T_ALERT = new System.Windows.Forms.TextBox();
            this.T_COUNTDOWN = new System.Windows.Forms.TextBox();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.C_SHOWLEFT = new System.Windows.Forms.CheckBox();
            this.C_SHOTELAPSED = new System.Windows.Forms.CheckBox();
            this.C_CONTINUE = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BTN_TEXTCOLOR = new System.Windows.Forms.Button();
            this.BTN_RINGCOLOR = new System.Windows.Forms.Button();
            this.BTN_SHRINK = new System.Windows.Forms.Button();
            this.BTN_EXPAND = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_SHOWTIMER
            // 
            this.BTN_SHOWTIMER.Location = new System.Drawing.Point(325, 114);
            this.BTN_SHOWTIMER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_SHOWTIMER.Name = "BTN_SHOWTIMER";
            this.BTN_SHOWTIMER.Size = new System.Drawing.Size(111, 61);
            this.BTN_SHOWTIMER.TabIndex = 0;
            this.BTN_SHOWTIMER.Text = "显示计时器";
            this.BTN_SHOWTIMER.UseVisualStyleBackColor = true;
            this.BTN_SHOWTIMER.Click += new System.EventHandler(this.BTN_SHOWTIMER_Click);
            // 
            // BTN_HIDETIMER
            // 
            this.BTN_HIDETIMER.Location = new System.Drawing.Point(448, 114);
            this.BTN_HIDETIMER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_HIDETIMER.Name = "BTN_HIDETIMER";
            this.BTN_HIDETIMER.Size = new System.Drawing.Size(111, 61);
            this.BTN_HIDETIMER.TabIndex = 1;
            this.BTN_HIDETIMER.Text = "隐藏计时器";
            this.BTN_HIDETIMER.UseVisualStyleBackColor = true;
            this.BTN_HIDETIMER.Click += new System.EventHandler(this.BTN_HIDETIMER_Click);
            // 
            // BTN_STARTTIMER
            // 
            this.BTN_STARTTIMER.Location = new System.Drawing.Point(328, 11);
            this.BTN_STARTTIMER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_STARTTIMER.Name = "BTN_STARTTIMER";
            this.BTN_STARTTIMER.Size = new System.Drawing.Size(75, 61);
            this.BTN_STARTTIMER.TabIndex = 2;
            this.BTN_STARTTIMER.Text = "开始计时";
            this.BTN_STARTTIMER.UseVisualStyleBackColor = true;
            this.BTN_STARTTIMER.Click += new System.EventHandler(this.BTN_STARTTIMER_Click);
            // 
            // BTN_STOPTIMER
            // 
            this.BTN_STOPTIMER.Location = new System.Drawing.Point(407, 11);
            this.BTN_STOPTIMER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_STOPTIMER.Name = "BTN_STOPTIMER";
            this.BTN_STOPTIMER.Size = new System.Drawing.Size(75, 61);
            this.BTN_STOPTIMER.TabIndex = 3;
            this.BTN_STOPTIMER.Text = "结束计时";
            this.BTN_STOPTIMER.UseVisualStyleBackColor = true;
            this.BTN_STOPTIMER.Click += new System.EventHandler(this.BTN_STOPTIMER_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "总时长：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "提示音时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "倒计时时长：";
            // 
            // T_TOTAL
            // 
            this.T_TOTAL.AccessibleName = "";
            this.T_TOTAL.Location = new System.Drawing.Point(108, 5);
            this.T_TOTAL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.T_TOTAL.Name = "T_TOTAL";
            this.T_TOTAL.Size = new System.Drawing.Size(186, 21);
            this.T_TOTAL.TabIndex = 7;
            this.T_TOTAL.Text = "180";
            // 
            // T_ALERT
            // 
            this.T_ALERT.Location = new System.Drawing.Point(108, 49);
            this.T_ALERT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.T_ALERT.Name = "T_ALERT";
            this.T_ALERT.Size = new System.Drawing.Size(186, 21);
            this.T_ALERT.TabIndex = 8;
            this.T_ALERT.Text = "30";
            // 
            // T_COUNTDOWN
            // 
            this.T_COUNTDOWN.Location = new System.Drawing.Point(108, 92);
            this.T_COUNTDOWN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.T_COUNTDOWN.Name = "T_COUNTDOWN";
            this.T_COUNTDOWN.Size = new System.Drawing.Size(186, 21);
            this.T_COUNTDOWN.TabIndex = 9;
            this.T_COUNTDOWN.Text = "5";
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(13, 224);
            this.BTN_SAVE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(280, 40);
            this.BTN_SAVE.TabIndex = 10;
            this.BTN_SAVE.Text = "应用";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.Location = new System.Drawing.Point(487, 11);
            this.BTN_RESET.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(75, 61);
            this.BTN_RESET.TabIndex = 11;
            this.BTN_RESET.Text = "重置";
            this.BTN_RESET.UseVisualStyleBackColor = true;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // C_SHOWLEFT
            // 
            this.C_SHOWLEFT.AutoSize = true;
            this.C_SHOWLEFT.Checked = true;
            this.C_SHOWLEFT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.C_SHOWLEFT.Location = new System.Drawing.Point(13, 179);
            this.C_SHOWLEFT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C_SHOWLEFT.Name = "C_SHOWLEFT";
            this.C_SHOWLEFT.Size = new System.Drawing.Size(120, 16);
            this.C_SHOWLEFT.TabIndex = 12;
            this.C_SHOWLEFT.Text = "是否显示剩余时间";
            this.C_SHOWLEFT.UseVisualStyleBackColor = true;
            this.C_SHOWLEFT.CheckedChanged += new System.EventHandler(this.C_SHOWLEFT_CheckedChanged);
            // 
            // C_SHOTELAPSED
            // 
            this.C_SHOTELAPSED.AutoSize = true;
            this.C_SHOTELAPSED.Checked = true;
            this.C_SHOTELAPSED.CheckState = System.Windows.Forms.CheckState.Checked;
            this.C_SHOTELAPSED.Location = new System.Drawing.Point(150, 179);
            this.C_SHOTELAPSED.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C_SHOTELAPSED.Name = "C_SHOTELAPSED";
            this.C_SHOTELAPSED.Size = new System.Drawing.Size(120, 16);
            this.C_SHOTELAPSED.TabIndex = 13;
            this.C_SHOTELAPSED.Text = "是否显示进行时间";
            this.C_SHOTELAPSED.UseVisualStyleBackColor = true;
            this.C_SHOTELAPSED.CheckedChanged += new System.EventHandler(this.C_SHOTELAPSED_CheckedChanged);
            // 
            // C_CONTINUE
            // 
            this.C_CONTINUE.AutoSize = true;
            this.C_CONTINUE.Location = new System.Drawing.Point(13, 204);
            this.C_CONTINUE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.C_CONTINUE.Name = "C_CONTINUE";
            this.C_CONTINUE.Size = new System.Drawing.Size(120, 16);
            this.C_CONTINUE.TabIndex = 14;
            this.C_CONTINUE.Text = "到时是否继续计时";
            this.C_CONTINUE.UseVisualStyleBackColor = true;
            this.C_CONTINUE.CheckedChanged += new System.EventHandler(this.C_CONTINUE_CheckedChanged);
            // 
            // BTN_TEXTCOLOR
            // 
            this.BTN_TEXTCOLOR.Location = new System.Drawing.Point(13, 125);
            this.BTN_TEXTCOLOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_TEXTCOLOR.Name = "BTN_TEXTCOLOR";
            this.BTN_TEXTCOLOR.Size = new System.Drawing.Size(111, 40);
            this.BTN_TEXTCOLOR.TabIndex = 15;
            this.BTN_TEXTCOLOR.Text = "文字颜色";
            this.BTN_TEXTCOLOR.UseVisualStyleBackColor = true;
            this.BTN_TEXTCOLOR.Click += new System.EventHandler(this.BTN_TEXTCOLOR_Click);
            // 
            // BTN_RINGCOLOR
            // 
            this.BTN_RINGCOLOR.Location = new System.Drawing.Point(182, 125);
            this.BTN_RINGCOLOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_RINGCOLOR.Name = "BTN_RINGCOLOR";
            this.BTN_RINGCOLOR.Size = new System.Drawing.Size(111, 40);
            this.BTN_RINGCOLOR.TabIndex = 16;
            this.BTN_RINGCOLOR.Text = "圆环颜色";
            this.BTN_RINGCOLOR.UseVisualStyleBackColor = true;
            this.BTN_RINGCOLOR.Click += new System.EventHandler(this.BTN_RINGCOLOR_Click);
            // 
            // BTN_SHRINK
            // 
            this.BTN_SHRINK.Location = new System.Drawing.Point(448, 181);
            this.BTN_SHRINK.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_SHRINK.Name = "BTN_SHRINK";
            this.BTN_SHRINK.Size = new System.Drawing.Size(111, 61);
            this.BTN_SHRINK.TabIndex = 18;
            this.BTN_SHRINK.Text = "缩小计时器";
            this.BTN_SHRINK.UseVisualStyleBackColor = true;
            this.BTN_SHRINK.Click += new System.EventHandler(this.BTN_SHRINK_Click);
            // 
            // BTN_EXPAND
            // 
            this.BTN_EXPAND.Location = new System.Drawing.Point(325, 181);
            this.BTN_EXPAND.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_EXPAND.Name = "BTN_EXPAND";
            this.BTN_EXPAND.Size = new System.Drawing.Size(111, 61);
            this.BTN_EXPAND.TabIndex = 17;
            this.BTN_EXPAND.Text = "放大计时器";
            this.BTN_EXPAND.UseVisualStyleBackColor = true;
            this.BTN_EXPAND.Click += new System.EventHandler(this.BTN_EXPAND_Click);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 287);
            this.Controls.Add(this.BTN_SHRINK);
            this.Controls.Add(this.BTN_EXPAND);
            this.Controls.Add(this.BTN_RINGCOLOR);
            this.Controls.Add(this.BTN_TEXTCOLOR);
            this.Controls.Add(this.C_CONTINUE);
            this.Controls.Add(this.C_SHOTELAPSED);
            this.Controls.Add(this.C_SHOWLEFT);
            this.Controls.Add(this.BTN_RESET);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.T_COUNTDOWN);
            this.Controls.Add(this.T_ALERT);
            this.Controls.Add(this.T_TOTAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_STOPTIMER);
            this.Controls.Add(this.BTN_STARTTIMER);
            this.Controls.Add(this.BTN_HIDETIMER);
            this.Controls.Add(this.BTN_SHOWTIMER);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainControl";
            this.Text = "中控";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainControl_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SHOWTIMER;
        private System.Windows.Forms.Button BTN_HIDETIMER;
        private System.Windows.Forms.Button BTN_STARTTIMER;
        private System.Windows.Forms.Button BTN_STOPTIMER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox T_TOTAL;
        private System.Windows.Forms.TextBox T_ALERT;
        private System.Windows.Forms.TextBox T_COUNTDOWN;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.CheckBox C_SHOWLEFT;
        private System.Windows.Forms.CheckBox C_SHOTELAPSED;
        private System.Windows.Forms.CheckBox C_CONTINUE;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BTN_TEXTCOLOR;
        private System.Windows.Forms.Button BTN_RINGCOLOR;
        private System.Windows.Forms.Button BTN_SHRINK;
        private System.Windows.Forms.Button BTN_EXPAND;

    }
}

