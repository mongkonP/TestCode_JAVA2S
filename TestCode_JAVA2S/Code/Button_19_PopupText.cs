//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/PopupText.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_19_PopupText:Form
    {
        internal System.Windows.Forms.Button cmdDelete;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.HelpProvider hlp;
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public   Button_19_PopupText()
       {
            InitializeComponent();

        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.hlp = new System.Windows.Forms.HelpProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(20, 68);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(92, 20);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Delete";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(20, 16);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(92, 20);
            this.cmdAdd.TabIndex = 2;
            this.cmdAdd.Text = "Add";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tab to a button and press F1.";
            // 
            // PopupText
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.label1,
                                                                          this.cmdDelete,
                                                                          this.cmdAdd});
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Name = "PopupText";
            this.Text = "PopupText";
            this.Load += new System.EventHandler(this.PopupText_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private void PopupText_Load(object sender, System.EventArgs e)
        {
            hlp.SetHelpString(cmdAdd, "Choose another item from the catalog.");
            hlp.SetHelpString(cmdDelete, "Delete the selected item from your order.");
        }
    }
}
