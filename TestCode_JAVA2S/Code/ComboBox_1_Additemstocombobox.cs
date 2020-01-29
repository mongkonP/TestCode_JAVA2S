//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Additemstocombobox.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._ComboBox
{ 
   public   class ComboBox_1_Additemstocombobox:Form
    {
        private Button draw = new Button();
        private ComboBox color = new ComboBox();

        public   ComboBox_1_Additemstocombobox()
       {


            draw.Text = "Draw";
            color.Text = "Choose a color";
            Size = new Size(500, 250);

            int w = 20;
            draw.Location = new Point(20, 30);
            color.Location = new Point(w += 10 + color.Width, 30);

            color.Items.Add("Red");
            color.Items.Add("Green");
            color.Items.Add("Blue");

            Controls.Add(draw);
            Controls.Add(color);

            draw.Click += new EventHandler(Draw_Click);
        }

        protected void Draw_Click(Object sender, EventArgs e)
        {
            if (color.SelectedItem.ToString() == "Red")
                Console.WriteLine("It is red.");
            else if (color.SelectedItem.ToString() == "Green")
                Console.WriteLine("It is green.");
            else
                Console.WriteLine("It is blue.");
        }
    }
}
