//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ButtonImageSizeParent.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_1_ButtonImageSizeParent:Form
    {
        int cxBtn, cyBtn, dxBtn;
        Button btnLarger, btnSmaller;

        public Button_1_ButtonImageSizeParent()
       {
            ResizeRedraw = true;

            dxBtn = Font.Height;
            btnLarger = new Button();
            btnLarger.Parent = this;
            btnLarger.Image = new Bitmap( global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);

            cxBtn = btnLarger.Image.Width + 8;
            cyBtn = btnLarger.Image.Height + 8;

            btnLarger.Size = new Size(cxBtn, cyBtn);
            btnLarger.Click += new EventHandler(ButtonLargerOnClick);

            btnSmaller = new Button();
            btnSmaller.Parent = this;
            btnSmaller.Image = new Bitmap(global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);
            btnSmaller.Size = new Size(cxBtn, cyBtn);
            btnSmaller.Click += new EventHandler(ButtonSmallerOnClick);

            OnResize(EventArgs.Empty);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Button_1_ButtonImageSizeParent
            // 
            this.ClientSize = new System.Drawing.Size(1502, 918);
            this.Name = "Button_1_ButtonImageSizeParent";
            this.ResumeLayout(false);

        }

        protected override void OnResize(EventArgs ea)
        {
            base.OnResize(ea);

            btnLarger.Location = new Point(ClientSize.Width / 2 - cxBtn - dxBtn / 2,
                                    (ClientSize.Height - cyBtn) / 2);
            btnSmaller.Location = new Point(ClientSize.Width / 2 + dxBtn / 2,
                                    (ClientSize.Height - cyBtn) / 2);
        }
        void ButtonLargerOnClick(object obj, EventArgs ea)
        {
            Left = 50;
            Top = 50;
            Width = 50;
            Height = 50;
        }
        void ButtonSmallerOnClick(object obj, EventArgs ea)
        {
            Left = 200;
            Top = 200;
            Width = 20;
            Height = 20;
        }
    }
}
