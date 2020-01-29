//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ChangeImagealignmentinsideaControl.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Control
{ 
   public   class Control_5_ChangeImagealignmentinsideaControl:Form
    {
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnStandard;

        // Hold the current text alignment
        ContentAlignment currAlignment = ContentAlignment.MiddleCenter;
        int currEnumPos = 0;
        public   Control_5_ChangeImagealignmentinsideaControl()
       {


            InitializeComponent();

            // Set btnStandard as default accept.
            this.AcceptButton = btnStandard;

            CenterToScreen();
        }
        private void InitializeComponent()
        {
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStandard
            // 
            this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStandard.Location = new System.Drawing.Point(16, 80);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(312, 88);
            this.btnStandard.TabIndex = 2;
            this.btnStandard.Text = "Click to change the Image alignment";
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnImage.Image = new Bitmap("winter.jpg");
            this.btnImage.Location = new System.Drawing.Point(16, 192);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(312, 72);
            this.btnImage.TabIndex = 3;
            this.btnImage.Text = "Image Button";
            this.btnImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonForm
            // 
            this.AcceptButton = this.btnStandard;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(340, 269);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnImage,
                                     this.btnStandard,
                                    });
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ButtonForm";
            this.Text = "Buttons";
            this.ResumeLayout(false);

        }

        protected void btnStandard_Click(object sender, System.EventArgs e)
        {
            Array values = Enum.GetValues(currAlignment.GetType());

            currEnumPos++;
            if (currEnumPos >= values.Length)
                currEnumPos = 0;

            currAlignment = (ContentAlignment)ContentAlignment.Parse(currAlignment.GetType(),
                    values.GetValue(currEnumPos).ToString());

            btnImage.ImageAlign = currAlignment;
        }
    }
}
