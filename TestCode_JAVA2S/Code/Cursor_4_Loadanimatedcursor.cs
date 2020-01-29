//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/Loadanimatedcursor.htm


using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace TestCode_JAVA2S._Cursor
{ 
   public   class Cursor_4_Loadanimatedcursor:Form
    { 
       public   Cursor_4_Loadanimatedcursor()
       {


            InitializeComponent();
            try
            {
                this.Cursor = AdvancedCursors.Create(Path.Combine(Application.StartupPath, "blob.ani"));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Text = "Form1";
            this.ResumeLayout(false);
        }


        class AdvancedCursors
        {

            [DllImport("User32.dll")]
            private static extern IntPtr LoadCursorFromFile(String str);

            public static Cursor Create(string filename)
            {
                IntPtr hCursor = LoadCursorFromFile(filename);

                if (!IntPtr.Zero.Equals(hCursor))
                {
                    return new Cursor(hCursor);
                }
                else
                {
                    throw new ApplicationException("Could not create cursor from file " + filename);
                }
            }
        }
    }

     
}
