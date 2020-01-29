//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ChangeButtontext.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_9_ChangeButtontext:Form
    {
        Button pushMeButton;
        public   Button_9_ChangeButtontext()
       {
            pushMeButton = new Button();
            pushMeButton.Text = "Push Me";
            pushMeButton.Height = 60;
            pushMeButton.Width = 80;
            pushMeButton.Top = 60;
            pushMeButton.Left = 60;

            pushMeButton.Click += new EventHandler((o,e)=>
            {
                Button b = (Button)o;
                if (b.Text == "Push Me")
                {
                    b.Text = "Ouch";
                }
                else
                {
                    b.Text = "Push Me";
                }
            });

            this.Controls.Add(pushMeButton);

            this.Height = 200;
            this.Width = 200;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Visible = true;

        }
    }
}
