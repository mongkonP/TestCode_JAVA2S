//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Addbuttontoform.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_13_Addbuttontoform:Form
    {
        private Button button1 ;
        public   Button_13_Addbuttontoform()
       {
            Text = "A Simple Form";
            button1 = new Button();
            //            SuspendLayout();
            button1.Text = "Cancel";
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(72, 30);
            button1.Location = new System.Drawing.Point((ClientRectangle.Width - button1.Size.Width) / 2, ClientRectangle.Height - 35);
            Controls.AddRange(new System.Windows.Forms.Control[] { this.button1 });
            button1.Click += new System.EventHandler((o,e)=>
            {
                Application.Exit();

            });
            //            ResumeLayout (false);

        }
    }
}
