//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ControlrendererDemoCheckBox.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TestCode_JAVA2S._Control
{ 
   public   class Control_3_ControlrendererDemoCheckBox:Form
    { 
       public   Control_3_ControlrendererDemoCheckBox()
       {


            InitializeComponent();

        }

        private void ControlRenderer_Paint(object sender, PaintEventArgs e)
        {

            CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(10, 10),
              new Rectangle(10, 10, 110, 15), "Style checkbox", Font, false, CheckBoxState.CheckedNormal);

        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ControlRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "ControlRenderer";
            this.Text = "ControlRenderer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlRenderer_Paint);
            this.ResumeLayout(false);

        }
    }
}
