//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Displaycolordialogandgetuserselection.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._ColorDialog
{ 
   public   class ColorDialog_3_Displaycolordialogandgetuserselection:Form
    { 
       public   ColorDialog_3_Displaycolordialogandgetuserselection()
       {
            System.Windows.Forms.ColorDialog colorDlg = new System.Windows.Forms.ColorDialog();
            colorDlg.AnyColor = true;
            colorDlg.ShowHelp = true;

            if (colorDlg.ShowDialog() != DialogResult.Cancel)
            {
               this.Text = colorDlg.Color.ToString();
                this.BackColor = colorDlg.Color;
            }

        }
    }
}
