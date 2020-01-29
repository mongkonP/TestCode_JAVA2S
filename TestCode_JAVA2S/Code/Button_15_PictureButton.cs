//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/PictureButton.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_15_PictureButton:Form
    {
        private SMKPictureButton button1;
        private System.Windows.Forms.ImageList ButtonImageList;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.IContainer components;
        public   Button_15_PictureButton()
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
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Button_15_PictureButton));
            this.ButtonImageList = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new SMKPictureButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonImageList
            // 
            this.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ButtonImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.ButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonImageList.ImageStream")));
            this.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageList = this.ButtonImageList;
            this.button1.Location = new System.Drawing.Point(24, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 104);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buttons with Rounded Edges";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(344, 149);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.label1,
                                      this.button1});
            this.Name = "Form1";
            this.Text = "Button Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Call the Buttons Init function here.
            // This is where the Rounded Rectangle Region is created
            // and the window is set to as this region
            button1.Init();
        }
    }


    public class SMKPictureButton : System.Windows.Forms.ButtonBase
    {
        // Import the CreateRoundRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRoundRectRgn")]
        private static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

        // Import the CreateRectRgn function from the GDI32.DLL 
        // From the Unmanaged Code
        [DllImport("GDI32.DLL", EntryPoint = "CreateRectRgn")]
        private static extern int CreateRectRgn(int x1, int y1, int x2, int y2);

        // Import the SetWindowRgn function from the user32.DLL
        // From the Unmanaged Code
        [DllImport("user32.DLL", EntryPoint = "SetWindowRgn")]
        private static extern int SetWindowRgn(int hWnd, int hRgn, int bRedraw);


        Font f1 = new System.Drawing.Font("System", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f2 = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
        Font f3 = new System.Drawing.Font("Courier", 10F, System.Drawing.FontStyle.Regular | System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

        int rg;
        int hdl;

        public SMKPictureButton()
        {
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            // Override the MouseDown function to set a new image
            // Display Image No 1 from ButtonImageList when mouse is clicked on the button
            ImageIndex = 1;
            Text = "SMILING FACE (MOUSE DOWN)";
            Font = f1;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            // Override the MouseLeave function to set a new image
            // Display Image No 2 from ButtonImageList when mouse leaves the button
            ImageIndex = 2;
            Text = "HAPPY FACE (MOUSE LEAVE)";
            Font = f2;
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            // Override the MouseEnter function to set a new image
            // Display Image No 0 from ButtonImageList when mouse enters the button area
            ImageIndex = 0;
            Text = "SAD FACE (MOUSE ENTER)";
            Font = f3;
            Invalidate();
        }

        public void Init()
        {
            // Get the dimension of the client rectangle 
            Rectangle rect = this.ClientRectangle;
            // Invoke the unmanaged DLL function here to create the RoundRectangleRegion
            rg = CreateRoundRectRgn(rect.Left + 10, rect.Top + 10, rect.Right, rect.Bottom, 50, 50);
            // Get the handle to the window. 
            hdl = this.Handle.ToInt32();
            // Set the Window Region to a a Rectangle with rounded corners
            SetWindowRgn(hdl, rg, 1);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Override this function, since we do not want the control
            // to paint the button. We want to do all the painting ourselves

            // Get the Graphics Object ( .aka. the CDC or the Device Context Object ) 
            Graphics g = e.Graphics;

            // Get the Bounding Rectnalge for the button
            Rectangle rect = e.ClipRectangle;

            // Paint the rectangle with the color you want
            g.FillRectangle(new SolidBrush(Color.LightYellow), rect);

            rect.Inflate(5, 5);

            // Define a StringFormat Object to display the string in your custom format
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            // Get the current Image that we have set depending on the location of 
            // mouse on the contol.  Refer to the OnMouseDown,OnMouseEnter,OnMouseLeave events
            if (ImageIndex >= 0)
            {
                Image ig = this.ImageList.Images[ImageIndex];

                // Initialize the rectangle where you want the Image
                Rectangle rimg = rect;
                rimg.X += rect.Right / 2 - 16;
                rimg.Y += rect.Bottom - 90;
                rimg.Width = 32;
                rimg.Height = 32;

                // Draw the Image
                g.DrawImage(ig, rimg, 0, 0, 32, 32, GraphicsUnit.Pixel);
            }

            // Draw the String in the rectngle region you want
            rect.Y = rect.Bottom - 75;
            g.DrawString(Text, Font, new SolidBrush(Color.Blue), rect, sf);
        }
    }


}
