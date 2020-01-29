//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/ClipText.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Clipboard
{ 
   public   class Clipboard_3_ClipText:Form
    {
        string strText = "Sample text";
        MenuItem miCut, miCopy, miPaste;
        public   Clipboard_3_ClipText()
       {


            ResizeRedraw = true;

            Menu = new MainMenu();
            MenuItem mi = new MenuItem("&Edit");
            mi.Popup += new EventHandler(MenuEditOnPopup);
            Menu.MenuItems.Add(mi);
            miCut = new MenuItem("Cu&t");
            miCut.Click += new EventHandler(MenuEditCutOnClick);
            miCut.Shortcut = Shortcut.CtrlX;
            Menu.MenuItems[0].MenuItems.Add(miCut);

            miCopy = new MenuItem("&Copy");
            miCopy.Click += new EventHandler(MenuEditCopyOnClick);
            miCopy.Shortcut = Shortcut.CtrlC;
            Menu.MenuItems[0].MenuItems.Add(miCopy);

            miPaste = new MenuItem("&Paste");
            miPaste.Click += new EventHandler(MenuEditPasteOnClick);
            miPaste.Shortcut = Shortcut.CtrlV;
            Menu.MenuItems[0].MenuItems.Add(miPaste);
        }
        void MenuEditOnPopup(object obj, EventArgs ea)
        {
            miCut.Enabled = miCopy.Enabled = strText.Length > 0;
            miPaste.Enabled = Clipboard.GetDataObject().GetDataPresent(typeof(string));
        }
        void MenuEditCutOnClick(object obj, EventArgs ea)
        {
            MenuEditCopyOnClick(obj, ea);
            strText = "";
            Invalidate();
        }
        void MenuEditCopyOnClick(object obj, EventArgs ea)
        {
            Clipboard.SetDataObject(strText, true);
        }
        void MenuEditPasteOnClick(object obj, EventArgs ea)
        {
            IDataObject data = Clipboard.GetDataObject();

            if (data.GetDataPresent(typeof(string)))
                strText = (string)data.GetData(typeof(string));

            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            StringFormat strfmt = new StringFormat();
            strfmt.Alignment = strfmt.LineAlignment = StringAlignment.Center;

            grfx.DrawString(strText, Font, new SolidBrush(ForeColor),
                            ClientRectangle, strfmt);
        }
    }
}
