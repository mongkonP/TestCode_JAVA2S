//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AddquotationchartoButtontext.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_6_AddquotationchartoButtontext:Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button cmdAsyncState;

        public   Button_6_AddquotationchartoButtontext()
       {
            InitializeComponent();

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lbl.Text = "Key Down: " + e.KeyValue.ToString();
            lbl.Text += "\nKey Code: " + e.KeyCode.ToString();
            lbl.Text += "\nKey Data: " + e.KeyData.ToString();

            if ((e.Modifiers & Keys.Shift) == Keys.Shift)
            {
                lbl.Text += "\n" + "Shift was held down.";
            }

            if ((e.Modifiers & Keys.Control) == Keys.Control)
            {
                lbl.Text += "\n" + "Control was held down.";
            }
            if (e.Alt)
            {
                lbl.Text += "\n" + "Alt was held down.";
            }
        }

        private void cmdAsyncState_Click(object sender, EventArgs e)
        {
            int state = Convert.ToInt32(GetAsyncKeyState(Keys.A).ToString());
            switch (state)
            {
                case 0:
                    lbl.Text = "A has not been pressed since the last call.";
                    break;
                case 1:
                    lbl.Text = "A is not currently pressed, but has been pressed since the last call.";
                    break;
                case -32767:
                    lbl.Text = "A is currently pressed.";
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.cmdAsyncState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "<Text will never appear here>";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(35, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 0);
            this.lbl.TabIndex = 1;
            // 
            // cmdAsyncState
            // 
            this.cmdAsyncState.Location = new System.Drawing.Point(36, 202);
            this.cmdAsyncState.Name = "cmdAsyncState";
            this.cmdAsyncState.Size = new System.Drawing.Size(141, 24);
            this.cmdAsyncState.TabIndex = 2;
            this.cmdAsyncState.Text = "GetAsyncState() for \"A\"";
            this.cmdAsyncState.Click += new System.EventHandler(this.cmdAsyncState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.cmdAsyncState);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "KeyTest";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
