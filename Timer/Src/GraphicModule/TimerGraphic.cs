using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Timer.Src.GraphicModule
{
    class TimerGraphic
    {
        public Graphics g;
        public Bitmap b;
        public PictureBox p;
        int widthO=0;
        int widthI=0;
        int r ;
        int oX ;
        int oY ;
        int deltaX ;
        int textSize;
        public TimerGraphic(PictureBox p) 
        {
            this.p = p;
            b = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(b);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            widthO = this.b.Width / 25;
            widthI = this.b.Width / 22;
            r = this.b.Width / 5;
            oX = this.b.Width / 2 - r;
            oY = this.b.Height / 2 - r;
            deltaX = this.b.Width / 13;
            textSize = b.Height / 11;
        }
        public void clearGraphic() 
        {
            this.g.Clear(Color.DarkCyan);
        }

        public void drawCircle(int oX, int oY, int r, int width, Color color) 
        {
            Pen pen = new Pen(color, width);
            this.g.DrawEllipse(pen, oX, oY, r * 2, r * 2);
        }

        public void calSize()
        {
            b = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(b);
            widthO = this.b.Width / 25;
            widthI = this.b.Width / 22;
            r = this.b.Width / 5;
            oX = this.b.Width / 2 - r;
            oY = this.b.Height / 2 - r;
            deltaX = this.b.Width / 13;
            textSize = b.Height / 11;
        }

        public void drawArc(int oX, int oY, int r, int startAngle, int sweepAngle,int width, Color color)
        {
            Pen pen = new Pen(color, width);
            this.g.DrawArc(pen,oX,oY,2*r,2*r,startAngle,sweepAngle);
            
        }

        public void drawText(int oX, int oY,int size, String text, Color color) 
        {
            SolidBrush brush = new SolidBrush(color);
            g.DrawString(text,new Font("Times New Roman", size),brush,new PointF(oX, oY));
        }

        public void draw(double elips, double fullSeconds, Boolean showTimeLeft, Boolean showTimeRuned, Color ringColor, Color textColor) 
        {

            double part = elips / fullSeconds;
            int d =(Int32)(360 * part);
            Color arc = Color.White;
            drawCircle(oX, oY, r, widthO, ringColor);
            drawArc(oX, oY, r, -90, d, widthI, arc);
            if (showTimeLeft) 
            {
                int lastSec = (Int32)(fullSeconds - elips) / 1000 ;
                drawText(oX+r -deltaX*2 , oY + r - widthI, textSize, lastSec.ToString() + "秒", textColor);
            }

            if (showTimeRuned)
            {
                int runed = (Int32)(elips / 1000);
                drawText(oX+r-deltaX, this.b.Height-textSize*2,textSize-10, runed.ToString() + "秒", textColor);
            }
        }
       

        public void apply()
        {
            p.CreateGraphics().DrawImage(b, 0, 0);
            System.GC.Collect();
        }
    }
}
