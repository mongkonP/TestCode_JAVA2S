//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Addcontroltoawindow.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Console
{ 
   public   class Console_1_Addcontroltoawindow:Form
    { 
       public   Console_1_Addcontroltoawindow()
       {
            Text = "Hello World";

            Button btn1 = new Button();
            btn1.Text = "Click Me";
            this.Controls.Add(btn1);

            btn1.Click += new EventHandler((o,e)=>
            {
                Text = "Sender: " + o.ToString() + " - Event: " + e.ToString();
            });
            btn1.Click +=  new EventHandler((o, e) =>
            {
                Console.WriteLine(String.Format("Sender: {0} - Event: {1}", o.ToString(), e.ToString()));
            });

        }
    }
}
