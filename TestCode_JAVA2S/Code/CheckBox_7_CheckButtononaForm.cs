//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/CheckButtononaForm.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._CheckBox
{ 
   public   class CheckBox_7_CheckButtononaForm:Form
    {
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.IContainer components;

        public CheckBox_7_CheckButtononaForm()
       {

            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            checkBox1.Appearance = Appearance.Button;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(72, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 32);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            // 
            // FormCheckButton
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.button1,
                                      this.checkBox1});
            this.Name = "FormCheckButton";
            this.Text = "FormCheckButton";
            this.ResumeLayout(false);

        }
        #endregion
    }
}
