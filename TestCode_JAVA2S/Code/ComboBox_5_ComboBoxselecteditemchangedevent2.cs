//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ComboBoxselecteditemchangedevent2.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._ComboBox
{ 
   public   class ComboBox_5_ComboBoxselecteditemchangedevent2:Form
    {
        private RadioButton square = new RadioButton();
        private RadioButton circle = new RadioButton();
        private ComboBox color = new ComboBox();

        private Color c = Color.Red;
        public   ComboBox_5_ComboBoxselecteditemchangedevent2()
       {


            Text = "Select Item";
            square.Text = "Square";
            circle.Text = "Circle";
            color.Text = "Choose a color";

            Size = new Size(400, 250);

            int w = 20;
            square.Location = new Point(w, 30);
            circle.Location = new Point(w += 10 + square.Width, 30);
            color.Location = new Point(w += 10 + circle.Width, 30);

            color.Items.Add("Red");
            color.Items.Add("Green");
            color.Items.Add("Blue");

            Controls.Add(square);
            Controls.Add(circle);
            Controls.Add(color);

            square.CheckedChanged += new EventHandler(Checked_Changed);

            circle.CheckedChanged += new EventHandler(Checked_Changed);

            color.SelectedIndexChanged += new EventHandler(Selected_Index);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(c);
            if (square.Checked)
                g.FillRectangle(brush, 100, 100, 100, 100);
            else
                g.FillEllipse(brush, 100, 100, 100, 100);
            base.OnPaint(e);
        }

        protected void Selected_Index(Object sender, EventArgs e)
        {
            if (color.SelectedItem.ToString() == "Red")
                c = Color.Red;
            else if (color.SelectedItem.ToString() == "Green")
                c = Color.Green;
            else
                c = Color.Blue;
            Invalidate();
        }

        protected void Checked_Changed(Object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
