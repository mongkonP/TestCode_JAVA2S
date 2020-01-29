//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AddaButton.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_11_AddaButton:Form
    {
        Button MyButton = new Button();
        public   Button_11_AddaButton()
       {
            Text = "Using a Button";

            MyButton = new Button();
            MyButton.Text = "Press Here";
            MyButton.Location = new Point(100, 200);

            Controls.Add(MyButton);

        }
    }
}
