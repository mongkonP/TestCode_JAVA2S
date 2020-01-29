//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Getallcontrolsonaformwindow.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Control
{ 
   public   class Control_6_Getallcontrolsonaformwindow:Form
    {
        private TextBox firstNameBox = new TextBox();
        private Button btnShowControls = new Button();
        public   Control_6_Getallcontrolsonaformwindow()
       {


            this.Text = "Controls in the raw";

            // Add a new text box.
            firstNameBox.Text = "Chucky";
            firstNameBox.Size = new Size(150, 50);
            firstNameBox.Location = new Point(10, 10);
            this.Controls.Add(firstNameBox);

            // Add a new button.
            btnShowControls.Text = "Examine Controls collection";
            btnShowControls.Size = new Size(90, 90);
            btnShowControls.Location = new Point(10, 70);
            btnShowControls.Click +=
              new EventHandler(btnShowControls_Clicked);
            this.Controls.Add(btnShowControls);
            CenterToScreen();

        }
        protected void btnShowControls_Clicked(object sender, EventArgs e)
        {
            Control.ControlCollection coll = this.Controls;
            foreach (Control c in coll)
            {
                if (c != null)
                    Console.WriteLine(c.Text, "Index numb: " + coll.GetChildIndex(c, false));
            }
        }
    }
}
