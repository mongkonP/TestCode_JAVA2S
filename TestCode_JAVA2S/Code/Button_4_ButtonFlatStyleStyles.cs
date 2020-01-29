//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ButtonFlatStyleStyles.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_4_ButtonFlatStyleStyles:Form
    { 
       public   Button_4_ButtonFlatStyleStyles()
       {
            int y = 0;

            foreach (FlatStyle fs in Enum.GetValues(typeof(FlatStyle)))
            {
                Button btn = new Button();
                btn.Parent = this;
                btn.FlatStyle = fs;
                btn.Text = fs.ToString();
                btn.Location = new Point(50, y += 50);
            }

        }
    }
}
