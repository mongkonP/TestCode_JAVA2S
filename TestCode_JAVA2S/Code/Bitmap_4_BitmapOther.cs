//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/BitmapOther.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Bitmap
{ 
   public   class Bitmap_4_BitmapOther:Form
    {
        private System.ComponentModel.Container components = null;
        public   Bitmap_4_BitmapOther()
       {
            InitializeComponent();

        }
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Bitmap_4_BitmapOther
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1435, 812);
            this.Name = "Bitmap_4_BitmapOther";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitmapOther";
            this.Load += new System.EventHandler(this.BitmapOther_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void BitmapOther_Load(object sender, System.EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap BMP = new Bitmap(global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);
            Point Pt = new Point(20, 20);

            //   BMP.SetPixel(15,20,Color.Black);
            BMP.MakeTransparent(BMP.GetPixel(15, 25));

            e.Graphics.DrawImage(BMP, Pt);
            e.Graphics.DrawLine(new Pen(Brushes.GreenYellow, 30), 60, 60, 200, 60);



        }
    }
}
