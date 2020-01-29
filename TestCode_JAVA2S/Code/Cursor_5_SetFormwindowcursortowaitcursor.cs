//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/SetFormwindowcursortowaitcursor.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Cursor
{ 
   public   class Cursor_5_SetFormwindowcursortowaitcursor:Form
    {
        private System.ComponentModel.Container components;
        public   Cursor_5_SetFormwindowcursortowaitcursor()
       {

            InitializeComponent();
            BackColor = Color.Tomato;
            Opacity = 0.5d;
            Text = "www.java2s.com";
            Cursor = Cursors.WaitCursor;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "Form1";
        }


        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("www.java2s.com",
              new Font("Times New Roman", 20),
              new SolidBrush(Color.Black), 40, 10);
        }
    }
}
