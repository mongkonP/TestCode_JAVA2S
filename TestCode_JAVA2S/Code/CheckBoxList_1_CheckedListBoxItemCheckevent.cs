//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/CheckedListBoxItemCheckevent.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._CheckBoxList
{ 
   public   class CheckBoxList_1_CheckedListBoxItemCheckevent:Form
    {
        private System.Windows.Forms.CheckedListBox inputCheckedListBox;
        private System.Windows.Forms.ListBox displayListBox;
        public   CheckBoxList_1_CheckedListBoxItemCheckevent()
       {


            InitializeComponent();
        }
        private void inputCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = inputCheckedListBox.SelectedItem.ToString();

            if (e.NewValue == CheckState.Checked)
                displayListBox.Items.Add(item);
            else
                displayListBox.Items.Remove(item);
        }
        private void InitializeComponent()
        {
            this.inputCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // inputCheckedListBox
            // 
            this.inputCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCheckedListBox.FormattingEnabled = true;
            this.inputCheckedListBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.inputCheckedListBox.Location = new System.Drawing.Point(17, 12);
            this.inputCheckedListBox.Name = "inputCheckedListBox";
            this.inputCheckedListBox.Size = new System.Drawing.Size(202, 188);
            this.inputCheckedListBox.TabIndex = 0;
            this.inputCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.inputCheckedListBox_ItemCheck);
            // 
            // displayListBox
            // 
            this.displayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 20;
            this.displayListBox.Location = new System.Drawing.Point(236, 12);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(190, 184);
            this.displayListBox.TabIndex = 1;
            // 
            // CheckedListBoxTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 211);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.inputCheckedListBox);
            this.Name = "CheckedListBoxTestForm";
            this.Text = "CheckedListBoxTest";
            this.ResumeLayout(false);

        }
    }
}
