//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ComboBoxwithcolorcellrenderer.htm


using System;using System.Drawing;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._ComboBox
{ 
   public   class ComboBox_6_ComboBoxwithcolorcellrenderer:Form
    {
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        ArrayList colorArray = new ArrayList();
        ArrayList fontArray = new ArrayList();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public   ComboBox_6_ComboBoxwithcolorcellrenderer()
       {


            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Location = new System.Drawing.Point(16, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBox1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox1_MeasureItem);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.MyItemSelected);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font Combo Box";
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.ItemHeight = 20;
            this.comboBox2.Location = new System.Drawing.Point(16, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(264, 26);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox2_DrawItem);
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.MyItemSelected);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color Combo Box";
            // 
            // ComboBox_6_ComboBoxwithcolorcellrenderer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(334, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Name = "ComboBox_6_ComboBoxwithcolorcellrenderer";
            this.Text = "OwnerDraw ComboBox";
            this.Load += new System.EventHandler(this.MyComboBox_Load);
            this.ResumeLayout(false);

        }
        #endregion



        private void MyComboBox_Load(object sender, System.EventArgs e)
        {
            // Fill an array with the different color you wish
            // to display in the ComboBox

            colorArray.Add(new SolidBrush(Color.Yellow));
            colorArray.Add(new SolidBrush(Color.Black));
            colorArray.Add(new SolidBrush(Color.Azure));
            colorArray.Add(new SolidBrush(Color.Firebrick));
            colorArray.Add(new SolidBrush(Color.DarkMagenta));

            // Add blank items to the list, since the text we will display
            // will be the name of the Color we are painting
            comboBox2.Items.Add("");
            comboBox2.Items.Add("");
            comboBox2.Items.Add("");
            comboBox2.Items.Add("");
            comboBox2.Items.Add("");


            // Fill an array with the different fonts that you will use to display 
            // items in the other comboBox

            fontArray.Add(new Font("Ariel", 15, FontStyle.Bold));
            fontArray.Add(new Font("Courier", 12, FontStyle.Italic));
            fontArray.Add(new Font("Veranda", 14, FontStyle.Bold));
            fontArray.Add(new Font("System", 10, FontStyle.Strikeout));
            fontArray.Add(new Font("Century SchoolBook", 15, FontStyle.Underline));

            // Add the items that in the listBox

            comboBox1.Items.Add("Washington");
            comboBox1.Items.Add("Houston");
            comboBox1.Items.Add("Phoenix");
            comboBox1.Items.Add("Dallas");
            comboBox1.Items.Add("London");

        }

        private void comboBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            // Override this function to draw items in the Font comboBox

            // Get the Graphics Object (aka. CDC or Device Context Object )
            // passed via the DrawItemEventArgs parameter
            Graphics g = e.Graphics;

            // Get the bounding rectangle of the item currently being painted
            Rectangle r = e.Bounds;
            Font fn = null;

            if (e.Index >= 0)
            {
                // Get the Font object, at the specifid index in the fontArray
                fn = (Font)fontArray[e.Index];

                // Get the text that we wish to display
                string s = (string)comboBox1.Items[e.Index];

                // Set the string format options
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;

                Console.WriteLine(e.State.ToString());
                // Draw the rectangle
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), r);

                if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
                {
                    // if the item is not selected draw it with a different color
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
                    e.Graphics.DrawString(s, fn, new SolidBrush(Color.Black), r, sf);
                    e.DrawFocusRectangle();
                }
                else
                {
                    // if the item is selected draw it with a different color
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), r);
                    e.Graphics.DrawString(s, fn, new SolidBrush(Color.Red), r, sf);
                    e.DrawFocusRectangle();
                }
            }
        }

        private void comboBox2_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            // Override this function to draw items in the Color comboBox

            // Get the Graphics Object (aka. CDC or Device Context Object )
            // passed via the DrawItemEventArgs parameter
            Graphics g = e.Graphics;

            // Get the bounding rectangle of the item currently being painted
            Rectangle r = e.Bounds;

            if (e.Index >= 0)
            {
                Rectangle rd = r;
                rd.Width = 100;

                Rectangle rt = r;
              //  r.Left = rd.Right;

                // Get the brush object, at the specifid index in the colorArray
                SolidBrush b = (SolidBrush)colorArray[e.Index];
                // Fill a portion of the rectangle with the selected brush
                g.FillRectangle(b, rd);

                // Set the string format options
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;

                Console.WriteLine(e.State.ToString());

                // Draw the rectangle
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), r);

                if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
                {
                    // if the item is not selected draw it with a different color
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
                    e.Graphics.DrawString(b.Color.Name, new Font("Ariel", 8, FontStyle.Bold), new SolidBrush(Color.Black), r, sf);
                    e.DrawFocusRectangle();
                }
                else
                {
                    // if the item is selected draw it with a different color
                    e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), r);
                    e.Graphics.DrawString(b.Color.Name, new Font("Veranda", 12, FontStyle.Bold), new SolidBrush(Color.Red), r, sf);
                    e.DrawFocusRectangle();
                }
            }
        }

        private void MyItemSelected(object sender, System.EventArgs e)
        {
            // UnBox the sender. Since both the ComboBox controls use the same
            // events to handle the selection of item from the list

            ComboBox cb = null;
            if (sender.Equals(comboBox1))
                cb = comboBox1;
            else
                cb = comboBox2;

            // Get the index of the Item Selected
            int x = cb.SelectedIndex;

            string str = "";
            // Get the Text of the item selected
            if (sender.Equals(comboBox1))
            {
                str = "Item Selected is = " + (string)cb.Items[x];
            }
            else
            {
                SolidBrush br = (SolidBrush)colorArray[x];
                str = "Color Selected is = " + br.Color.Name;
            }

            MessageBox.Show(str, "ComboBox Item");
        }

        private void comboBox1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            // For the comboBox with OwnerDrawVariable property
            // Display every second item with a height of 45
            if (e.Index % 2 == 0)
            {
                e.ItemHeight = 45;
                e.ItemWidth = 20;
            }
            else
            {
                // Display all other items with a height of 25
                e.ItemHeight = 25;
                e.ItemWidth = 10;
            }
        }
    }
}
