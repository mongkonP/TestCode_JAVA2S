//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ButtonActionDemo.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_16_ButtonActionDemo:Form
    {
        Label label1 = new Label();
        TextBox textBox1 = new TextBox();
        Button button1 = new Button();
        Label label2 = new Label();
        public   Button_16_ButtonActionDemo()
       {
            label1.Location = new Point(56, 48);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Enter Ur Name : ";

            textBox1.Location = new Point(176, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 20);
            textBox1.Text = "";

            button1.Location = new Point(128, 104);
            button1.Name = "button1";
            button1.Text = "Click Me";

            label2.Location = new Point(88, 192);
            label2.Name = "label2";

            button1.Click += new System.EventHandler((o,e)=>
            {
                label2.Text = "Thanks a Lot ";

            });

            //Controls.AddRange(new Control[]
            //{label2, button1, textBox1, label1});
            //Instead of this u can use the Following

            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);

        }
    }
}
