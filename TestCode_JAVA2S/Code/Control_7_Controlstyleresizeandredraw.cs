//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Controlstyleresizeandredraw.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Control
{ 
   public   class Control_7_Controlstyleresizeandredraw:Form
    {
        private System.Windows.Forms.Button btnGetStyles;
        private System.ComponentModel.Container components;
        public   Control_7_Controlstyleresizeandredraw()
       {


            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
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
            this.btnGetStyles = new System.Windows.Forms.Button();
            this.btnGetStyles.Location = new System.Drawing.Point(24, 64);
            this.btnGetStyles.Size = new System.Drawing.Size(160, 23);
            this.btnGetStyles.TabIndex = 0;
            this.btnGetStyles.Text = "Get Form Styles";
            this.btnGetStyles.Click += new System.EventHandler(this.btnGetStyles_Click);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(211, 104);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnGetStyles });
            this.Text = "A Form with Style!";

        }


        private void btnGetStyles_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(GetStyle(ControlStyles.ResizeRedraw).ToString(),
              "Do you have ResizeRedraw?");
        }
    }
}
