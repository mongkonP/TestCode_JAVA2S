//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/BitmapViewerHost.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.IO;

namespace TestCode_JAVA2S._Bitmap
{ 
   public   class Bitmap_5_BitmapViewerHost:Form
    {
        private BitmapViewer bitmapViewer1;
        private System.ComponentModel.Container components = null;
        public   Bitmap_5_BitmapViewerHost()
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

        private void InitializeComponent()
        {
            this.bitmapViewer1 = new TestCode_JAVA2S._Bitmap.BitmapViewer();
            this.SuspendLayout();
            // 
            // bitmapViewer1
            // 
            this.bitmapViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bitmapViewer1.Dimension = 80;
            this.bitmapViewer1.Directory = null;
            this.bitmapViewer1.Location = new System.Drawing.Point(12, 12);
            this.bitmapViewer1.Name = "bitmapViewer1";
            this.bitmapViewer1.Padding = new System.Windows.Forms.Padding(1);
            this.bitmapViewer1.Size = new System.Drawing.Size(1187, 541);
            this.bitmapViewer1.Spacing = 10;
            this.bitmapViewer1.TabIndex = 0;
            this.bitmapViewer1.PictureSelected += new TestCode_JAVA2S._Bitmap.BitmapViewer.PictureSelectedDelegate(this.bitmapViewer1_PictureSelected);
            // 
            // Bitmap_5_BitmapViewerHost
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1446, 815);
            this.Controls.Add(this.bitmapViewer1);
            this.Name = "Bitmap_5_BitmapViewerHost";
            this.Text = "BitmapViewerHost";
            this.Load += new System.EventHandler(this.BitmapViewerHost_Load);
            this.ResumeLayout(false);

        }
        private void BitmapViewerHost_Load(object sender, System.EventArgs e)
        {
            bitmapViewer1.Directory = Application.StartupPath;
            bitmapViewer1.Directory = "F:\\รูปพนักงาน2019";
        }

        private void bitmapViewer1_PictureSelected(object sender, PictureSelectedEventArgs e)
        {
            MessageBox.Show("You chose " + e.FileName);
        }


    }
    /// <summary>
    /// Summary description for BitmapViewer.
    /// </summary>
    public class BitmapViewer : System.Windows.Forms.UserControl
    {
        internal System.Windows.Forms.Panel pnlPictures;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public BitmapViewer()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call

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

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPictures = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPictures
            // 
            this.pnlPictures.AutoScroll = true;
            this.pnlPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPictures.Location = new System.Drawing.Point(1, 1);
            this.pnlPictures.Name = "pnlPictures";
            this.pnlPictures.Size = new System.Drawing.Size(530, 218);
            this.pnlPictures.TabIndex = 1;
            // 
            // BitmapViewer
            // 
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.pnlPictures});
            this.DockPadding.All = 1;
            this.Name = "BitmapViewer";
            this.Size = new System.Drawing.Size(532, 220);
            this.ResumeLayout(false);

        }
        #endregion

        public delegate void PictureSelectedDelegate(object sender, PictureSelectedEventArgs e);
        public event PictureSelectedDelegate PictureSelected;

        // The directory that will be scanned for image.
        private string directory = "";

        // Each picture box will be a square of dimension X dimension pixels.
        private int dimension;

        // The space between the images and the top, left, and right sides.
        private int border = 5;

        // The space between each image.
        private int spacing;

        // The images that were found in the selected directory.
        private ArrayList images = new ArrayList();


        public string Directory
        {
            get
            {
                return directory;
            }
            set
            {
                directory = value;
                GetImages();
                UpdateDisplay();
            }
        }

        public int Dimension
        {
            get
            {
                return dimension;
            }
            set
            {
                dimension = value;
                UpdateDisplay();
            }
        }

        public int Spacing
        {
            get
            {
                return spacing;
            }
            set
            {
                spacing = value;
                UpdateDisplay();
            }
        }



        private void GetImages()
        {
            images.Clear();
            if (this.Directory != "" && this.directory != null)
            {
                DirectoryInfo dir = new DirectoryInfo(directory);
                foreach (FileInfo file in dir.GetFiles("*.jpg"))
                {
                    images.Add(new NamedImage(Bitmap.FromFile(file.FullName), file.Name));
                }
            }
        }

        private void UpdateDisplay()
        {
            // Clear the current display.
            pnlPictures.Controls.Clear();

            // Row and Col will track the current position where pictures are
            // being inserted. They begin at the top-right corner.
            int row = border, col = border;

            // Iterate through the Images collection, and create PictureBox controls.
            foreach (NamedImage image in images)
            {
                PictureBox pic = new PictureBox();
                pic.Image = image.Image;
                pic.Tag = image.FileName;
                pic.Size = new Size(dimension, dimension);
                pic.Location = new Point(col, row);
                pic.BorderStyle = BorderStyle.FixedSingle;

                // StrechImage mode gives us the "thumbnail" ability.
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                // Display the picture.
                pnlPictures.Controls.Add(pic);

                // Move to the next column.
                col += dimension + spacing;

                // Handle the event.
                pic.Click += new EventHandler(this.pic_Click);

                // Move to next line if no more pictures will fit.
                if ((col + dimension + spacing + border) > this.Width)
                {
                    col = border;
                    row += dimension + spacing;
                }
            }

        }


        public void RefreshImages()
        {
            GetImages();
            UpdateDisplay();
        }


        protected override void OnSizeChanged(System.EventArgs e)
        {
            UpdateDisplay();
            base.OnSizeChanged(e);
        }


        private PictureBox picSelected;

        private void pic_Click(object sender, System.EventArgs e)
        {
            // Clear the border style from the last selected picture box.
            if (picSelected != null)
            {
                picSelected.BorderStyle = BorderStyle.FixedSingle;
            }

            // Get the new selection.
            picSelected = (PictureBox)sender;
            picSelected.BorderStyle = BorderStyle.Fixed3D;

            // Fire the selection event.
            PictureSelectedEventArgs args = new
                PictureSelectedEventArgs((string)picSelected.Tag, picSelected.Image);
            if (PictureSelected != null)
            {
                PictureSelected(this, args);
            }

        }



        private class NamedImage
        {
            public Image Image;
            public string FileName;

            public NamedImage(Image image, string fileName)
            {
                this.Image = image;
                this.FileName = fileName;
            }
        }


    }
    public class PictureSelectedEventArgs : EventArgs
    {
        public string FileName;
        public Image Image;

        public PictureSelectedEventArgs(String fileName, Image image)
        {
            this.FileName = fileName;
            this.Image = image;
        }

    }

}
