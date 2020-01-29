//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AnchorStyleBottom.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Anchor
{ 
   public   class Anchor_3_AnchorStyleBottom:Form
    {
        private System.Windows.Forms.Button button1;
        public   Anchor_3_AnchorStyleBottom()
       {
            this.button1 = new System.Windows.Forms.Button();
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.button1 });
            this.Text = "Anchoring (and Docking) Controls";

            // anchor Bottom

            button1.Anchor = AnchorStyles.Bottom;
            button1.Dock = DockStyle.Left;
            button1.Text = "Anchor: " + button1.Anchor.ToString() +
              "\nDock: " + button1.Dock.ToString();
            CenterToScreen();

        }
    }
}
