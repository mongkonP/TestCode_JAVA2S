//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ButtonLocaltion.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_3_ButtonLocaltion:Form
    { 
       public   Button_3_ButtonLocaltion()
       {
            Text = "Simple Button";

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Click Me!";
            btn.Location = new Point(100, 100);
            btn.Click += new EventHandler((o,e) =>
            {
                Graphics grfx = CreateGraphics();
                Point ptText = Point.Empty;
                string str = "Button clicked!";

                grfx.DrawString(str, Font, new SolidBrush(ForeColor), ptText);
                grfx.Dispose();
            });

        }
    }
}
