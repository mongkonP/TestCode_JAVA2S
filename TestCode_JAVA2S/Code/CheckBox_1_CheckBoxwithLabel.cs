//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/CheckBoxwithLabel.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._CheckBox
{ 
   public   class CheckBox_1_CheckBoxwithLabel:Form
    {
        Label label;
        FontStyle fs = 0;
        FontStyle[] afs = { FontStyle.Bold, FontStyle.Italic, FontStyle.Underline, FontStyle.Strikeout };

        public CheckBox_1_CheckBoxwithLabel()
       {
            int cyText = Font.Height;
            int cxText = cyText / 2;
            string[] astrText = { "Bold", "Italic", "Underline", "Strikeout" };

            label = new Label();
            label.Parent = this;
            label.Text = "Sample Text";
            label.AutoSize = true;

            for (int i = 0; i < 4; i++)
            {
                CheckBox chkbox = new CheckBox();
                chkbox.Parent = this;
                chkbox.Text = astrText[i];
                chkbox.Location = new Point(2 * cxText, (4 + 3 * i) * cyText / 2);
                chkbox.Size = new Size(12 * cxText, cyText);
                chkbox.CheckedChanged += new EventHandler((o,e)=>
                {
                    for (int a = 0; a < 4; a++)
                        if (((CheckBox)Controls[a + 1]).Checked)
                            fs |= afs[a];

                    label.Font = new Font(label.Font, fs);

                });
            }

        }
    }
}
