//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AddimagetoButton.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_5_AddimagetoButton:Form
    {
        private System.Windows.Forms.Button button1;
        public   Button_5_AddimagetoButton()
       {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.button1.Image = new Bitmap(global::TestCode_JAVA2S.Properties.Resources._244923_StarCraft_heroes_of_the_storm_Artanis);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(12, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 271);

            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ImagesInCommonControls";
            this.Text = "ImagesInCommonControls";
            this.ResumeLayout(false);

        }
    }
}
