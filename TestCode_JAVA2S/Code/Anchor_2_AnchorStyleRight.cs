//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AnchorStyleRight.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Anchor
{ 
   public   class Anchor_2_AnchorStyleRight:Form
    {
        private System.Windows.Forms.Button button1;
        public   Anchor_2_AnchorStyleRight()
       {
            this.button1 = new System.Windows.Forms.Button();
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.button1 });
            this.Text = "Anchoring (and Docking) Controls";

            // anchor Right

            button1.Anchor = AnchorStyles.Right;
            button1.Text = "Anchor: " + button1.Anchor.ToString() +
              "\nDock: " + button1.Dock.ToString();

            CenterToScreen();

        }
    }
}
