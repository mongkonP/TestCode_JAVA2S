//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/RichTextPaste.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Clipboard
{ 
   public   class Clipboard_5_RichTextPaste:Form
    {
        string strPastedText = "";
        MenuItem miPastePlain, miPasteRTF, miPasteHTML, miPasteCSV;
        public   Clipboard_5_RichTextPaste()
       {


            ResizeRedraw = true;

            Menu = new MainMenu();

            MenuItem mi = new MenuItem("&Edit");
            mi.Popup += new EventHandler(MenuEditOnPopup);
            Menu.MenuItems.Add(mi);

            miPastePlain = new MenuItem("Paste &Plain Text");
            miPastePlain.Click += new EventHandler(MenuEditPastePlainOnClick);
            Menu.MenuItems[0].MenuItems.Add(miPastePlain);

            miPasteRTF = new MenuItem("Paste &Rich Text Format");
            miPasteRTF.Click += new EventHandler(MenuEditPasteRTFOnClick);
            Menu.MenuItems[0].MenuItems.Add(miPasteRTF);

            miPasteHTML = new MenuItem("Paste &HTML");
            miPasteHTML.Click += new EventHandler(MenuEditPasteHTMLOnClick);
            Menu.MenuItems[0].MenuItems.Add(miPasteHTML);

            miPasteCSV = new MenuItem("Paste &Comma-Separated Values");
            miPasteCSV.Click += new EventHandler(MenuEditPasteCSVOnClick);
            Menu.MenuItems[0].MenuItems.Add(miPasteCSV);
        }
        void MenuEditOnPopup(object obj, EventArgs ea)
        {
            miPastePlain.Enabled = Clipboard.GetDataObject().GetDataPresent(typeof(string));
            miPasteRTF.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Rtf);
            miPasteHTML.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Html);
            miPasteCSV.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.CommaSeparatedValue);
        }
        void MenuEditPastePlainOnClick(object obj, EventArgs ea)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(typeof(string)))
            {
                strPastedText = (string)data.GetData(typeof(string));
                Invalidate();
            }
        }
        void MenuEditPasteRTFOnClick(object obj, EventArgs ea)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(DataFormats.Rtf))
            {
                strPastedText = (string)data.GetData(DataFormats.Rtf);
                Invalidate();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Clipboard_5_RichTextPaste
            // 
            this.ClientSize = new System.Drawing.Size(1131, 639);
            this.Name = "Clipboard_5_RichTextPaste";
            this.ResumeLayout(false);

        }

        void MenuEditPasteHTMLOnClick(object obj, EventArgs ea)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(DataFormats.Html))
            {
                strPastedText = (string)data.GetData(DataFormats.Html);
                Invalidate();
            }
        }
        void MenuEditPasteCSVOnClick(object obj, EventArgs ea)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                MemoryStream memstr = (MemoryStream)data.GetData("Csv");
                StreamReader streamreader = new StreamReader(memstr);
                strPastedText = streamreader.ReadToEnd();
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            pea.Graphics.DrawString(strPastedText, Font, new SolidBrush(ForeColor),
                            ClientRectangle);
        }
    }
}
