//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/DateTimePicker2.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Calendar
{ 
   public   class Calendar_4_DateTimePicker2:Form
    {
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public Calendar_4_DateTimePicker2()
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.TabIndex = 0;
            // 
            // DateTimePicker2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(216, 61);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.dateTimePicker1});
            this.Name = "DateTimePicker2";
            this.Text = "DateTimePicker";
            this.Load += new System.EventHandler(this.DateTimePicker2_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void DateTimePicker2_Load(object sender, System.EventArgs e)
        {

        }
    }
    
}
