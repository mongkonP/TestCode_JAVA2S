//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/BitmapColor.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Bitmap
{ 
   public   class Bitmap_2_BitmapColor:Form
    {
        private System.ComponentModel.Container components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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

        public   Bitmap_2_BitmapColor()
       {
            InitializeComponent();



        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ColorPalette cp;
            String s;
            Bitmap bmp = new Bitmap(global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);

            cp = bmp.Palette;

            foreach (Color c in cp.Entries)
            {
                s = c.ToString();
            }


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);
            Color c;

            e.Graphics.DrawImage(bmp, 10, 30);

            for (int x = 0; x < bmp.Width - 1; x++)
            {
                for (int y = 0; y < bmp.Height - 1; y++)
                {
                    c = bmp.GetPixel(x, y);
                    c = Color.FromArgb(c.ToArgb() + 100);
                    bmp.SetPixel(x, y, c);
                }
            }
            e.Graphics.DrawImage(bmp, 150, 30);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Bitmap_2_BitmapColor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(858, 480);
            this.Name = "Bitmap_2_BitmapColor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
    }
}
