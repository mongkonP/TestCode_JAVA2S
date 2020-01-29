//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Setcontrolborderstyle.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Border
{ 
   public   class Border_2_Setcontrolborderstyle:Form
    {
        private Button btnLoad;
        private PictureBox imgPhoto;
        public   Border_2_Setcontrolborderstyle()
       {
            this.Text = "www.java2s.com";

            btnLoad = new Button();
            btnLoad.Text = "&Load";
            btnLoad.Left = 10;
            btnLoad.Top = 10;

            imgPhoto = new PictureBox();
            imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            imgPhoto.Width = this.Width / 2;
            imgPhoto.Height = this.Height / 2;
            imgPhoto.Left = (this.Width - imgPhoto.Width) / 2;
            imgPhoto.Top = (this.Height - imgPhoto.Height) / 2;

            this.Controls.Add(btnLoad);
            this.Controls.Add(imgPhoto);

        }
    }
}
