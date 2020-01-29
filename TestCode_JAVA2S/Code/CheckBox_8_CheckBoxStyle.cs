//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/CheckBoxStyle.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._CheckBox
{ 
   public   class CheckBox_8_CheckBoxStyle:Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_option1;
        private System.Windows.Forms.CheckBox chk_option2;
        private System.Windows.Forms.CheckBox chk_option3;
        private System.Windows.Forms.CheckBox chk_option4;
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public   CheckBox_8_CheckBoxStyle()
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
            this.chk_option1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_option2 = new System.Windows.Forms.CheckBox();
            this.chk_option3 = new System.Windows.Forms.CheckBox();
            this.chk_option4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_option1
            // 
            this.chk_option1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_option1.Location = new System.Drawing.Point(40, 24);
            this.chk_option1.Name = "chk_option1";
            this.chk_option1.Size = new System.Drawing.Size(192, 24);
            this.chk_option1.TabIndex = 0;
            this.chk_option1.Text = "Windows 2000 / Windows XP";
            this.chk_option1.ThreeState = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "The following products are developed by Microsoft Corp.";
            // 
            // chk_option2
            // 
            this.chk_option2.Location = new System.Drawing.Point(40, 56);
            this.chk_option2.Name = "chk_option2";
            this.chk_option2.Size = new System.Drawing.Size(192, 24);
            this.chk_option2.TabIndex = 0;
            this.chk_option2.Text = "JAVA";
            // 
            // chk_option3
            // 
            this.chk_option3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_option3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_option3.Location = new System.Drawing.Point(40, 88);
            this.chk_option3.Name = "chk_option3";
            this.chk_option3.Size = new System.Drawing.Size(192, 24);
            this.chk_option3.TabIndex = 0;
            this.chk_option3.Text = "Visual C# and .NET";
            // 
            // chk_option4
            // 
            this.chk_option4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_option4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_option4.Location = new System.Drawing.Point(40, 120);
            this.chk_option4.Name = "chk_option4";
            this.chk_option4.Size = new System.Drawing.Size(192, 24);
            this.chk_option4.TabIndex = 0;
            this.chk_option4.Text = "Oracle Database";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                          this.chk_option2,
                                          this.chk_option4,
                                          this.chk_option3,
                                          this.chk_option1});
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select All Correct Options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 216);
            this.button1.Name = "button1";
            this.button1.TabIndex = 3;
            this.button1.Text = "Done ";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBoxStyle
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(328, 253);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.button1,
                                      this.groupBox1,
                                      this.label1});
            this.Name = "CheckBoxStyle";
            this.Text = "Check Boxes";
            this.Load += new System.EventHandler(this.CheckBoxStyle_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        private void CheckBoxStyle_Load(object sender, System.EventArgs e)
        {
            // Load the Image that we want to display on the button
            Image imga = Image.FromFile("WRENCH.ICO");
            // Assign the Image for the checkbox
            chk_option3.Image = imga;
            // Align the image on the face of the checkbox
            chk_option3.ImageAlign = ContentAlignment.MiddleRight;
            // Select the background color for the checkbox
            chk_option3.BackColor = Color.LightBlue;

            // Load the Image that we want to display on the button
            imga = Image.FromFile("EYE.ICO");
            // Assign the Image for the checkbox
            chk_option4.Image = imga;
            // Align the image on the face of the checkbox
            chk_option4.ImageAlign = ContentAlignment.MiddleCenter;
            // Select the background color for the checkbox
            chk_option4.BackColor = Color.LightBlue;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string str_opt_selected = "Options Selected are ..\n";

            // Check which options are selected for every checkbox
            // using the Checked property

            if (chk_option1.Checked)
                str_opt_selected = str_opt_selected + chk_option1.Text + "\n";
            if (chk_option2.Checked)
                str_opt_selected = str_opt_selected + chk_option2.Text + "\n";
            if (chk_option3.Checked)
                str_opt_selected = str_opt_selected + chk_option3.Text + "\n";
            if (chk_option4.Checked)
                str_opt_selected = str_opt_selected + chk_option4.Text + "\n";

            MessageBox.Show(str_opt_selected, "Checked Options");

        }
    }
}
