//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Handlebuttonmessages.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_12_Handlebuttonmessages:Form
    {
        Button MyButton = new Button();
        public   Button_12_Handlebuttonmessages()
       {
            Text = "Respond to a Button";

            MyButton = new Button();
            MyButton.Text = "Press Here";
            MyButton.Location = new Point(100, 200);

            // Add button event handler to list. 
            MyButton.Click += new EventHandler((o,e)=>
            {
                if (MyButton.Top == 200)
                    MyButton.Location = new Point(10, 10);
                else
                    MyButton.Location = new Point(100, 200);

            });

            Controls.Add(MyButton);

        }
    }
}
