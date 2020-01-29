//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Addtwoactionlistenerstoabutton.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_10_Addtwoactionlistenerstoabutton:Form
    { 
       public   Button_10_Addtwoactionlistenerstoabutton()
       {
            Text = "Hello World";

            Button btn1 = new Button();
            btn1.Text = "Click Me";
            this.Controls.Add(btn1);

            btn1.Click += new EventHandler(btn1_onclick);
            btn1.Click += new EventHandler(btn1_onclick2);

        }
        void btn1_onclick(object sender, EventArgs e)
        {
            Text = "Sender: " + sender.ToString() + " - Event: " + e.ToString();
        }

        void btn1_onclick2(object sender, EventArgs e)
        {
            Console.WriteLine(String.Format("Sender: {0} - Event: {1}", sender.ToString(), e.ToString()));
        }
    }
}
