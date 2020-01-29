//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/DateTimePickerDemo.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Calendar
{ 
   public   class Calendar_3_DateTimePickerDemo:Form
    {
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public   Calendar_3_DateTimePickerDemo()
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:s : MM/dd/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "h/mm/ss : dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "HH-mm-ss : MMMM/dd/yyyy  tt";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(16, 88);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "tt hh/mm/ss : dddd.MMMM.yyyy";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(16, 200);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker4.TabIndex = 0;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "HH/mm/ss : ddd-MM-yy";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(16, 160);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker5.TabIndex = 0;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "hh/mm/ss : dddd MMMM yyyy tt";
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(16, 128);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker6.TabIndex = 0;
            this.dateTimePicker6.Value = new System.DateTime(2002, 5, 14, 14, 28, 0, 0);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format : hh:mm:ss : MM/dd/yy";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format : h/mm/ss : dd.MM.yyyy";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Format : HH-mm-ss : MMMM/dd/yyyy  tt";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 160);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(352, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Format : HH/mm/ss : ddd-MM-yy";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Format : hh/mm/ss : dddd MMMM yyyy tt";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Format : tt hh/mm/ss : dddd.MMMM.yyyy";
            // 
            // DateTimePicker1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(632, 245);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.label7,
                                                                          this.label4,
                                                                          this.label5,
                                                                          this.label3,
                                                                          this.label2,
                                                                          this.label1,
                                                                          this.dateTimePicker1,
                                                                          this.dateTimePicker2,
                                                                          this.dateTimePicker3,
                                                                          this.dateTimePicker4,
                                                                          this.dateTimePicker5,
                                                                          this.dateTimePicker6});
            this.Name = "DateTimePicker1";
            this.Text = "DateTime Formats";
            this.Load += new System.EventHandler(this.DateTimePicker1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void DateTimePicker1_Load(object sender, System.EventArgs e)
        {
        }
    }
}
