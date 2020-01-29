//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/BitmapDemo.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Bitmap
{ 
   public   class Bitmap_3_BitmapDemo:Form
    {
        #region Class Local Variables

        private Bitmap WholeBMP;
        private Bitmap SaveBMP;
        private Bitmap TLBMP;
        private Bitmap TRBMP;
        private Bitmap BLBMP;
        private Bitmap BRBMP;

        private Rectangle DrawRect;
        private Point TLpt;
        private Point TRpt;
        private Point BLpt;
        private Point BRpt;
        private int Counter = 0;

        private ImageAttributes Ia;

        #endregion
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer T1;

        private System.Windows.Forms.Button cmdGo;
        public   Bitmap_3_BitmapDemo()
       {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            WholeBMP = new Bitmap(global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);
            DrawRect = new Rectangle(0, 0, WholeBMP.Width, WholeBMP.Height);
            DrawRect.X = this.Width / 2 - WholeBMP.Width / 2;
            DrawRect.Y = this.Height / 2 - WholeBMP.Height / 2;
            T1.Interval = 75;
            T1.Enabled = false;

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
            if (WholeBMP != null)
                WholeBMP.Dispose();

            if (SaveBMP != null)
                SaveBMP.Dispose();
            if (TLBMP != null)
                TLBMP.Dispose();
            if (TRBMP != null)
                TRBMP.Dispose();
            if (BLBMP != null)
                BLBMP.Dispose();
            if (BRBMP != null)
                BRBMP.Dispose();
            if (Ia != null)
                Ia.Dispose();
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
            this.cmdGo = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(1, 12);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(48, 24);
            this.cmdGo.TabIndex = 0;
            this.cmdGo.Text = "GO";
            this.cmdGo.Click += new System.EventHandler(this.Explode);
            // 
            // T1
            // 
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // Bitmap_3_BitmapDemo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1162, 919);
            this.Controls.Add(this.cmdGo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bitmap_3_BitmapDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exploding Bitmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;

            if (WholeBMP != null)
            {
                G.DrawImage(WholeBMP, DrawRect);
                return;
            }

            if (TLBMP != null)
                G.DrawImage(TLBMP, new Rectangle(TLpt, TLBMP.Size),
                  0, 0,
                  TLBMP.Width, TLBMP.Height,
                  GraphicsUnit.Pixel,
                  Ia);

            if (TRBMP != null)
                G.DrawImage(TRBMP, new Rectangle(TRpt, TRBMP.Size),
                  0, 0,
                  TRBMP.Width, TRBMP.Height,
                  GraphicsUnit.Pixel,
                  Ia);

            if (BLBMP != null)
                G.DrawImage(BLBMP, new Rectangle(BLpt, BLBMP.Size),
                  0, 0,
                  BLBMP.Width, BLBMP.Height,
                  GraphicsUnit.Pixel,
                  Ia);

            if (BRBMP != null)
                G.DrawImage(BRBMP, new Rectangle(BRpt, BRBMP.Size),
                  0, 0,
                  BRBMP.Width, BRBMP.Height,
                  GraphicsUnit.Pixel,
                  Ia);
        }

        private void Explode(object sender, System.EventArgs e)
        {
            if (WholeBMP != null)
            {
                cmdGo.Enabled = false;
                int L = 0;
                int T = 0;
                int Cx = (int)(WholeBMP.Width / 2);
                int Cy = (int)(WholeBMP.Height / 2);

                Rectangle R1 = new Rectangle(L, T, Cx, Cy);
                Rectangle R2 = new Rectangle(Cx, T, Cx, Cy);
                Rectangle R3 = new Rectangle(L, Cy, Cx, Cy);
                Rectangle R4 = new Rectangle(Cx, Cy, Cx, Cy);

                SaveBMP = WholeBMP;
                TLBMP = WholeBMP.Clone(new Rectangle(L, T, Cx, Cy),
                                        WholeBMP.PixelFormat);
                TRBMP = WholeBMP.Clone(new Rectangle(Cx, T, Cx, Cy),
                                        WholeBMP.PixelFormat);
                BLBMP = WholeBMP.Clone(new Rectangle(L, Cy, Cx, Cy),
                                        WholeBMP.PixelFormat);
                BRBMP = WholeBMP.Clone(new Rectangle(Cx, Cy, Cx, Cy),
                                        WholeBMP.PixelFormat);
                WholeBMP = null;

                int Gap = 10;
                TLpt = new Point(DrawRect.Left - Gap, DrawRect.Top - Gap);
                TRpt = new Point(DrawRect.Left + Cx + Gap, DrawRect.Top - Gap);
                BLpt = new Point(DrawRect.Left - Gap, DrawRect.Top + Cy + Gap);
                BRpt = new Point(DrawRect.Left + Cx + Gap, DrawRect.Top + Cy + Gap);

                T1.Enabled = true;
                Invalidate();
            }
        }

        private void T1_Tick(object sender, System.EventArgs e)
        {
            Counter += 1;
            if (Counter == 62)
            {
                Counter = 0;
                cmdGo.Enabled = true;
                T1.Enabled = false;
                WholeBMP = SaveBMP;
            }

            TLpt.X -= 1;
            TLpt.Y -= 1;

            TRpt.X += 1;
            TRpt.Y -= 1;

            BLpt.X -= 1;
            BLpt.Y += 1;

            BRpt.X += 1;
            BRpt.Y += 1;

            // Initialize a color matrix.
            //Set the alpha for the whole image
            float[][] m ={new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, (1-(float)Counter/62), 0},
                    new float[] {0, 0, 0, 0, 1}};
            ColorMatrix cm = new ColorMatrix(m);

            // Create an ImageAttributes object and set its color matrix.
            Ia = new ImageAttributes();
            Ia.SetColorMatrix(cm, ColorMatrixFlag.Default,
                                    ColorAdjustType.Bitmap);

            TLBMP.RotateFlip(RotateFlipType.Rotate90FlipNone);
            TRBMP.RotateFlip(RotateFlipType.Rotate90FlipNone);
            BLBMP.RotateFlip(RotateFlipType.Rotate90FlipNone);
            BRBMP.RotateFlip(RotateFlipType.Rotate90FlipNone);

            Invalidate();
        }

    }
}
