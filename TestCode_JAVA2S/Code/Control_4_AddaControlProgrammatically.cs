//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AddaControlProgrammatically.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Control
{ 
   public   class Control_4_AddaControlProgrammatically:Form
    { 
       public   Control_4_AddaControlProgrammatically()
       {
            string[] foods = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };

            int topPosition = 10;
            foreach (string food in foods)
            {
                // Create a new check box.
                CheckBox checkBox = new CheckBox();
                checkBox.Left = 10;
                checkBox.Top = topPosition;
                topPosition += 30;
                checkBox.Text = food;

                // Add the check box to the form.
                this.Controls.Add(checkBox);
            }

        }
    }
}
