//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ButtonNameTabIndexText.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_2_ButtonNameTabIndexText:Form
    {
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        public   Button_2_ButtonNameTabIndexText()
       {
            this.label1 = new Label();
            this.textBox1 = new TextBox();
            this.button1 = new Button();
            this.SuspendLayout();

            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name:";

            this.textBox1.Location = new System.Drawing.Point(152, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";

            this.button1.Location = new System.Drawing.Point(109, 80);
            this.button1.Name = "button1";
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.Click += new System.EventHandler((o,e)=>
            {
                System.Console.WriteLine("User entered: " + textBox1.Text);
                MessageBox.Show("Welcome, " + textBox1.Text, "Visual C#");
            });

            this.ClientSize = new System.Drawing.Size(292, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Visual C#";

            this.ResumeLayout(false);

        }
    }
}
