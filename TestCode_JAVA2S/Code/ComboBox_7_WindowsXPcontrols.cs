//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/WindowsXPcontrols.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._ComboBox
{ 
   public   class ComboBox_7_WindowsXPcontrols:Form
    {

        internal System.Windows.Forms.HScrollBar HScrollBar1;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.TrackBar TrackBar1;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Button Button1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;


        public ComboBox_7_WindowsXPcontrols()
       {


            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.HScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // HScrollBar1
            // 
            this.HScrollBar1.Location = new System.Drawing.Point(24, 256);
            this.HScrollBar1.Name = "HScrollBar1";
            this.HScrollBar1.Size = new System.Drawing.Size(240, 20);
            this.HScrollBar1.TabIndex = 15;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(24, 216);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(128, 23);
            this.ProgressBar1.TabIndex = 14;
            this.ProgressBar1.Value = 30;
            // 
            // TrackBar1
            // 
            this.TrackBar1.Location = new System.Drawing.Point(16, 152);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(164, 45);
            this.TrackBar1.TabIndex = 13;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Location = new System.Drawing.Point(24, 116);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(160, 21);
            this.ComboBox1.TabIndex = 12;
            this.ComboBox1.Text = "ComboBox1";
            // 
            // RadioButton1
            // 
            this.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RadioButton1.Location = new System.Drawing.Point(24, 88);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(172, 16);
            this.RadioButton1.TabIndex = 11;
            this.RadioButton1.Text = "RadioButton1";
            // 
            // CheckBox1
            // 
            this.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBox1.Location = new System.Drawing.Point(24, 56);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(160, 20);
            this.CheckBox1.TabIndex = 10;
            this.CheckBox1.Text = "CheckBox1";
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Location = new System.Drawing.Point(24, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(104, 28);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "Button1";
            // 
            // WindowsXP
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 298);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.HScrollBar1,
                                                                          this.ProgressBar1,
                                                                          this.TrackBar1,
                                                                          this.ComboBox1,
                                                                          this.RadioButton1,
                                                                          this.CheckBox1,
                                                                          this.Button1});
            this.Name = "WindowsXP";
            this.Text = "Windows XP Controls";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
