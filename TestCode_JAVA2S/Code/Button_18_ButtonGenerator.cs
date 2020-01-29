//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ButtonGenerator.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_18_ButtonGenerator:Form
    {
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtLeft;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button cmdCreate;
        internal System.Windows.Forms.TextBox txtTop;
        internal System.Windows.Forms.StatusBar status;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public   Button_18_ButtonGenerator()
       {

            InitializeComponent();
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.StatusBar();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right);
            this.GroupBox2.Location = new System.Drawing.Point(0, 180);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(368, 4);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                    this.Label1,
                                                                                    this.txtLeft,
                                                                                    this.Label2,
                                                                                    this.cmdCreate,
                                                                                    this.txtTop});
            this.GroupBox1.Location = new System.Drawing.Point(12, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(168, 128);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Left:";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(76, 52);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(68, 21);
            this.txtLeft.TabIndex = 4;
            this.txtLeft.Text = "200";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Top:";
            // 
            // cmdCreate
            // 
            this.cmdCreate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdCreate.Location = new System.Drawing.Point(36, 84);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(112, 28);
            this.cmdCreate.TabIndex = 2;
            this.cmdCreate.Text = "Create Button";
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // txtTop
            // 
            this.txtTop.Location = new System.Drawing.Point(76, 24);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(68, 21);
            this.txtTop.TabIndex = 3;
            this.txtTop.Text = "50";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 184);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(372, 22);
            this.status.TabIndex = 8;
            // 
            // ButtonGenerator
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(372, 206);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.GroupBox2,
                                                                          this.GroupBox1,
                                                                          this.status});
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Name = "ButtonGenerator";
            this.Text = "Button Generator";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private int buttonCount = 0;

        private void cmdCreate_Click(object sender, System.EventArgs e)
        {
            buttonCount++;

            // Create the button.
            Button newButton = new Button();
            newButton.Text = "Button " + buttonCount.ToString();
            newButton.Left = int.Parse(txtLeft.Text);
            newButton.Top = int.Parse(txtTop.Text);

            // Attach the event handler.
            newButton.Click += new EventHandler(ButtonHandler);

            this.Controls.Add(newButton);

        }


        private void ButtonHandler(object sender, System.EventArgs e)
        {
            status.Text = " You clicked ... ";
            status.Text += ((Button)sender).Text;
        }
    }
}
