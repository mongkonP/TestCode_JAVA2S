//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Loadcursorfilecur.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Cursor
{ 
   public   class Cursor_1_Loadcursorfilecur:Form
    { 
       public   Cursor_1_Loadcursorfilecur()
       {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            Rectangle r;

            if (new Rectangle(0, 0, 100, 100).Contains(p))
                this.Cursor = new Cursor("MyCursor.cur");
            else if (new Rectangle(100, 0, 100, 100).Contains(p))
                this.Cursor = Cursors.Hand;
            else if (new Rectangle(0, 100, 100, 100).Contains(p))
                this.Cursor = Cursors.VSplit;
            else if (new Rectangle(100, 100, 100, 100).Contains(p))
                this.Cursor = Cursors.UpArrow;
            else
                this.Cursor = Cursors.Default;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, 100, 100);
            g.FillRectangle(Brushes.Red, 100, 0, 100, 100);
            g.FillRectangle(Brushes.Yellow, 0, 100, 100, 100);
            g.FillRectangle(Brushes.Green, 100, 100, 100, 100);
        }
    }
}
