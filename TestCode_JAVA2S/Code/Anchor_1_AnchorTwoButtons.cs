//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AnchorTwoButtons.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Anchor
{ 
   public   class Anchor_1_AnchorTwoButtons:Form
    { 
       public   Anchor_1_AnchorTwoButtons()
       {
            ResizeRedraw = true;

            int cxBtn = 5 * Font.Height;
            int cyBtn = 2 * Font.Height;
            int dxBtn = Font.Height;

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "&Larger";
            btn.Location = new Point(dxBtn, dxBtn);
            btn.Size = new Size(cxBtn, cyBtn);
            btn.Click += new EventHandler((o,e)=>
            {
                Console.WriteLine("large");
            });

            btn = new Button();
            btn.Parent = this;
            btn.Text = "&Smaller";
            btn.Location = new Point(ClientSize.Width - cxBtn - dxBtn,
                                     ClientSize.Height - cyBtn - dxBtn);
            btn.Size = new Size(cxBtn, cyBtn);
            btn.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            btn.Click +=  new EventHandler((o, e) =>
            {
                Console.WriteLine("Small");
            });

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Anchor_1_AnchorTwoButtons
            // 
            this.ClientSize = new System.Drawing.Size(737, 393);
            this.Name = "Anchor_1_AnchorTwoButtons";
            this.ResumeLayout(false);

        }
    }
}
