//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Buttonclickaction.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_14_Buttonclickaction:Form
    {
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.Container components = null;
        public   Button_14_Buttonclickaction()
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Buttons_OnMouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Buttons_OnMouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Buttons_OnMouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.Buttons_OnMouseLeave);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(38, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 147);
            this.listBox1.TabIndex = 0;
            // 
            // FormAddControls
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.button2,
                                      this.button1,
                                      this.textBox1,
                                      this.listBox1});
            this.Name = "FormAddControls";
            this.Text = "FormAddControls";
            this.ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            string strAdd = textBox1.Text;
            if (listBox1.FindString(strAdd, -1) < 0)
            {
                listBox1.Items.Add(strAdd);
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            MessageBox.Show("\"" + strAdd + "\" is already in the list box", "Duplicate");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Buttons_OnMouseEnter(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
        }

        private void Buttons_OnMouseLeave(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = SystemColors.Control;
        }

    }
}
