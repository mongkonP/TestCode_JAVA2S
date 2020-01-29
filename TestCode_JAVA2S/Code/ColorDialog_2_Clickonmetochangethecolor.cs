//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Clickonmetochangethecolor.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._ColorDialog
{ 
   public   class ColorDialog_2_Clickonmetochangethecolor:Form
    {
        private ColorDialog colorDlg;
        private Color currColor = Color.DimGray;
        public   ColorDialog_2_Clickonmetochangethecolor()
       {


            CenterToScreen();
            colorDlg = new ColorDialog();
            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
        }

        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (colorDlg.ShowDialog() != DialogResult.Cancel)
            {
                currColor = colorDlg.Color;
                this.BackColor = currColor;
                string strARGB = colorDlg.Color.ToString();
                MessageBox.Show(strARGB, "Color is:");
            }
        }
    }
}
