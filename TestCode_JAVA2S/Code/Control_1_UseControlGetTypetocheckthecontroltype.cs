//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/UseControlGetTypetocheckthecontroltype.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Control
{ 
   public   class Control_1_UseControlGetTypetocheckthecontroltype:Form
    { 
       public   Control_1_UseControlGetTypetocheckthecontroltype()
       {


            int cyText = Font.Height;
            int cxText = cyText / 2;
            FontStyle[] afs = { FontStyle.Bold,      FontStyle.Italic,
                              FontStyle.Underline, FontStyle.Strikeout };

            Label label = new Label();
            label.Parent = this;
            label.Text = "Sample Text";

            for (int i = 0; i < 4; i++)
            {
                FontStyleCheckBox chkbox = new FontStyleCheckBox();
                chkbox.Parent = this;
                chkbox.Text = afs[i].ToString();
                chkbox.fontstyle = afs[i];
                chkbox.Location = new Point(2 * cxText,
                                                (4 + 3 * i) * cyText / 2);
                chkbox.Size = new Size(12 * cxText, cyText);
                chkbox.CheckedChanged += new EventHandler(CheckBoxOnCheckedChanged);
            }
        }
        void CheckBoxOnCheckedChanged(object obj, EventArgs ea)
        {
            FontStyle fs = 0;
            Label label = null;

            for (int i = 0; i < Controls.Count; i++)
            {
                Control ctrl = Controls[i];

                if (ctrl.GetType() == typeof(Label))
                    label = (Label)ctrl;
                else if (ctrl.GetType() == typeof(FontStyleCheckBox))
                    if (((FontStyleCheckBox)ctrl).Checked)
                        fs |= ((FontStyleCheckBox)ctrl).fontstyle;
            }
            label.Font = new Font(label.Font, fs);
        }
    }
    class FontStyleCheckBox : CheckBox
    {
        public FontStyle fontstyle;
    }
}
