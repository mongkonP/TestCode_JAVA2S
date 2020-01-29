//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/CheckBoxclickSelectedUnselectedevent.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._CheckBox
{ 
   public   class CheckBox_6_CheckBoxclickSelectedUnselectedevent:Form
    {
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;

        private System.Windows.Forms.Label outputLabel;

        public   CheckBox_6_CheckBoxclickSelectedUnselectedevent()
       {


            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            this.boldCheckBox.Location = new System.Drawing.Point(72, 56);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(48, 24);
            this.boldCheckBox.TabIndex = 1;
            this.boldCheckBox.Text = "Bold";

            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.boldCheckBox_CheckedChanged);

            this.outputLabel.Location = new System.Drawing.Point(64, 24);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(152, 16);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "WWW.JAVA2S.COM";

            this.italicCheckBox.Location = new System.Drawing.Point(160, 56);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 24);
            this.italicCheckBox.TabIndex = 1;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.italicCheckBox_CheckedChanged);

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(264, 109);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
               this.italicCheckBox,this.boldCheckBox,this.outputLabel });
            this.Name = "CheckBoxTest";
            this.Text = "CheckBoxTest";
            this.ResumeLayout(false);

        }
        private void boldCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font.Name, outputLabel.Font.Size,
               outputLabel.Font.Style ^ FontStyle.Bold);
        }

        private void italicCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            outputLabel.Font = new Font(outputLabel.Font.Name,
               outputLabel.Font.Size, outputLabel.Font.Style ^ FontStyle.Italic);
        }
    }
}
