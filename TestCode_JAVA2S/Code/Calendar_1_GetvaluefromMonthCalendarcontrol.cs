//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/GetvaluefromMonthCalendarcontrol.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Calendar
{ 
   public   class Calendar_1_GetvaluefromMonthCalendarcontrol:Form
    {
        private System.Windows.Forms.ToolTip calendarTip;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox comboSalesPerson;
        protected System.Windows.Forms.ListBox carMakeList;
        protected System.Windows.Forms.CheckedListBox checkedBoxRadioOptions;
        protected System.Windows.Forms.Button btnOrder;
        protected System.Windows.Forms.CheckBox checkFloorMats;
        protected System.Windows.Forms.RadioButton radioPink;
        protected System.Windows.Forms.RadioButton radioYellow;
        protected System.Windows.Forms.RadioButton radioRed;
        protected System.Windows.Forms.RadioButton radioGreen;
        protected System.Windows.Forms.GroupBox groupBox1;

        public   Calendar_1_GetvaluefromMonthCalendarcontrol()
       {
            InitializeComponent();
            CenterToScreen();

        }
        private void InitializeComponent()
        {
            this.comboSalesPerson = new System.Windows.Forms.ComboBox();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPink = new System.Windows.Forms.RadioButton();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.checkedBoxRadioOptions = new System.Windows.Forms.CheckedListBox();
            this.calendarTip = new System.Windows.Forms.ToolTip(new System.ComponentModel.Container());
            this.radioYellow = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.carMakeList = new System.Windows.Forms.ListBox();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.checkFloorMats = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            comboSalesPerson.Location = new System.Drawing.Point(16, 80);
            comboSalesPerson.Size = new System.Drawing.Size(128, 21);
            comboSalesPerson.TabIndex = 1;
            comboSalesPerson.Items.AddRange(new object[4] { "A", "B", "C", "D" });
            radioRed.Location = new System.Drawing.Point(264, 24);
            radioRed.Text = "Red";
            radioRed.Size = new System.Drawing.Size(64, 23);
            radioRed.TabIndex = 2;
            radioRed.TabStop = true;
            radioRed.BackColor = System.Drawing.SystemColors.ControlLight;
            groupBox1.Location = new System.Drawing.Point(8, 120);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Exterior Color";
            groupBox1.Size = new System.Drawing.Size(432, 56);
            groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            radioPink.Location = new System.Drawing.Point(176, 24);
            radioPink.Text = "Pink";
            radioPink.Size = new System.Drawing.Size(56, 23);
            radioPink.TabIndex = 3;
            radioPink.TabStop = true;
            radioPink.BackColor = System.Drawing.SystemColors.ControlLight;

            monthCalendar.Location = new System.Drawing.Point(20, 224);
            calendarTip.SetToolTip(monthCalendar, "Please select the date (or dates)");
            monthCalendar.TabIndex = 10;
            monthCalendar.TabStop = true;
            checkedBoxRadioOptions.Location = new System.Drawing.Point(168, 32);
            checkedBoxRadioOptions.Cursor = Cursors.Hand;
            checkedBoxRadioOptions.Size = new System.Drawing.Size(152, 64);
            checkedBoxRadioOptions.CheckOnClick = true;
            checkedBoxRadioOptions.TabIndex = 2;
            checkedBoxRadioOptions.Items.AddRange(new object[6] { "1", "2", "3", "4", "5", "6" });
            calendarTip.Active = true;
            radioYellow.Location = new System.Drawing.Point(96, 24);
            radioYellow.Text = "Yellow";
            radioYellow.Size = new System.Drawing.Size(56, 23);
            radioYellow.TabIndex = 1;
            radioYellow.TabStop = true;
            radioYellow.BackColor = System.Drawing.SystemColors.ControlLight;
            label5.Location = new System.Drawing.Point(20, 200);
            label5.Text = "Delivery Date:";
            label5.Size = new System.Drawing.Size(184, 16);
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
            label5.TabIndex = 12;
            carMakeList.Location = new System.Drawing.Point(328, 32);
            carMakeList.Size = new System.Drawing.Size(112, 56);
            carMakeList.ScrollAlwaysVisible = true;
            carMakeList.TabIndex = 3;
            carMakeList.Sorted = true;
            carMakeList.Items.AddRange(new object[9] { "A", "B", "C", "D", "E", "F", "G", "H", "I" });
            radioGreen.Location = new System.Drawing.Point(16, 24);
            radioGreen.Text = "Green";
            radioGreen.Size = new System.Drawing.Size(64, 23);
            radioGreen.TabIndex = 0;
            radioGreen.TabStop = true;
            radioGreen.BackColor = System.Drawing.SystemColors.ControlLight;

            checkFloorMats.Location = new System.Drawing.Point(16, 16);
            checkFloorMats.Text = "Extra Floor Mats";
            checkFloorMats.Size = new System.Drawing.Size(112, 24);
            checkFloorMats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            checkFloorMats.TabIndex = 0;
            label3.Location = new System.Drawing.Point(328, 8);
            label3.Text = "Make:";
            label3.Size = new System.Drawing.Size(112, 16);
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
            label3.TabIndex = 9;
            btnOrder.Location = new System.Drawing.Point(8, 440);
            btnOrder.Size = new System.Drawing.Size(120, 32);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "Confirm Order";
            btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            label1.Location = new System.Drawing.Point(16, 56);
            label1.Text = "Sales Person";
            label1.Size = new System.Drawing.Size(144, 24);
            label1.TabIndex = 7;
            label2.Location = new System.Drawing.Point(176, 8);
            label2.Text = "Radio Options:";
            label2.Size = new System.Drawing.Size(144, 16);
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
            label2.TabIndex = 8;
            this.Text = "Car Configurator";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(456, 485);
            groupBox1.Controls.Add(this.radioPink);
            groupBox1.Controls.Add(this.radioYellow);
            groupBox1.Controls.Add(this.radioRed);
            groupBox1.Controls.Add(this.radioGreen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSalesPerson);
            this.Controls.Add(this.carMakeList);
            this.Controls.Add(this.checkedBoxRadioOptions);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.checkFloorMats);
            this.Controls.Add(this.groupBox1);
        }
        protected void btnOrder_Click(object sender, System.EventArgs e)
        {
            if (comboSalesPerson.Text != "")
                Console.WriteLine("Sales Person: " + comboSalesPerson.Text);
            else
                Console.WriteLine("You did not select a sales person!");

            if (carMakeList.SelectedItem != null)
                Console.WriteLine("Make: " + carMakeList.SelectedItem);

            if (checkFloorMats.Checked)
                Console.WriteLine("You want floor mats.");

            if (radioRed.Checked)
                Console.WriteLine("You want a red exterior.");

            if (radioYellow.Checked)
                Console.WriteLine("You want a yellow exterior.");

            if (radioGreen.Checked)
                Console.WriteLine("You want a green exterior.");

            if (radioPink.Checked)
                Console.WriteLine("Why do you want a PINK exterior?");

            for (int i = 0; i < checkedBoxRadioOptions.Items.Count; i++)
            {
                if (checkedBoxRadioOptions.GetItemChecked(i))
                {
                    Console.WriteLine("Radio Item: " + checkedBoxRadioOptions.Items[i]);
                }
            }

            DateTime startD = monthCalendar.SelectionStart;
            DateTime endD = monthCalendar.SelectionEnd;

            string dateStartStr = startD.Date.ToShortDateString();
            string dateEndStr = endD.Date.ToShortDateString();

            if (dateStartStr != dateEndStr)
            {
                Console.WriteLine("Date between" + dateStartStr + " and" + dateEndStr);
            }
            else
            {
                Console.WriteLine("You chose a single date:" + dateStartStr);
            }
        }

        protected void groupBox1_Leave(object sender, System.EventArgs e)
        {
            groupBox1.Text = "Exterior Color: Thanks for visiting the group...";
        }

        protected void groupBox1_Enter(object sender, System.EventArgs e)
        {
            groupBox1.Text = "Exterior Color: You are in the group...";
        }
    }
}
