//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ControlEnabled.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Control
{ 
   public   class Control_2_ControlEnabled:Form
    {
        private TextBox firstNameBox = new TextBox();
        private Button btnShowControls = new Button();
        public   Control_2_ControlEnabled()
       {


            this.Text = "Simple Controls";
            this.Width = 300;
            this.Height = 200;
            CenterToScreen();

            firstNameBox.Text = "Hello";
            firstNameBox.Size = new Size(150, 50);
            firstNameBox.Location = new Point(10, 10);
            this.Controls.Add(firstNameBox);

            btnShowControls.Text = "Click Me";
            btnShowControls.Size = new Size(90, 30);
            btnShowControls.Location = new Point(10, 70);
            btnShowControls.BackColor = Color.DodgerBlue;
            btnShowControls.Click += new EventHandler(btnShowControls_Clicked);
            this.Controls.Add(btnShowControls);
        }

        private void btnShowControls_Clicked(object sender, EventArgs e)
        {
            string ctrlInfo = "";
            foreach (Control c in this.Controls)
            {
                ctrlInfo += string.Format("Control: {0}\n", c.ToString());
            }
            MessageBox.Show(ctrlInfo, "Controls on Form");
            DisableAllButtons();
        }

        private void DisableAllButtons()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                    ((Button)c).Enabled = false;
            }
        }
    }
}
