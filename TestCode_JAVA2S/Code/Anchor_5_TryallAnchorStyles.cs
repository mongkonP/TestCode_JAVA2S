//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/TryallAnchorStyles.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Anchor
{ 
   public   class Anchor_5_TryallAnchorStyles:Form
    {
        private System.Windows.Forms.MenuItem dockNone;
        private System.Windows.Forms.MenuItem dockFill;
        private System.Windows.Forms.MenuItem dockRight;
        private System.Windows.Forms.MenuItem dockLeft;
        private System.Windows.Forms.MenuItem dockBottom;
        private System.Windows.Forms.MenuItem dockTop;
        private System.Windows.Forms.MenuItem mnuDock;
        private System.Windows.Forms.Button btnTheButton;
        private System.Windows.Forms.MenuItem ancRight;
        private System.Windows.Forms.MenuItem ancBottom;
        private System.Windows.Forms.MenuItem ancLeft;
        private System.Windows.Forms.MenuItem ancTop;
        private System.Windows.Forms.MenuItem mnuAnchor;
        private System.Windows.Forms.MenuItem ancNone;
        private System.Windows.Forms.MenuItem ancTopLeft;
        private System.Windows.Forms.MenuItem ancBotRight;
        private System.Windows.Forms.MenuItem ancBotLeft;
        private System.Windows.Forms.MenuItem ancTopRight;
        private System.Windows.Forms.MainMenu mnuMainMenu;
        public   Anchor_5_TryallAnchorStyles()
       {
            CenterToScreen();

            this.dockRight = new System.Windows.Forms.MenuItem();
            this.dockBottom = new System.Windows.Forms.MenuItem();
            this.ancNone = new System.Windows.Forms.MenuItem();
            this.ancTopLeft = new System.Windows.Forms.MenuItem();
            this.ancTop = new System.Windows.Forms.MenuItem();
            this.dockFill = new System.Windows.Forms.MenuItem();
            this.mnuMainMenu = new System.Windows.Forms.MainMenu();
            this.mnuAnchor = new System.Windows.Forms.MenuItem();
            this.ancLeft = new System.Windows.Forms.MenuItem();
            this.ancBottom = new System.Windows.Forms.MenuItem();
            this.ancRight = new System.Windows.Forms.MenuItem();
            this.ancTopRight = new System.Windows.Forms.MenuItem();
            this.ancBotLeft = new System.Windows.Forms.MenuItem();
            this.ancBotRight = new System.Windows.Forms.MenuItem();
            this.mnuDock = new System.Windows.Forms.MenuItem();
            this.dockTop = new System.Windows.Forms.MenuItem();
            this.dockLeft = new System.Windows.Forms.MenuItem();
            this.dockNone = new System.Windows.Forms.MenuItem();
            this.btnTheButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dockRight
            // 
            this.dockRight.Index = 3;
            this.dockRight.Text = "Right";
            this.dockRight.Click += new System.EventHandler(this.dockRight_Click);
            // 
            // dockBottom
            // 
            this.dockBottom.Index = 1;
            this.dockBottom.Text = "Bottom";
            this.dockBottom.Click += new System.EventHandler(this.dockBottom_Click);
            // 
            // ancNone
            // 
            this.ancNone.Index = 4;
            this.ancNone.Text = "None";
            this.ancNone.Click += new System.EventHandler(this.ancNone_Click);
            // 
            // ancTopLeft
            // 
            this.ancTopLeft.Index = 5;
            this.ancTopLeft.Text = "TopLeft";
            this.ancTopLeft.Click += new System.EventHandler(this.ancTopLeft_Click);
            // 
            // ancTop
            // 
            this.ancTop.Index = 0;
            this.ancTop.Text = "Top";
            this.ancTop.Click += new System.EventHandler(this.ancTop_Click);
            // 
            // dockFill
            // 
            this.dockFill.Index = 4;
            this.dockFill.Text = "Fill";
            this.dockFill.Click += new System.EventHandler(this.dockFill_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAnchor,
            this.mnuDock});
            // 
            // mnuAnchor
            // 
            this.mnuAnchor.Index = 0;
            this.mnuAnchor.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.ancTop,
            this.ancLeft,
            this.ancBottom,
            this.ancRight,
            this.ancNone,
            this.ancTopLeft,
            this.ancTopRight,
            this.ancBotLeft,
            this.ancBotRight});
            this.mnuAnchor.Text = "Anchor Value";
            // 
            // ancLeft
            // 
            this.ancLeft.Index = 1;
            this.ancLeft.Text = "Left";
            this.ancLeft.Click += new System.EventHandler(this.ancLeft_Click);
            // 
            // ancBottom
            // 
            this.ancBottom.Index = 2;
            this.ancBottom.Text = "Bottom";
            this.ancBottom.Click += new System.EventHandler(this.ancBottom_Click);
            // 
            // ancRight
            // 
            this.ancRight.Index = 3;
            this.ancRight.Text = "Right";
            this.ancRight.Click += new System.EventHandler(this.ancRight_Click);
            // 
            // ancTopRight
            // 
            this.ancTopRight.Index = 6;
            this.ancTopRight.Text = "TopRight";
            this.ancTopRight.Click += new System.EventHandler(this.ancTopRight_Click);
            // 
            // ancBotLeft
            // 
            this.ancBotLeft.Index = 7;
            this.ancBotLeft.Text = "BottomLeft";
            this.ancBotLeft.Click += new System.EventHandler(this.ancBotLeft_Click);
            // 
            // ancBotRight
            // 
            this.ancBotRight.Index = 8;
            this.ancBotRight.Text = "BottomRight";
            this.ancBotRight.Click += new System.EventHandler(this.ancBotRight_Click);
            // 
            // mnuDock
            // 
            this.mnuDock.Index = 1;
            this.mnuDock.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.dockTop,
            this.dockBottom,
            this.dockLeft,
            this.dockRight,
            this.dockFill,
            this.dockNone});
            this.mnuDock.Text = "Dock Value";
            // 
            // dockTop
            // 
            this.dockTop.Index = 0;
            this.dockTop.Text = "Top";
            this.dockTop.Click += new System.EventHandler(this.dockTop_Click);
            // 
            // dockLeft
            // 
            this.dockLeft.Index = 2;
            this.dockLeft.Text = "Left";
            this.dockLeft.Click += new System.EventHandler(this.dockLeft_Click);
            // 
            // dockNone
            // 
            this.dockNone.Index = 5;
            this.dockNone.Text = "None";
            this.dockNone.Click += new System.EventHandler(this.dockNone_Click);
            // 
            // btnTheButton
            // 
            this.btnTheButton.Location = new System.Drawing.Point(8, 16);
            this.btnTheButton.Name = "btnTheButton";
            this.btnTheButton.Size = new System.Drawing.Size(120, 40);
            this.btnTheButton.TabIndex = 0;
            this.btnTheButton.Text = "The Button";
            // 
            // AnchorForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 155);
            this.Controls.Add(this.btnTheButton);
            this.Menu = this.mnuMainMenu;
            this.Name = "AnchorForm";
            this.Text = "Anchoring and Docking Controls";
            this.ResumeLayout(false);

        }
        protected void dockNone_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.None;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockFill_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Fill;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockBottom_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Bottom;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void dockTop_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Dock = DockStyle.Top;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancBottom_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Bottom;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        protected void ancTop_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Top;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancNone_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.None;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancTopLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancTopRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancBotLeft_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }

        private void ancBotRight_Click(object sender, System.EventArgs e)
        {
            btnTheButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTheButton.Text = "Anchor: " + btnTheButton.Anchor.ToString() +
                "\nDock: " + btnTheButton.Dock.ToString();
        }


    }
}
